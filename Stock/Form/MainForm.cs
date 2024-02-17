﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using LinqToDB;
using DataModels;
using System.Globalization;
using Stock.CS;
using System.Net.Sockets;
using System.Net;

namespace Stock
{
    public partial class MainForm : Form
    {
        #region 初始宣告
        MyFunction myFunction = new MyFunction();
        SQliteDb SQlite = new SQliteDb();
        StockDB db = new StockDB();
        ParseData parseData = new ParseData();
        public List<Model.MS1.Result> S1FinalResult = new List<Model.MS1.Result>();
        public List<Model.MS1.S2Result> S2FinalResult = new List<Model.MS1.S2Result>();
        public List<Model.MS1.S3Result> S3FinalResult = new List<Model.MS1.S3Result>();
        DataTable OutputTable = new DataTable();
        /// <summary>
        /// 選股 true 回測 false
        /// </summary>
        bool IsPick = false;
        /// <summary>
        /// 暫停
        /// </summary>
        bool Pause = false;
        /// <summary>
        /// 資料爬取狀態
        /// </summary>
        bool dataReady = false;
        #endregion
        public MainForm()
        {
            InitializeComponent();
            // 預設策略
            cb_Strategy.SelectedIndex = 0;
        }

        #region 控制項事件

        #region Form
        private void MainForm_Load(object sender, EventArgs e)
        {
            myFunction.CheckDataTableExist();
             
            string Date = DateTime.Today.ToString("yyyy/MM/dd");
            dp_start.Value = myFunction.GetLastBacktestDay(Date);
            dp_end.Value = myFunction.GetLastBacktestDay(Date);
            dp_pickDate.Value = myFunction.GetPickDay(Date);
            //dp_pickDate.Value = Convert.ToDateTime("2023-02-16");
            //dp_start.Value = Convert.ToDateTime("2016-01-01");
            //dp_end.Value = Convert.ToDateTime("2022-02-08");

            IniController();
            TipMessage();
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (!ckcb_parse.Checked)
            {
                dataReady = true;
                lb_status.Text = "---";
                lb_status.ForeColor = Color.Green;
            }
            else
            {
                Thread getData = new Thread(ParseData);
                getData.Start();
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!dataReady)
            {

                if (MessageBox.Show("資料爬取中，若強制關閉可能導致資料庫錯誤，您確認退出嗎?", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    Dispose();
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region Button
        private void btn_run_Click(object sender, EventArgs e)
        {
            IsPick = false;
            Pause = false;
            lb_status.ForeColor = Color.Orange;
            Thread Run = new Thread(Mission);
            Run.Start();
        }
        private void btn_excelOutput_Click(object sender, EventArgs e)
        {
            ExcelWriter excel = new ExcelWriter();
            if (string.IsNullOrEmpty(txt_fileName.Text))
            {
                MessageBox.Show("請輸入檔名", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgv_result.Rows.Count < 1)
            {
                MessageBox.Show("沒有資料", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (File.Exists(Application.StartupPath + @"\Excel\" + txt_fileName.Text + ".xls"))
            {
                if (MessageBox.Show("檔名已存在，是否覆蓋", "文件已存在", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    excel.DataGridViewToExcel(txt_fileName.Text, dgv_result, OutputTable);
                else
                    return;
            }
            else
            {
                excel.DataGridViewToExcel(txt_fileName.Text, dgv_result, OutputTable);
            }
        }
        private void btn_pick_Click(object sender, EventArgs e)
        {
            IsPick = true;
            lb_status.ForeColor = Color.Orange;
            Thread Run = new Thread(Mission);
            Run.Start();
        }
        private void btn_pause_Click(object sender, EventArgs e)
        {
            Pause = true;
        }
        private void btn_smartExcel_Click(object sender, EventArgs e)
        {
            ExcelWriter writer = new ExcelWriter();

            string Path = Application.StartupPath + @"\Excel\SmartPicker";
            if (!Directory.Exists(Path))
                Directory.CreateDirectory(Path);

            List<Model.MS1.SmartExcelResult> SmartData = new List<Model.MS1.SmartExcelResult>();

            // -1 => 最後一行為空
            for (int rows = 0; rows < dgv_result.Rows.Count - 1; rows++)
            {
                Model.MS1.SmartExcelResult data = new Model.MS1.SmartExcelResult();
                data.Id = dgv_result.Rows[rows].Cells[2].Value.ToString();
                data.Name = dgv_result.Rows[rows].Cells[3].Value.ToString();
                data.Close = dgv_result.Rows[rows].Cells[7].Value.ToString();
                data.TurnoverRate = dgv_result.Rows[rows].Cells[8].Value.ToString();
                data.DealPrice = dgv_result.Rows[rows].Cells[9].Value.ToString();
                data.MaxPrice = myFunction.LookUpDown(Convert.ToDecimal(dgv_result.Rows[rows].Cells[10].Value))[0].ToString();
                SmartData.Add(data);
            }

            if (dgv_result.Rows.Count < 1)
            {
                MessageBox.Show("沒有資料", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (File.Exists(Application.StartupPath + @"\Excel\SmartPicker\" + dp_pickDate.Value.ToString("yyyyMMdd") + ".xlsx"))
            {
                if (MessageBox.Show("檔名已存在，是否覆蓋", "文件已存在", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    writer.SmartPickToExcel(dp_pickDate.Value.ToString("yyyyMMdd"), SmartData);
                else
                    return;
            }
            else
                writer.SmartPickToExcel(dp_pickDate.Value.ToString("yyyyMMdd"), SmartData);
        }
        private void btn_order_Click(object sender, EventArgs e)
        {
            List<Model.MS1.OrderInit> temp = new List<Model.MS1.OrderInit>();
            if (dgv_result.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_result.Rows)
                {
                    if (!string.IsNullOrEmpty(row.Cells[2].Value.ToString()))
                    {
                        Model.MS1.OrderInit init = new Model.MS1.OrderInit();
                        init.Id = row.Cells[2].Value.ToString();
                        init.Name = row.Cells[3].Value.ToString();
                        init.Price = row.Cells[7].Value.ToString();
                        temp.Add(init);
                    }
                }
            }
            OrderForm orderForm = new OrderForm(temp);
            orderForm.Show();
        }
        private void btn_manualparse_Click(object sender, EventArgs e)
        {
            dataReady = false;
            Thread getData = new Thread(ParseData);
            getData.Start();
        }
        #endregion

        #region Others
        private void ckcb_s1FlUp_ValueChanged(object sender, bool value)
        {
            if (ckcb_s1FlUp.Checked)
            {
                ckcb_s1FlDown.Checked = false;
                ckcb_S1UpredK.Checked = false;
            }
        }
        private void ckcb_s1FlDown_ValueChanged(object sender, bool value)
        {
            if (ckcb_s1FlDown.Checked)
            {
                ckcb_s1FlUp.Checked = false;
                ckcb_S1UpredK.Checked = false;
            }
        }
        private void ckcb_redK_ValueChanged(object sender, bool value)
        {
            if (ckcb_redK.Checked)
            {
                ckcb_S1UpredK.Checked = false;
            }
        }
        private void ckcb_S1UpredK_ValueChanged(object sender, bool value)
        {
            if (ckcb_S1UpredK.Checked)
            {
                ckcb_s1FlUp.Checked = false;
                ckcb_s1FlDown.Checked = false;
                ckcb_redK.Checked = false;
            }
        }
        private void capitalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ListedFunction.WriteCapitalToSQL();
        }
        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process DbOpener = new Process();
            DbOpener.StartInfo.FileName = @"C:Data\";
            DbOpener.Start();
        }
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void openExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Process Open = new Process())
            {
                string Path = Application.StartupPath + @"\Excel";
                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);

                Open.StartInfo.FileName = Path;
                Open.Start();
            }
        }
        private void smartPickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Process Open = new Process())
            {
                string Path = Application.StartupPath + @"\Excel\SmartPicker";
                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);

                Open.StartInfo.FileName = Path;
                Open.Start();
            }
        }
        private void DonateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("歡迎贊助開發人員 Eric Huang，您的支持是我持續更新的動力哦 ! 贊助帳號如下 :" + Environment.NewLine + "(013) 699510138591", "贊助起來");
        }
        private void QueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.Show();
        }
        private void BlogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://secrettime11.github.io/Brumby/");
        }
        private void MarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("自104年 6月1日起，將漲跌幅度由7%放寬為10%。\n信用交易整戶擔保維持率自104年5月4日起調整為130%");
        }
        private void analyzeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalyzeForm analyzeForm = new AnalyzeForm();
            analyzeForm.Show();
        }
        private void setIniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定變更初始設置?", "提醒", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                #region 公用變數
                SettingConfig.modifyitem("ckcb_daytrade", ckcb_daytrade.Checked.ToString());
                SettingConfig.modifyitem("rdb_ultimate", rdb_ultimate.Checked.ToString());
                SettingConfig.modifyitem("rdb_bigger", rdb_bigger.Checked.ToString());
                SettingConfig.modifyitem("rdb_smaller", rdb_smaller.Checked.ToString());
                SettingConfig.modifyitem("UpDown_closePrice", UpDown_closePrice.Value.ToString());
                SettingConfig.modifyitem("rdb_between", rdb_between.Checked.ToString());
                SettingConfig.modifyitem("txt_c1", txt_c1.Text);
                SettingConfig.modifyitem("txt_c2", txt_c2.Text);
                SettingConfig.modifyitem("ud_pickquantity", ud_pickquantity.Value.ToString());
                SettingConfig.modifyitem("ud_avgDays", ud_avgDays.Value.ToString());
                SettingConfig.modifyitem("ud_testDays", ud_testDays.Value.ToString());
                SettingConfig.modifyitem("ckcb_parse", ckcb_parse.Checked.ToString());
                #endregion

                #region 獲利計算模組
                SettingConfig.modifyitem("rdb_proDaytradeYes", rdb_proDaytradeYes.Checked.ToString());
                SettingConfig.modifyitem("rdb_proDaytradeNo", rdb_proDaytradeNo.Checked.ToString());
                SettingConfig.modifyitem("rdb_s1ProfitShort", rdb_s1ProfitShort.Checked.ToString());
                SettingConfig.modifyitem("rdb_s1ProfitLong", rdb_s1ProfitLong.Checked.ToString());
                SettingConfig.modifyitem("rdb_InOpen", rdb_InOpen.Checked.ToString());
                SettingConfig.modifyitem("rdb_InUnder", rdb_InUnder.Checked.ToString());
                SettingConfig.modifyitem("rdb_InUpper", rdb_InUpper.Checked.ToString());
                SettingConfig.modifyitem("ud_InTick", ud_InTick.Value.ToString());
                SettingConfig.modifyitem("ud_loss", ud_loss.Value.ToString());
                SettingConfig.modifyitem("ud_earn", ud_earn.Value.ToString());
                SettingConfig.modifyitem("txt_discount", txt_discount.Text);
                #endregion

                #region 策略一
                SettingConfig.modifyitem("ckcb_s1TurnoverTop", ckcb_s1TurnoverTop.Checked.ToString());
                SettingConfig.modifyitem("ckcb_s1TurnoverBigger", ckcb_s1TurnoverBigger.Checked.ToString());
                SettingConfig.modifyitem("ckcb_s1TurnoverSmaller", ckcb_s1TurnoverSmaller.Checked.ToString());
                SettingConfig.modifyitem("ud_s1TurnoverTop", ud_s1TurnoverTop.Value.ToString());
                SettingConfig.modifyitem("ud_s1TurnoverBigger", ud_s1TurnoverBigger.Value.ToString());
                SettingConfig.modifyitem("ud_s1TurnoverSmaller", ud_s1TurnoverSmaller.Value.ToString());
                SettingConfig.modifyitem("ckcb_s1FlUp", ckcb_s1FlUp.Checked.ToString());
                SettingConfig.modifyitem("ckcb_s1FlDown", ckcb_s1FlDown.Checked.ToString());
                SettingConfig.modifyitem("ckcb_redK", ckcb_redK.Checked.ToString());
                SettingConfig.modifyitem("ckcb_S1UpredK", ckcb_S1UpredK.Checked.ToString());
                SettingConfig.modifyitem("rdb_s1MajorBuy", rdb_s1MajorBuy.Checked.ToString());
                SettingConfig.modifyitem("rdb_s1MajorSell", rdb_s1MajorSell.Checked.ToString());
                SettingConfig.modifyitem("rdb_s1MajorNone", rdb_s1MajorNone.Checked.ToString());
                SettingConfig.modifyitem("rdb_THigh", rdb_THigh.Checked.ToString());
                SettingConfig.modifyitem("rdb_TClose", rdb_TClose.Checked.ToString());
                SettingConfig.modifyitem("rdb_s1HighYes", rdb_s1HighYes.Checked.ToString());
                SettingConfig.modifyitem("rdb_s1HighNo", rdb_s1HighNo.Checked.ToString());
                SettingConfig.modifyitem("rdb_s1HighNone", rdb_s1HighNone.Checked.ToString());
                SettingConfig.modifyitem("rdb_highVirtual", rdb_highVirtual.Checked.ToString());
                SettingConfig.modifyitem("rdb_highReal", rdb_highReal.Checked.ToString());
                #endregion

                #region 策略一擴充條件
                SettingConfig.modifyitem("ckcb_highStopLoss", ckcb_highStopLoss.Checked.ToString());
                SettingConfig.modifyitem("ckcb_tPrice", ckcb_tPrice.Checked.ToString());
                SettingConfig.modifyitem("ud_tPrice", ud_tPrice.Value.ToString());
                SettingConfig.modifyitem("ckcb_highVolume", ckcb_highVolume.Checked.ToString());
                SettingConfig.modifyitem("ud_highVolume", ud_highVolume.Value.ToString());
                SettingConfig.modifyitem("ckcb_notHighDis", ckcb_notHighDis.Checked.ToString());
                SettingConfig.modifyitem("txt_notHighDisValue", txt_notHighDisValue.Text);
                SettingConfig.modifyitem("ckcb_dealpriceOrder", ckcb_dealpriceOrder.Checked.ToString());
                SettingConfig.modifyitem("ckcb_displayDealpriceAvg", ckcb_displayDealpriceAvg.Checked.ToString());
                SettingConfig.modifyitem("rdb_max", rdb_max.Checked.ToString());
                SettingConfig.modifyitem("rdb_notMax", rdb_notMax.Checked.ToString());
                SettingConfig.modifyitem("rdb_noneMax", rdb_noneMax.Checked.ToString());
                SettingConfig.modifyitem("rdb_vibBig", rdb_vibBig.Checked.ToString());
                SettingConfig.modifyitem("rdb_vibSmall", rdb_vibSmall.Checked.ToString());
                SettingConfig.modifyitem("rdb_vidNone", rdb_vidNone.Checked.ToString());
                SettingConfig.modifyitem("txt_vibValue", txt_vibValue.Text);
                #endregion

                #region 策略二
                SettingConfig.modifyitem("rdb_S2Turnoverrate", rdb_S2Turnoverrate.Checked.ToString());
                SettingConfig.modifyitem("ud_S2Turnoverrate", ud_S2Turnoverrate.Value.ToString());
                SettingConfig.modifyitem("rdb_S2topLineTrue", rdb_S2topLineTrue.Checked.ToString());
                SettingConfig.modifyitem("rdb_S2topLineFalse", rdb_S2topLineFalse.Checked.ToString());
                #endregion

                #region 策略三
                SettingConfig.modifyitem("rdb_S3Turnoverrate", rdb_S3Turnoverrate.Checked.ToString());
                SettingConfig.modifyitem("ud_S3Turnoverrate", ud_S3Turnoverrate.Value.ToString());
                #endregion

                MessageBox.Show("變更設置成功。");
            }
            else
            {
                return;
            }
        }
        #endregion

        #endregion

        #region 自訂義函數
        /// <summary>
        /// 主要執行函數
        /// </summary>
        private void Mission()
        {
            Args args = new Args();
            InitialArgs(args);

            if (FoolProof(args))
            {
                // Strategy one
                if (cb_Strategy.SelectedIndex == 0)
                {
                    S1Initial(args);
                    if (IsPick)
                    {
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            lb_status.Text = args.PickDate;
                        });
                        args.DaysOneRun = new List<string>();
                        S1(args, args.PickDate, IsPick);
                    }
                    else
                    {
                        foreach (var Day in args.BacktestDates)
                        {
                            if (!Pause)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    lb_status.Text = Day;
                                });
                                args.DaysOneRun = new List<string>();
                                S1(args, Day, IsPick);
                            }
                        }
                    }
                    OutputTable = myFunction.S1ListToDGV(S1FinalResult, IsPick, args.DisplayDealpriceAvg);
                    this.Invoke((MethodInvoker)delegate
                    {
                        dgv_result.DataSource = OutputTable;
                    });
                }
                // Strategy two
                else if (cb_Strategy.SelectedIndex == 1)
                {
                    S2Initial(args);
                    foreach (var Day in args.BacktestDates)
                    {
                        if (!Pause)
                        {
                            this.Invoke((MethodInvoker)delegate ()
                            {
                                lb_status.Text = Day;
                            });
                            args.DaysOneRun = new List<string>();
                            S2(args, Day);
                        }
                    }
                    OutputTable = myFunction.S2ListToDGV(S2FinalResult);
                    this.Invoke((MethodInvoker)delegate
                    {
                        dgv_result.DataSource = OutputTable;
                    });
                }
                // Strategy three
                else if (cb_Strategy.SelectedIndex == 2)
                {
                    S3Initial(args);
                    foreach (var Day in args.BacktestDates)
                    {
                        if (!Pause)
                        {
                            this.Invoke((MethodInvoker)delegate ()
                            {
                                lb_status.Text = Day;
                            });
                            args.DaysOneRun = new List<string>();
                            S3(args, Day);
                        }
                    }
                    OutputTable = myFunction.S3ListToDGV(S3FinalResult, false);
                    this.Invoke((MethodInvoker)delegate
                    {
                        dgv_result.DataSource = OutputTable;
                    });
                }

                this.Invoke((MethodInvoker)delegate ()
                {
                    lb_status.Text = "完成";
                    lb_status.ForeColor = Color.DarkGreen;
                });
            }
        }
        /// <summary>
        /// 策略一
        /// </summary>
        /// <param name="args"></param>
        /// <param name="Day"></param>
        /// <param name="IsPick"></param>
        private void S1(Args args, string Day, bool IsPick)
        {
            // 單次回測所有前高比對日期
            args.DaysOneRun = myFunction.GetEachTestDates(Day, args.totalTestDays);
            string[] OneRunDates = args.DaysOneRun.ToArray();

            /* 待測日周轉前x */
            var data = (
                    from c in db.Listeds
                    where c.Date == myFunction.VidsDumpSlash(Day) && c.TurnoverRate != "N"
                    select new { c.Id, c.Type, c.TurnoverRate, c.Close, c.High, c.Open, c.Low, c.UpDown, c.DealPrice }
                ).Union
                (
                    from o in db.Otcs
                    where o.Date == myFunction.VidsDumpSlash(Day)
                    select new { o.Id, o.Type, o.TurnoverRate, o.Close, o.High, o.Open, o.Low, o.UpDown, o.DealPrice }
                ).OrderByDescending(m => Convert.ToDouble(m.TurnoverRate)).Take(Convert.ToInt32(args.TurnoverDic["Top"])).ToList();

            // 以成交值排行
            if (ckcb_dealpriceOrder.Checked)
                data = data.OrderByDescending(x => Int64.Parse(x.DealPrice, NumberStyles.AllowThousands)).ToList();

            List<Model.MS1.First> First = new List<Model.MS1.First>();

            foreach (var item in data)
            {
                try
                {
                    Model.MS1.First Info = new Model.MS1.First();
                    Info.Id = item.Id;
                    Info.Type = item.Type;
                    Info.Close = item.Close;
                    Info.High = item.High;
                    Info.Open = item.Open;
                    Info.Low = item.Low;
                    Info.UpDown = item.UpDown;
                    Info.TurnoverRate = item.TurnoverRate;
                    Info.DealPrice = item.DealPrice;

                    decimal MarketClose = Convert.ToDecimal(item.Close);
                    decimal SetClose = Convert.ToDecimal(args.ClosePrice);
                    bool Pass = false;

                    // 紅K
                    if (ckcb_redK.Checked)
                    {
                        if (args.s1UpDown != "None")
                        {
                            if (item.UpDown.Contains(args.s1UpDown) || Convert.ToDecimal(item.Open) < MarketClose)
                                Pass = true;
                        }
                        else
                        {
                            if (Convert.ToDecimal(item.Open) < MarketClose)
                                Pass = true;
                        }
                    }
                    // 上漲 && 紅K
                    else if (ckcb_S1UpredK.Checked)
                    {
                        if (args.s1UpDown != "None")
                        {
                            if (item.UpDown.Contains(args.s1UpDown) && Convert.ToDecimal(item.Open) < MarketClose)
                                Pass = true;
                        }
                    }
                    // 漲跌
                    else
                    {
                        if (item.UpDown.Contains(args.s1UpDown))
                            Pass = true;
                    }

                    if (Pass)
                    {
                        // 收盤
                        if (args.closeCondition == 1)
                        {
                            if (MarketClose >= SetClose)
                                First.Add(Info);
                        }
                        else if (args.closeCondition == 2)
                        {
                            if (MarketClose <= SetClose)
                                First.Add(Info);
                        }
                        else if (args.closeCondition == 3)
                        {
                            if (MarketClose <= Convert.ToDecimal(args.close2) && MarketClose >= Convert.ToDecimal(args.close1))
                                First.Add(Info);
                        }
                        else
                        {
                            First.Add(Info);
                        }
                    }
                }
                catch (Exception) { }
            }
            List<Model.MS1.Second> Second = new List<Model.MS1.Second>();
            int counter = 0;
           
            // 最高價
            foreach (var item in First)
            {
                Model.MS1.Second Info = new Model.MS1.Second();
                object Max = new object();
                try
                {
                    // 買賣超
                    string BuySell = string.Empty;
                    if (item.Type == "市")
                    {
                       
                        //if (args.s1HighType)
                        //{
                        //    Max = db.Listeds.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date)).Max(p => Convert.ToDouble(p.Close));
                        //}
                        //Max = db.Listeds.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date)).Max(p => Convert.ToDouble(p.High));


                        var temp = db.Listeds.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date)).Select(p => p.High);
                        if (args.s1HighType)
                        {
                            temp = db.Listeds.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date)).Select(p => p.Close);
                        }
                        List<double> highList = new List<double>();
                        foreach (var tempHigh in temp)
                        {
                            highList.Add(double.Parse(tempHigh));
                        }
                        Max = highList.Max();

                        BuySell = db.ListedBuySells.Where(p => p.Id == item.Id && p.Date == myFunction.VidsDumpSlash(Day)).FirstOrDefault().MBuySell;
                    }
                    else if (item.Type == "櫃")
                    {
                        //Max = db.Otcs.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date)).Max(p => Convert.ToDouble(p.High));
                        //if (args.s1HighType)
                        //    Max = db.Otcs.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date)).Max(p => Convert.ToDouble(p.Close));

                        var temp = db.Otcs.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date)).Select(p => p.High);
                        if (args.s1HighType)
                        {
                            temp = db.Otcs.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date)).Select(p => p.Close);
                        }

                        List<double> highList = new List<double>();
                        foreach (var tempHigh in temp)
                        {
                            highList.Add(double.Parse(tempHigh));
                        }
                        Max = highList.Max();

                        BuySell = db.OTCBuySells.Where(p => p.Id == item.Id && p.Date == myFunction.VidsDumpSlash(Day)).FirstOrDefault().MBuySell;
                    }

                    if (BuySell == string.Empty)
                    {
                        continue;
                    }

                    // 前高
                    double HighT = Convert.ToDouble(item.High);
                    if (!args.THighClose)
                        HighT = Convert.ToDouble(item.Close);

                    // [成交值,波動,前高數量,買賣超,前高距離]
                    bool[] Check = new bool[] { true, true, true, true, true };

                    double highPercent = 0;

                    if (HighT <= (double)Max)
                    {
                        highPercent = (((double)Max - HighT) / HighT) * 100;
                        // 前高距離
                        if (ckcb_notHighDis.Checked)
                        {
                            if (Convert.ToDouble(args.NotHighDisValue) > highPercent)
                                Check[4] = false;
                        }
                        // 成交值
                        if (ckcb_tPrice.Checked)
                        {
                            if (Convert.ToInt64(item.DealPrice.Replace(",", "").Trim()) < Convert.ToInt64(args.s1tPrice) * 100000000)
                                Check[0] = false;
                        }

                        // 漲跌幅波動值
                        double vibRate = Math.Abs((Convert.ToDouble(item.Close) - Convert.ToDouble(item.Open)) / Convert.ToDouble(item.Close)) * 100;
                        if (rdb_vibBig.Checked)
                        {
                            if (vibRate < Convert.ToDouble(args.s1VibValue)) Check[1] = false;
                        }
                        else if (rdb_vibSmall.Checked)
                        {
                            if (vibRate > Convert.ToDouble(args.s1VibValue)) Check[1] = false;
                        }

                        // 前高數量
                        int count = 0;
                        if (item.Type == "市")
                            count = db.Listeds.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date) && Convert.ToDouble(p.High) > HighT).Count();
                        else if (item.Type == "櫃")
                            count = db.Otcs.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date) && Convert.ToDouble(p.High) > HighT).Count();
                        if (ckcb_highVolume.Checked)
                            if (count < Convert.ToInt32(args.highVolume))
                                Check[2] = false;

                        if (item.Type == "市")
                            BuySell = db.ListedBuySells.Where(p => p.Id == item.Id && p.Date == myFunction.VidsDumpSlash(Day)).FirstOrDefault().MBuySell;
                        else if (item.Type == "櫃")
                            BuySell = db.OTCBuySells.Where(p => p.Id == item.Id && p.Date == myFunction.VidsDumpSlash(Day)).FirstOrDefault().MBuySell;

                        if (rdb_s1MajorBuy.Checked)
                        {
                            if (BuySell.Contains("-") || BuySell == "0")
                                Check[3] = false;
                        }
                        else if (rdb_s1MajorSell.Checked)
                        {
                            if (!BuySell.Contains("-") || BuySell == "0")
                                Check[3] = false;
                        }
                        else
                        {
                            Check[3] = true;
                        }

                        if (!Check.Contains(false))
                        {

                            Info.Id = item.Id;
                            Info.Type = item.Type;
                            Info.Close = item.Close;
                            Info.Open = item.Open;
                            Info.High = item.High;
                            Info.Low = item.Low;
                            Info.TurnoverRate = item.TurnoverRate;
                            Info.PreMax = Max.ToString();
                            Info.HighVolume = count.ToString();
                            Info.HighPercent = highPercent.ToString("F3");
                            Info.BuySell = BuySell;
                            Second.Add(Info);
                            counter++;
                        }
                    }
                }
                catch (Exception ex)
                {
                }

                if (counter == Convert.ToInt32(args.pickQuantity))
                {
                    break;
                }
            }

            // 結果
            int OrderC = 1;
            double total = 0;
            long dealpriceTotal = 0;

            foreach (var item in Second)
            {
                Model.MS1.Result temp = new Model.MS1.Result();
                try
                {
                    if (item.Type == "市")
                    {
                        if (IsPick == false)
                        {
                            var info = db.Listeds.Where(p => p.Date == myFunction.GetTomorrow(Day) && p.Id == item.Id).FirstOrDefault();
                            var yinfo = db.Listeds.Where(p => p.Date == myFunction.VidsDumpSlash(Day) && p.Id == item.Id).FirstOrDefault();
                            var yyinfo = db.Listeds.Where(p => p.Date == myFunction.GetYesterday(Day) && p.Id == item.Id).FirstOrDefault();
                            temp.Date = myFunction.VidsDumpSlash(Day);
                            temp.Type = info.Type;
                            temp.Id = info.Id;
                            temp.Name = info.Name;
                            temp.Close = item.Close;
                            temp.Open = item.Open;
                            temp.High = item.High;
                            temp.Low = item.Low;
                            temp.TurnoverRate = item.TurnoverRate;
                            temp.OpenT = info.Open;
                            temp.HighT = info.High;
                            temp.LowT = info.Low;
                            temp.CloseT = info.Close;
                            temp.DealPrice = info.DealPrice;

                            decimal[] LossEarn = myFunction.LookUpTick(Convert.ToDecimal(temp.Close), args.LossTick, args.EarnTick, args.ProfitLoss);
                            var profit = myFunction.LProfitCal(args, temp.Close, info, myFunction.VidsDumpSlash(Day), LossEarn, args.InCondition, args.ProfitLoss, item.PreMax);
                            temp.Status = profit[0];
                            temp.Profit = profit[1];
                            total += Convert.ToDouble(temp.Profit);

                            temp.yOpen = yinfo.Open;
                            temp.yHigh = yinfo.High;
                            temp.yLow = yinfo.Low;
                            temp.yClose = yinfo.Close;
                            temp.yDealprice = yinfo.DealPrice;
                            if (myFunction.LookUpDown(Convert.ToDecimal(yyinfo.Close))[0] == Convert.ToDecimal(yinfo.Close))
                                temp.RedLight = "Yes";
                            else
                                temp.RedLight = "No";

                            temp.HighVolume = item.HighVolume;
                            temp.highPercent = item.HighPercent;
                            temp.BuySell = item.BuySell;

                            if (ckcb_displayDealpriceAvg.Checked)
                                dealpriceTotal += Int64.Parse(temp.yDealprice, NumberStyles.AllowThousands);

                            if (OrderC == Second.Count)
                            {
                                temp.Average = (total / Second.Count).ToString("F3");
                                if (args.DisplayDealpriceAvg)
                                    temp.AvgDealPrice = (dealpriceTotal / Second.Count).ToString();
                            }
                            else
                            {
                                temp.Average = "*";
                                if (args.DisplayDealpriceAvg)
                                    temp.AvgDealPrice = "*";
                            }
                        }
                        else
                        {
                            var info = db.Listeds.Where(p => p.Date == myFunction.VidsDumpSlash(Day) && p.Id == item.Id).FirstOrDefault();
                            var yinfo = db.Listeds.Where(p => p.Date == myFunction.GetYesterday(Day) && p.Id == item.Id).FirstOrDefault();
                            temp.Date = info.Date;
                            temp.Type = info.Type;
                            temp.Id = info.Id;
                            temp.Name = info.Name;
                            temp.Close = info.Close;
                            temp.Open = info.Open;
                            temp.High = info.High;
                            temp.Low = info.Low;
                            temp.TurnoverRate = info.TurnoverRate;
                            temp.OpenT = info.Open;
                            temp.HighT = info.High;
                            temp.LowT = info.Low;
                            temp.CloseT = info.Close;
                            temp.DealPrice = info.DealPrice;
                            temp.yClose = yinfo.Close;
                            temp.HighVolume = item.HighVolume;
                            temp.highPercent = item.HighPercent;
                            temp.BuySell = item.BuySell;

                            if (args.DisplayDealpriceAvg)
                            {
                                dealpriceTotal += Int64.Parse(temp.DealPrice, NumberStyles.AllowThousands);

                                if (OrderC == Second.Count)
                                    temp.AvgDealPrice = (dealpriceTotal / Second.Count).ToString();
                                else
                                    temp.AvgDealPrice = "*";
                            }
                        }
                        temp.Order = OrderC.ToString();
                    }
                    else if (item.Type == "櫃")
                    {

                        if (IsPick == false)
                        {
                            var info = db.Otcs.Where(p => p.Date == myFunction.GetTomorrow(Day) && p.Id == item.Id).FirstOrDefault();
                            var yinfo = db.Otcs.Where(p => p.Date == myFunction.VidsDumpSlash(Day) && p.Id == item.Id).FirstOrDefault();
                            var yyinfo = db.Otcs.Where(p => p.Date == myFunction.GetYesterday(Day) && p.Id == item.Id).FirstOrDefault();
                            temp.Date = myFunction.VidsDumpSlash(Day);
                            temp.Type = info.Type;
                            temp.Id = info.Id;
                            temp.Name = info.Name;
                            temp.Close = item.Close;
                            temp.Open = item.Open;
                            temp.High = item.High;
                            temp.Low = item.Low;
                            temp.TurnoverRate = item.TurnoverRate;
                            temp.OpenT = info.Open;
                            temp.HighT = info.High;
                            temp.LowT = info.Low;
                            temp.CloseT = info.Close;
                            temp.DealPrice = info.DealPrice;
                            decimal[] LossEarn = myFunction.LookUpTick(Convert.ToDecimal(temp.Close), args.LossTick, args.EarnTick, args.ProfitLoss);
                            var profit = myFunction.OProfitCal(args, temp.Close, info, myFunction.VidsDumpSlash(Day), LossEarn, args.InCondition, args.ProfitLoss, item.PreMax);
                            temp.Status = profit[0];
                            temp.Profit = profit[1];
                            total += Convert.ToDouble(temp.Profit);

                            temp.yOpen = yinfo.Open;
                            temp.yHigh = yinfo.High;
                            temp.yLow = yinfo.Low;
                            temp.yClose = yinfo.Close;
                            temp.yDealprice = yinfo.DealPrice;
                            if (myFunction.LookUpDown(Convert.ToDecimal(yyinfo.Close))[0] == Convert.ToDecimal(yinfo.Close))
                                temp.RedLight = "Yes";
                            else
                                temp.RedLight = "No";
                            temp.HighVolume = item.HighVolume;
                            temp.highPercent = item.HighPercent;
                            temp.BuySell = item.BuySell;

                            if (args.DisplayDealpriceAvg)
                                dealpriceTotal += Int64.Parse(temp.yDealprice, NumberStyles.AllowThousands);

                            if (OrderC == Second.Count)
                            {
                                temp.Average = (total / Second.Count).ToString("F3");
                                if (args.DisplayDealpriceAvg)
                                    temp.AvgDealPrice = (dealpriceTotal / Second.Count).ToString();
                            }
                            else
                            {
                                temp.Average = "*";
                                if (args.DisplayDealpriceAvg)
                                    temp.AvgDealPrice = "*";
                            }
                        }
                        else
                        {
                            var info = db.Otcs.Where(p => p.Date == myFunction.VidsDumpSlash(Day) && p.Id == item.Id).FirstOrDefault();
                            var yinfo = db.Otcs.Where(p => p.Date == myFunction.GetYesterday(Day) && p.Id == item.Id).FirstOrDefault();
                            temp.Date = info.Date;
                            temp.Type = info.Type;
                            temp.Id = info.Id;
                            temp.Name = info.Name;
                            temp.Close = info.Close;
                            temp.Open = info.Open;
                            temp.High = info.High;
                            temp.Low = info.Low;
                            temp.TurnoverRate = info.TurnoverRate;
                            temp.OpenT = info.Open;
                            temp.HighT = info.High;
                            temp.LowT = info.Low;
                            temp.CloseT = info.Close;
                            temp.DealPrice = info.DealPrice;
                            temp.yClose = yinfo.Close;
                            temp.HighVolume = item.HighVolume;
                            temp.highPercent = item.HighPercent;
                            temp.BuySell = item.BuySell;

                            if (args.DisplayDealpriceAvg)
                            {
                                dealpriceTotal += Int64.Parse(temp.DealPrice, NumberStyles.AllowThousands);

                                if (OrderC == Second.Count)
                                    temp.AvgDealPrice = (dealpriceTotal / Second.Count).ToString();
                                else
                                    temp.AvgDealPrice = "*";
                            }
                        }
                        temp.Order = OrderC.ToString();
                    }

                    S1FinalResult.Add(temp);
                    OrderC++;
                }
                catch (Exception)
                { }
            }
            // Add empty row on datagridview
            S1FinalResult.Add(new Model.MS1.Result());
        }
        /// <summary>
        /// 策略二
        /// </summary>
        /// <param name="args"></param>
        /// <param name="Day"></param>
        private void S2(Args args, string Day)
        {
            // 單次回測所有前高比對日期
            args.DaysOneRun = myFunction.GetEachTestDates(Day, args.totalTestDays);
            string[] OneRunDates = args.DaysOneRun.ToArray();

            // 待測日周轉前X
            var data = (
                    from c in db.Listeds
                    where c.Date == myFunction.VidsDumpSlash(Day) && c.TurnoverRate != "N" && c.TurnoverRate != null
                    select new { c.Id, c.Type, c.Name, c.TurnoverRate, c.Close, c.High, c.Open, c.Low, c.UpDown, c.DealPrice }
                ).Union
                (
                    from o in db.Otcs
                    where o.Date == myFunction.VidsDumpSlash(Day) && o.TurnoverRate != "N" && o.TurnoverRate != null
                    select new { o.Id, o.Type, o.Name, o.TurnoverRate, o.Close, o.High, o.Open, o.Low, o.UpDown, o.DealPrice }
                ).OrderByDescending(m => Convert.ToDouble(m.TurnoverRate)).Take(Convert.ToInt32(args.s2turnovertValue)).ToList();


            int count = 1;
            foreach (var item in data)
            {
                try
                {
                    Model.MS1.S2Result temp = new Model.MS1.S2Result();
                    decimal high = Convert.ToDecimal(item.High);
                    decimal close = Convert.ToDecimal(item.Close);
                    decimal open = Convert.ToDecimal(item.Open);
                    object Max = new object();
                    string BreakStone = null;
                    string Status = null;
                    string Profit = null;
                    string K = null;
                    decimal? linePercent;
                    if (high > close && open != high)
                    {

                        if (item.Type == "市")
                        {
                            Max = db.Listeds.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date)).Max(p => Convert.ToDouble(p.High));
                            if (args.s1HighType)
                                Max = db.Listeds.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date)).Max(p => Convert.ToDouble(p.Close));
                        }
                        else if (item.Type == "櫃")
                        {
                            Max = db.Otcs.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date)).Max(p => Convert.ToDouble(p.High));
                            if (args.s1HighType)
                                Max = db.Otcs.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date)).Max(p => Convert.ToDouble(p.Close));
                        }

                        if (item.Type == "市")
                        {

                            if (IsPick == false)
                            {
                                var info = db.Listeds.Where(p => p.Date == myFunction.GetTomorrow(Day) && p.Id == item.Id).FirstOrDefault();
                                var yinfo = db.Listeds.Where(p => p.Date == myFunction.VidsDumpSlash(Day) && p.Id == item.Id).FirstOrDefault();
                                var yyinfo = db.Listeds.Where(p => p.Date == myFunction.GetYesterday(Day) && p.Id == item.Id).FirstOrDefault();

                                decimal[] LossEarn = myFunction.LookUpTick(close, args.LossTick, args.EarnTick, args.ProfitLoss);
                                var profit = myFunction.LProfitCal(args, close.ToString(), info, myFunction.VidsDumpSlash(Day), LossEarn, args.InCondition, args.ProfitLoss, "0");
                                Status = profit[0];
                                Profit = profit[1];
                            }
                        }
                        else if (item.Type == "櫃")
                        {
                            if (IsPick == false)
                            {
                                var info = db.Otcs.Where(p => p.Date == myFunction.GetTomorrow(Day) && p.Id == item.Id).FirstOrDefault();
                                var yinfo = db.Otcs.Where(p => p.Date == myFunction.VidsDumpSlash(Day) && p.Id == item.Id).FirstOrDefault();
                                var yyinfo = db.Otcs.Where(p => p.Date == myFunction.GetYesterday(Day) && p.Id == item.Id).FirstOrDefault();

                                decimal[] LossEarn = myFunction.LookUpTick(close, args.LossTick, args.EarnTick, args.ProfitLoss);
                                var profit = myFunction.OProfitCal(args, close.ToString(), info, myFunction.VidsDumpSlash(Day), LossEarn, args.InCondition, args.ProfitLoss, "0");
                                Status = profit[0];
                                Profit = profit[1];
                            }
                        }


                        if (Convert.ToDecimal(Max) > high)
                        {
                            BreakStone = "否";
                        }
                        else if (Convert.ToDecimal(Max) < high)
                        {
                            BreakStone = "是";
                        }
                        else
                        {
                            BreakStone = "同等新高";
                        }

                        // red K
                        if (open < close)
                        {
                            K = "紅K";
                            linePercent = Math.Round(100 * (high - close) / close, 2);
                        }
                        // green K
                        else if (open > close)
                        {
                            K = "綠K";
                            linePercent = Math.Round(100 * (high - open) / open, 2);
                        }
                        // white K
                        else
                        {
                            K = "白K";
                            linePercent = Math.Round(100 * (high - open) / open, 2);
                        }
                        temp.Date = myFunction.VidsDumpSlash(Day);
                        temp.Type = item.Type;
                        temp.Id = item.Id;
                        temp.Name = item.Name;
                        temp.Close = item.Close;
                        temp.RedGreen = K;
                        temp.IsHigh = BreakStone;
                        temp.Status = Status;
                        temp.linePercent = linePercent.ToString();
                        temp.Profit = Profit;
                        temp.TurnoverRate = item.TurnoverRate;
                        temp.Order = count.ToString();

                        S2FinalResult.Add(temp);
                        count++;
                        if (count == Convert.ToInt16(args.pickQuantity) + 1)
                            break;

                    }
                }
                catch (Exception)
                { }
            }
            // Add empty row on datagridview
            S2FinalResult.Add(new Model.MS1.S2Result());
        }
        private void S3(Args args, string Day)
        {
            // 單次回測所有前高比對日期
            args.DaysOneRun = myFunction.GetEachTestDates(Day, args.totalTestDays);
            string[] OneRunDates = args.DaysOneRun.ToArray();

            // 待測日周轉前80
            var data = (
                    from c in db.Listeds
                    where c.Date == myFunction.VidsDumpSlash(Day) && c.TurnoverRate != "N" && c.TurnoverRate != null
                    select new { c.Id, c.Type, c.TurnoverRate, c.Close, c.High, c.Open, c.Low, c.UpDown, c.DealPrice }
                ).Union
                (
                    from o in db.Otcs
                    where o.Date == myFunction.VidsDumpSlash(Day) && o.TurnoverRate != "N" && o.TurnoverRate != null
                    select new { o.Id, o.Type, o.TurnoverRate, o.Close, o.High, o.Open, o.Low, o.UpDown, o.DealPrice }
                ).OrderByDescending(m => Convert.ToDouble(m.TurnoverRate)).Take(Convert.ToInt32(args.s3turnovertValue)).ToList();

            List<Model.MS1.S3Second> S3Second = new List<Model.MS1.S3Second>();
            int counter = 0;

            // High
            foreach (var item in data)
            {
                Model.MS1.S3Second Info = new Model.MS1.S3Second();
                object Max = new object();
                try
                {
                    if (item.Type == "市")
                    {
                        Max = db.Listeds.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date)).Max(p => Convert.ToDouble(p.High));
                        if (args.s1HighType)
                            Max = db.Listeds.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date)).Max(p => Convert.ToDouble(p.Close));
                    }
                    else if (item.Type == "櫃")
                    {
                        Max = db.Otcs.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date)).Max(p => Convert.ToDouble(p.High));
                        if (args.s1HighType)
                            Max = db.Otcs.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date)).Max(p => Convert.ToDouble(p.Close));
                    }

                    // 前高
                    double HighT = Convert.ToDouble(item.High);
                    //if (args.s1HighType)
                    //    HighT = Convert.ToDouble(item.Close);

                    double highPercent = 0;

                    if (HighT > (double)Max)
                    {
                        highPercent = (((double)Max - HighT) / HighT) * 100;

                        // 前高數量
                        int count = 0;
                        if (item.Type == "市")
                            count = db.Listeds.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date) && Convert.ToDouble(p.High) > HighT).Count();
                        else if (item.Type == "櫃")
                            count = db.Otcs.Where(p => p.Id == item.Id && OneRunDates.Contains(p.Date) && Convert.ToDouble(p.High) > HighT).Count();

                        // 買賣超
                        string BuySell = string.Empty;
                        if (item.Type == "市")
                        {
                            BuySell = db.ListedBuySells.Where(p => p.Id == item.Id && p.Date == myFunction.VidsDumpSlash(Day)).FirstOrDefault().MBuySell;

                        }
                        else if (item.Type == "櫃")
                        {
                            BuySell = db.OTCBuySells.Where(p => p.Id == item.Id && p.Date == myFunction.VidsDumpSlash(Day)).FirstOrDefault().MBuySell;
                        }

                        Info.Id = item.Id;
                        Info.Type = item.Type;
                        Info.Close = item.Close;
                        Info.Open = item.Open;
                        Info.High = item.High;
                        Info.Low = item.Low;
                        Info.TurnoverRate = item.TurnoverRate;
                        Info.PreMax = Max.ToString();
                        Info.HighVolume = count.ToString();
                        Info.HighPercent = highPercent.ToString("F3");
                        Info.BuySell = BuySell;
                        S3Second.Add(Info);
                        counter++;
                    }
                }
                catch (Exception)
                { }

                if (counter == Convert.ToInt32(args.pickQuantity))
                {
                    break;
                }
            }
            // 結果
            int OrderC = 1;
            double total = 0;

            foreach (var item in S3Second)
            {
                Model.MS1.S3Result temp = new Model.MS1.S3Result();
                try
                {
                    if (item.Type == "市")
                    {

                        if (IsPick == false)
                        {
                            var info = db.Listeds.Where(p => p.Date == myFunction.GetTomorrow(Day) && p.Id == item.Id).FirstOrDefault();
                            var yinfo = db.Listeds.Where(p => p.Date == myFunction.VidsDumpSlash(Day) && p.Id == item.Id).FirstOrDefault();
                            var yyinfo = db.Listeds.Where(p => p.Date == myFunction.GetYesterday(Day) && p.Id == item.Id).FirstOrDefault();
                            temp.Date = myFunction.VidsDumpSlash(Day);
                            temp.Type = info.Type;
                            temp.Id = info.Id;
                            temp.Name = info.Name;
                            temp.Close = item.Close;
                            temp.Open = item.Open;
                            temp.High = item.High;
                            temp.Low = item.Low;
                            temp.TurnoverRate = item.TurnoverRate;
                            temp.OpenT = info.Open;
                            temp.HighT = info.High;
                            temp.LowT = info.Low;
                            temp.CloseT = info.Close;
                            temp.DealPrice = info.DealPrice;

                            decimal[] LossEarn = myFunction.LookUpTick(Convert.ToDecimal(temp.Close), args.LossTick, args.EarnTick, args.ProfitLoss);
                            var profit = myFunction.LProfitCal(args, temp.Close, info, myFunction.VidsDumpSlash(Day), LossEarn, args.InCondition, args.ProfitLoss, item.PreMax);
                            temp.Status = profit[0];
                            temp.Profit = profit[1];
                            total += Convert.ToDouble(temp.Profit);
                            if (OrderC == S3Second.Count)
                                temp.Average = (total / S3Second.Count).ToString("F3");
                            else
                                temp.Average = "*";

                            temp.yOpen = yinfo.Open;
                            temp.yHigh = yinfo.High;
                            temp.yLow = yinfo.Low;
                            temp.yClose = yinfo.Close;
                            temp.yDealprice = yinfo.DealPrice;
                            if (myFunction.LookUpDown(Convert.ToDecimal(yyinfo.Close))[0] == Convert.ToDecimal(yinfo.Close))
                                temp.RedLight = "Yes";
                            else
                                temp.RedLight = "No";

                            temp.HighVolume = item.HighVolume;
                            temp.highPercent = item.HighPercent;
                            temp.BuySell = item.BuySell;

                        }
                        else
                        {
                            var info = db.Listeds.Where(p => p.Date == myFunction.VidsDumpSlash(Day) && p.Id == item.Id).FirstOrDefault();
                            var yinfo = db.Listeds.Where(p => p.Date == myFunction.GetYesterday(Day) && p.Id == item.Id).FirstOrDefault();
                            temp.Date = info.Date;
                            temp.Type = info.Type;
                            temp.Id = info.Id;
                            temp.Name = info.Name;
                            temp.Close = info.Close;
                            temp.Open = info.Open;
                            temp.High = info.High;
                            temp.Low = info.Low;
                            temp.TurnoverRate = info.TurnoverRate;
                            temp.OpenT = info.Open;
                            temp.HighT = info.High;
                            temp.LowT = info.Low;
                            temp.CloseT = info.Close;
                            temp.DealPrice = info.DealPrice;
                            temp.yClose = yinfo.Close;
                            temp.HighVolume = item.HighVolume;
                            temp.highPercent = item.HighPercent;
                            temp.BuySell = item.BuySell;
                        }
                        temp.Order = OrderC.ToString();
                    }
                    else if (item.Type == "櫃")
                    {

                        if (IsPick == false)
                        {
                            var info = db.Otcs.Where(p => p.Date == myFunction.GetTomorrow(Day) && p.Id == item.Id).FirstOrDefault();
                            var yinfo = db.Otcs.Where(p => p.Date == myFunction.VidsDumpSlash(Day) && p.Id == item.Id).FirstOrDefault();
                            var yyinfo = db.Otcs.Where(p => p.Date == myFunction.GetYesterday(Day) && p.Id == item.Id).FirstOrDefault();
                            temp.Date = myFunction.VidsDumpSlash(Day);
                            temp.Type = info.Type;
                            temp.Id = info.Id;
                            temp.Name = info.Name;
                            temp.Close = item.Close;
                            temp.Open = item.Open;
                            temp.High = item.High;
                            temp.Low = item.Low;
                            temp.TurnoverRate = item.TurnoverRate;
                            temp.OpenT = info.Open;
                            temp.HighT = info.High;
                            temp.LowT = info.Low;
                            temp.CloseT = info.Close;
                            temp.DealPrice = info.DealPrice;
                            decimal[] LossEarn = myFunction.LookUpTick(Convert.ToDecimal(temp.Close), args.LossTick, args.EarnTick, args.ProfitLoss);
                            var profit = myFunction.OProfitCal(args, temp.Close, info, myFunction.VidsDumpSlash(Day), LossEarn, args.InCondition, args.ProfitLoss, item.PreMax);
                            temp.Status = profit[0];
                            temp.Profit = profit[1];
                            total += Convert.ToDouble(temp.Profit);

                            if (OrderC == S3Second.Count)
                                temp.Average = (total / S3Second.Count).ToString("F3");
                            else
                                temp.Average = "*";

                            temp.yOpen = yinfo.Open;
                            temp.yHigh = yinfo.High;
                            temp.yLow = yinfo.Low;
                            temp.yClose = yinfo.Close;
                            temp.yDealprice = yinfo.DealPrice;
                            if (myFunction.LookUpDown(Convert.ToDecimal(yyinfo.Close))[0] == Convert.ToDecimal(yinfo.Close))
                                temp.RedLight = "Yes";
                            else
                                temp.RedLight = "No";
                            temp.HighVolume = item.HighVolume;
                            temp.highPercent = item.HighPercent;
                            temp.BuySell = item.BuySell;
                        }
                        else
                        {
                            var info = db.Otcs.Where(p => p.Date == myFunction.VidsDumpSlash(Day) && p.Id == item.Id).FirstOrDefault();
                            var yinfo = db.Otcs.Where(p => p.Date == myFunction.GetYesterday(Day) && p.Id == item.Id).FirstOrDefault();
                            temp.Date = info.Date;
                            temp.Type = info.Type;
                            temp.Id = info.Id;
                            temp.Name = info.Name;
                            temp.Close = info.Close;
                            temp.Open = info.Open;
                            temp.High = info.High;
                            temp.Low = info.Low;
                            temp.TurnoverRate = info.TurnoverRate;
                            temp.OpenT = info.Open;
                            temp.HighT = info.High;
                            temp.LowT = info.Low;
                            temp.CloseT = info.Close;
                            temp.DealPrice = info.DealPrice;
                            temp.yClose = yinfo.Close;
                            temp.HighVolume = item.HighVolume;
                            temp.highPercent = item.HighPercent;
                            temp.BuySell = item.BuySell;
                        }
                        temp.Order = OrderC.ToString();
                    }

                    S3FinalResult.Add(temp);
                    OrderC++;
                }
                catch (Exception)
                { }
            }

            // Add empty row on datagridview
            S3FinalResult.Add(new Model.MS1.S3Result());
        }
        /// <summary>
        /// 策略三
        /// </summary>
        /// <param name="args"></param>
        /// <param name="Day"></param>
        /// <summary>
        /// 初始化公用變數
        /// </summary>
        private void InitialArgs(Args args)
        {
            // Save data
            if (rdb_notsave.Checked)
            {
                S1FinalResult.Clear();
                S2FinalResult.Clear();
                S3FinalResult.Clear();
                OutputTable.Clear();
                this.Invoke((MethodInvoker)delegate ()
                {
                    dgv_result.DataSource = null;
                });
            }

            args.TurnoverDic = new Dictionary<string, string>();

            args.startDay = dp_start.Text.Trim();
            args.endDay = dp_end.Text.Trim();
            args.pickQuantity = ud_pickquantity.Value.ToString();
            args.averageDays = ud_avgDays.Value.ToString();
            args.totalTestDays = ud_testDays.Value.ToString();
            args.ClosePrice = UpDown_closePrice.Value.ToString();
            args.close1 = txt_c1.Text.Trim();
            args.close2 = txt_c2.Text.Trim();
            args.Discount = Convert.ToDecimal(txt_discount.Text.Trim());
            args.LossTick = Convert.ToInt32(ud_loss.Value.ToString());
            args.EarnTick = Convert.ToInt32(ud_earn.Value.ToString());
            args.BacktestDates = myFunction.GetAllTestDate(args.startDay, args.endDay);
            args.PickDate = dp_pickDate.Value.ToString("yyyy/MM/dd");

            // 是否當沖獲利計算
            if (rdb_proDaytradeNo.Checked)
                args.DayTrade = false;
            else
                args.DayTrade = true;

            // 做多或做空
            if (rdb_s1ProfitLong.Checked)
                args.ProfitLoss = false;
            else
                args.ProfitLoss = true;

            // 進場價格tick
            if (rdb_InUnder.Checked || rdb_InUpper.Checked)
                args.InTick = Convert.ToInt32(ud_InTick.Value.ToString());
            // 進場價格條件
            if (rdb_InOpen.Checked)
                args.InCondition = 0;
            else if (rdb_InUnder.Checked)
                args.InCondition = 1;
            else if (rdb_InUpper.Checked)
                args.InCondition = 2;

            args.lossProfitValue = new List<double>
            {
                Convert.ToDouble(txt_aloss.Text.Trim()),
                Convert.ToDouble(txt_aprofit.Text.Trim()),
                Convert.ToDouble(txt_bloss.Text.Trim()),
                Convert.ToDouble(txt_bprofit.Text.Trim()),
            };

            if (rdb_ultimate.Checked)
                args.closeCondition = 0;
            else if (rdb_bigger.Checked)
                args.closeCondition = 1;
            else if (rdb_smaller.Checked)
                args.closeCondition = 2;
            else if (rdb_between.Checked)
                args.closeCondition = 3;
        }

        /// <summary>
        /// Sl參數初始化
        /// </summary>
        /// <param name="args"></param>
        public void S1Initial(Args args)
        {
            args.s1tPrice = ud_tPrice.Value.ToString();
            args.s1VibValue = txt_vibValue.Text.Trim();

            if (ckcb_s1TurnoverTop.Checked)
                args.TurnoverDic.Add("Top", ud_s1TurnoverTop.Value.ToString());
            if (ckcb_s1TurnoverBigger.Checked)
                args.TurnoverDic.Add("Big", ud_s1TurnoverBigger.Value.ToString());
            else if (ckcb_s1TurnoverSmaller.Checked)
                args.TurnoverDic.Add("Small", ud_s1TurnoverSmaller.Value.ToString());

            if (rdb_highReal.Checked)
                args.s1HighType = true;
            else if (rdb_highVirtual.Checked)
                args.s1HighType = false;

            if (ckcb_s1FlUp.Checked || ckcb_S1UpredK.Checked)
                args.s1UpDown = "+";
            else if (ckcb_s1FlDown.Checked)
                args.s1UpDown = "-";
            else
                args.s1UpDown = "None";

            if (ckcb_highStopLoss.Checked)
                args.s1HighStopLoss = true;
            else
                args.s1HighStopLoss = false;

            if (ckcb_highVolume.Checked)
                args.highVolume = ud_highVolume.Value.ToString();

            if (rdb_THigh.Checked)
                args.THighClose = true;
            else
                args.THighClose = false;

            if (ckcb_notHighDis.Checked)
                args.NotHighDisValue = txt_notHighDisValue.Text.Trim();

            if (ckcb_displayDealpriceAvg.Checked)
                args.DisplayDealpriceAvg = true;
            else
                args.DisplayDealpriceAvg = false;
        }
        /// <summary>
        /// S2參數初始化
        /// </summary>
        /// <param name="args"></param>
        public void S2Initial(Args args)
        {
            if (rdb_S2Turnoverrate.Checked)
                args.s2turnovertValue = ud_S2Turnoverrate.Value.ToString();

            if (rdb_S2topLineTrue.Checked)
                args.s2virtualLine = true;
            else
                args.s2virtualLine = false;
        }
        /// <summary>
        /// S3參數初始化
        /// </summary>
        /// <param name="args"></param>
        public void S3Initial(Args args)
        {
            if (rdb_S3Turnoverrate.Checked)
                args.s3turnovertValue = ud_S3Turnoverrate.Value.ToString();
        }
        /// <summary>
        /// 防呆
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private bool FoolProof(Args args)
        {
            if (!dataReady)
            {
                MessageBox.Show("資料爬取中，請稍後再試...", "提醒");
                return false;
            }
            if (!IsPick)
            {
                if (cb_Strategy.SelectedIndex == 0)
                {
                    if (!ckcb_redK.Checked || !ckcb_S1UpredK.Checked)
                    {
                        if (!ckcb_s1FlUp.Checked)
                        {
                            if (!ckcb_S1UpredK.Checked)
                            {
                                MessageBox.Show("漲跌條件若不選擇紅K，請至少選擇 漲 或 跌 !", "提醒");
                                return false;
                            }
                        }
                    }
                }
                if (DateTime.Compare(DateTime.Parse(args.startDay), DateTime.Parse(args.endDay)) > 0)
                {
                    MessageBox.Show("開始時間不得大於結束時間。", "提醒");
                    return false;
                }
                if (DateTime.Compare(DateTime.Parse(args.startDay), DateTime.Parse("2015-05-31")) <= 0 || DateTime.Compare(DateTime.Parse(args.endDay), DateTime.Parse("2015-05-31")) <= 0)
                {
                    MessageBox.Show("不提供2015/05/31以前的歷史資料。", "提醒");
                    return false;
                }
                if (DateTime.Compare(DateTime.Parse(args.endDay).AddDays(1), DateTime.Parse(DateTime.Now.ToShortDateString())) == 0)
                {
                    if (Convert.ToInt32(DateTime.Now.ToString("HH")) < 18)
                    {
                        MessageBox.Show("當日資料尚未載入，請於晚間六點後重啟程式載入資料。", "提醒");
                        return false;
                    }
                }
                else if (DateTime.Compare(DateTime.Parse(args.endDay), DateTime.Parse(DateTime.Now.ToShortDateString())) >= 0)
                {
                    MessageBox.Show("資料無法超前部屬。", "提醒");
                    return false;
                }
            }
            else
            {
                if (cb_Strategy.SelectedIndex != 0)
                {
                    MessageBox.Show("當前不支援該策略選股。", "警告");
                    return false;
                }

                int versus = DateTime.Compare(DateTime.Parse(args.PickDate), DateTime.Parse(DateTime.Now.ToShortDateString()));
                if (versus > 0)
                {
                    MessageBox.Show("資料無法超前部屬。", "提醒");
                    return false;
                }
                else if (versus == 0)
                {
                    if (Convert.ToInt32(DateTime.Now.ToString("HH")) < 18)
                    {
                        MessageBox.Show("當日資料尚未載入，請於晚間六點後重啟程式載入資料。", "提醒");
                        return false;
                    }
                }
            }

            return true;
        }
        /// <summary>
        /// 標籤提示
        /// </summary>
        private void TipMessage()
        {
            Random random = new Random();
            double lucky = Math.Round(random.NextDouble() + random.Next(-3, 8), 2);
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ForeColor = Color.Blue;
            toolTip1.BackColor = Color.Gray;
            toolTip1.AutoPopDelay = 5000;
            toolTip1.ToolTipTitle = "知識小學堂";

            //SetToolTip：定義控制項會跳出提示的文字
            toolTip1.SetToolTip(uiRadioButtonGroup7, "((收-開)/收)*100");
            toolTip1.SetToolTip(rdb_highVirtual, "新高為最高價為主");
            toolTip1.SetToolTip(rdb_highReal, "新高以收盤價為主");
            toolTip1.SetToolTip(btn_pick, $"本次選股獲利 {lucky}%");
        }
        /// <summary>
        /// 取得資料
        /// </summary>
        private void ParseData()
        {
            string crawlDays = txt_crawlDays.Text.Trim();
            List<string> All = myFunction.GetEachTestDates(DateTime.Now.AddDays(1).ToString("yyyy/MM/dd"), crawlDays);
            if (Convert.ToInt32(DateTime.Now.ToString("HH")) < 18)
            {
                All = myFunction.GetEachTestDates(DateTime.Now.ToString("yyyy/MM/dd"), crawlDays);
            }
            foreach (var Date in All)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    lb_status.Text = Date;
                    lb_status.ForeColor = Color.DarkRed;
                });
                
                dataClaw(Date);
            }
            this.Invoke((MethodInvoker)delegate ()
            {
                dataReady = true;
                lb_status.Text = "資料爬取完成";
                lb_status.ForeColor = Color.DarkGreen;
            });
        }
        /// <summary>
        /// 資料爬取
        /// </summary>
        /// <param name="Date"></param>
        private void dataClaw(string Date)
        {
            var A = db.Listeds.Where(p => p.Date == Date).FirstOrDefault();
            if (A == null)
                parseData.Excuted(Date, "市");

            var B = db.Otcs.Where(p => p.Date == Date).FirstOrDefault();
            if (B == null)
                parseData.Excuted(Date, "櫃");

            var C = db.ListedAlerts.Where(p => p.Date == Date).FirstOrDefault();
            if (C == null)
                parseData.DayTradeExcuted(Date, "市");

            var D = db.OTCAlerts.Where(p => p.Date == Date).FirstOrDefault();
            if (D == null)
                parseData.DayTradeExcuted(Date, "櫃");

            var E = db.ListedBuySells.Where(p => p.Date == Date).FirstOrDefault();
            if (E == null)
                parseData.BuySellExcuted(Date, "市");

            var F = db.OTCBuySells.Where(p => p.Date == Date).FirstOrDefault();
            if (F == null)
                parseData.BuySellExcuted(Date, "櫃");
        }

        /// <summary>
        /// 載入初始化控制項
        /// </summary>
        private void IniController()
        {
            try
            {
                #region 公用變數
                ckcb_daytrade.Checked = bool.Parse(SettingConfig.getitemvalue("ckcb_daytrade"));
                rdb_ultimate.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_ultimate"));
                rdb_bigger.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_bigger"));
                rdb_smaller.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_smaller"));
                UpDown_closePrice.Value = int.Parse(SettingConfig.getitemvalue("UpDown_closePrice"));
                rdb_between.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_between"));
                txt_c1.Text = SettingConfig.getitemvalue("txt_c1");
                txt_c2.Text = SettingConfig.getitemvalue("txt_c2");
                ud_pickquantity.Value = int.Parse(SettingConfig.getitemvalue("ud_pickquantity"));
                ud_avgDays.Value = int.Parse(SettingConfig.getitemvalue("ud_avgDays"));
                ud_testDays.Value = int.Parse(SettingConfig.getitemvalue("ud_testDays"));
                ckcb_parse.Checked = bool.Parse(SettingConfig.getitemvalue("ckcb_parse"));
                #endregion

                #region 獲利計算模組
                rdb_proDaytradeYes.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_proDaytradeYes"));
                rdb_proDaytradeNo.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_proDaytradeNo"));
                rdb_s1ProfitShort.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_s1ProfitShort"));
                rdb_s1ProfitLong.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_s1ProfitLong"));
                rdb_InOpen.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_InOpen"));
                rdb_InUnder.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_InUnder"));
                rdb_InUpper.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_InUpper"));
                ud_InTick.Value = int.Parse(SettingConfig.getitemvalue("ud_InTick"));
                ud_loss.Value = int.Parse(SettingConfig.getitemvalue("ud_loss"));
                ud_earn.Value = int.Parse(SettingConfig.getitemvalue("ud_earn"));
                txt_discount.Text = SettingConfig.getitemvalue("txt_discount");
                #endregion

                #region 策略一
                ckcb_s1TurnoverTop.Checked = bool.Parse(SettingConfig.getitemvalue("ckcb_s1TurnoverTop"));
                ckcb_s1TurnoverBigger.Checked = bool.Parse(SettingConfig.getitemvalue("ckcb_s1TurnoverBigger"));
                ckcb_s1TurnoverSmaller.Checked = bool.Parse(SettingConfig.getitemvalue("ckcb_s1TurnoverSmaller"));
                ud_s1TurnoverTop.Value = int.Parse(SettingConfig.getitemvalue("ud_s1TurnoverTop"));
                ud_s1TurnoverBigger.Value = int.Parse(SettingConfig.getitemvalue("ud_s1TurnoverBigger"));
                ud_s1TurnoverSmaller.Value = int.Parse(SettingConfig.getitemvalue("ud_s1TurnoverSmaller"));
                ckcb_s1FlUp.Checked = bool.Parse(SettingConfig.getitemvalue("ckcb_s1FlUp"));
                ckcb_s1FlDown.Checked = bool.Parse(SettingConfig.getitemvalue("ckcb_s1FlDown"));
                ckcb_redK.Checked = bool.Parse(SettingConfig.getitemvalue("ckcb_redK"));
                ckcb_S1UpredK.Checked = bool.Parse(SettingConfig.getitemvalue("ckcb_S1UpredK"));
                rdb_s1MajorBuy.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_s1MajorBuy"));
                rdb_s1MajorSell.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_s1MajorSell"));
                rdb_s1MajorNone.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_s1MajorNone"));
                rdb_THigh.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_THigh"));
                rdb_TClose.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_TClose"));
                rdb_s1HighYes.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_s1HighYes"));
                rdb_s1HighNo.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_s1HighNo"));
                rdb_s1HighNone.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_s1HighNone"));
                rdb_highVirtual.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_highVirtual"));
                rdb_highReal.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_highReal"));
                #endregion

                #region 策略一擴充條件
                ckcb_highStopLoss.Checked = bool.Parse(SettingConfig.getitemvalue("ckcb_highStopLoss"));
                ckcb_tPrice.Checked = bool.Parse(SettingConfig.getitemvalue("ckcb_tPrice"));
                ud_tPrice.Value = int.Parse(SettingConfig.getitemvalue("ud_tPrice"));
                ckcb_highVolume.Checked = bool.Parse(SettingConfig.getitemvalue("ckcb_highVolume"));
                ud_highVolume.Value = int.Parse(SettingConfig.getitemvalue("ud_highVolume"));
                ckcb_notHighDis.Checked = bool.Parse(SettingConfig.getitemvalue("ckcb_notHighDis"));
                txt_notHighDisValue.Text = SettingConfig.getitemvalue("txt_notHighDisValue");
                ckcb_dealpriceOrder.Checked = bool.Parse(SettingConfig.getitemvalue("ckcb_dealpriceOrder"));
                ckcb_displayDealpriceAvg.Checked = bool.Parse(SettingConfig.getitemvalue("ckcb_displayDealpriceAvg"));
                rdb_max.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_max"));
                rdb_notMax.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_notMax"));
                rdb_noneMax.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_noneMax"));
                rdb_vibBig.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_vibBig"));
                rdb_vibSmall.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_vibSmall"));
                rdb_vidNone.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_vidNone"));
                txt_vibValue.Text = SettingConfig.getitemvalue("txt_vibValue");
                #endregion

                #region 策略二
                rdb_S2Turnoverrate.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_S2Turnoverrate"));
                ud_S2Turnoverrate.Value = int.Parse(SettingConfig.getitemvalue("ud_S2Turnoverrate"));
                rdb_S2topLineTrue.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_S2topLineTrue"));
                rdb_S2topLineFalse.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_S2topLineFalse"));
                #endregion

                #region 策略三
                rdb_S3Turnoverrate.Checked = bool.Parse(SettingConfig.getitemvalue("rdb_S3Turnoverrate"));
                ud_S3Turnoverrate.Value = int.Parse(SettingConfig.getitemvalue("ud_S3Turnoverrate"));
                #endregion
            }
            catch (Exception) { }
        }
        #endregion

        #region 暫時用不著
        public string AvgCal(string StockId, List<string> TotalavgDays, bool OTC)
        {
            double result = 0;
            List<double> Each = new List<double>();
            // new way = 一次搜尋當股全部日期 抓 成交金額 => 加起來平均
            foreach (var Day in TotalavgDays)
            {
                string Command = $"SELECT DealPrice FROM Listed WHERE Date='{Day}' AND Id='{StockId}'";
                if (OTC)
                {
                    Command = $"SELECT DealPrice FROM OTC WHERE Date='{Day}' AND Id='{StockId}'";
                }
                DataTable searchTable = SQlite.GetDataTable(FilePath.DB_saveDir, Command);
                foreach (DataRow item in searchTable.Rows)
                {
                    string price = (string)item["DealPrice"];
                    Each.Add(Convert.ToDouble(price.Replace(",", "")));
                }
            }
            if (Each.Count == TotalavgDays.Count)
            {
                result = Convert.ToDouble(Math.Round(Each.Average()));
            }

            return String.Format("{0:N0}", result);
            //return result;
        }
        #endregion

        #region 窗體自適應
        private Size m_szInit;
        private Dictionary<Control, Rectangle> m_dicSize = new Dictionary<Control, Rectangle>();
        protected override void OnLoad(EventArgs e)
        {
            m_szInit = this.Size;//get initial size
            this.GetInitSize(this);
            base.OnLoad(e);
        }

        private void GetInitSize(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                m_dicSize.Add(c, new Rectangle(c.Location, c.Size));
                this.GetInitSize(c);
            }
        }
        protected override void OnResize(EventArgs e)
        {
            //Calculate size propotion between present and initial
            float fx = (float)this.Width / m_szInit.Width;
            float fy = (float)this.Height / m_szInit.Height;
            foreach (var v in m_dicSize)
            {
                v.Key.Left = (int)(v.Value.Left * fx);
                v.Key.Top = (int)(v.Value.Top * fy);
                v.Key.Width = (int)(v.Value.Width * fx);
                v.Key.Height = (int)(v.Value.Height * fy);
            }
            base.OnResize(e);
        }

        #endregion

        private void 開發測試ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteAndReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DeleteReloadForm deleteReloadRForm = new DeleteReloadForm();
            deleteReloadRForm.Show();
        }
    }
}
