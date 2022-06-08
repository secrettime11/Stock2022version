using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class OrderForm : Form
    {
        MyFunction myFunction = new MyFunction();
        public OrderForm(List<Model.MS1.OrderInit> inits)
        {
            InitializeComponent();
            cmb_BuySell.SelectedIndex = 1;
            cmb_inCondition.SelectedIndex = 0;
            cmb_lossCondition.SelectedIndex = 0;
            cmb_earnCondition.SelectedIndex = 0;
            cmb_cleanCondition.SelectedIndex = 0;

            cmb_inType.SelectedIndex = 1;
            cmb_lossType.SelectedIndex = 1;
            cmb_earnType.SelectedIndex = 1;
            cmb_cleanType.SelectedIndex = 1;
            dgv_data.DataSource = myFunction.OrderInitToDGV(inits);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void dgv_data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal total = 0;
            if (dgv_data.CurrentCell.ColumnIndex == 3)
            {
                decimal close = Convert.ToDecimal(dgv_data.Rows[dgv_data.CurrentRow.Index].Cells[2].Value);
                decimal qty = Convert.ToDecimal(dgv_data.Rows[dgv_data.CurrentRow.Index].Cells[3].Value);
                dgv_data.Rows[dgv_data.CurrentRow.Index].Cells[4].Value = (qty * close).ToString();

                foreach (DataGridViewRow row in dgv_data.Rows)
                {
                    if (!string.IsNullOrEmpty(row.Cells[4].Value.ToString()))
                    {
                        total += Convert.ToDecimal(row.Cells[4].Value.ToString());
                    }
                }
                lbl_total.Text = $"下單價格總和 : {total}";
            }

        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            ExcelWriter writer = new ExcelWriter();

            string Path = Application.StartupPath + @"\Excel\Order";
            if (!Directory.Exists(Path))
                Directory.CreateDirectory(Path);

            List<Model.MS1.S1SmartOrder> OrderData = new List<Model.MS1.S1SmartOrder>();
            Console.WriteLine(dgv_data.Rows.Count.ToString());
            // -1 => 最後一行為空
            for (int rows = 0; rows < dgv_data.Rows.Count; rows++)
            {
                Model.MS1.S1SmartOrder data = new Model.MS1.S1SmartOrder();
                decimal price = Convert.ToDecimal(dgv_data.Rows[rows].Cells[2].Value.ToString());
                var lossEarn = myFunction.LookUpDown(price);

                /*進場*/
                data.in_Id = dgv_data.Rows[rows].Cells[0].Value.ToString();
                data.in_Name = dgv_data.Rows[rows].Cells[1].Value.ToString();
                data.in_BuySell = cmb_BuySell.SelectedIndex;

                if (cmb_inType.SelectedIndex == 0)
                    data.in_Price = dgv_data.Rows[rows].Cells[2].Value.ToString();
                else
                {
                    if (rdb_inMax.Checked)
                    {
                        data.in_Price = myFunction.LookUpDown(price)[0].ToString();
                    }
                    else if (rdb_inMin.Checked)
                    {
                        data.in_Price = myFunction.LookUpDown(price)[1].ToString();
                    }
                    else
                    {
                        string tick = txt_inTickVal.Text.Trim();
                        bool positive = true;
                        if (tick.Contains("-"))
                        {
                            tick = tick.Remove(0, 1);
                            positive = false;
                        }
                        data.in_Price = myFunction.GetTick(price, int.Parse(tick), positive).ToString();
                    }
                }
                data.in_Qty = dgv_data.Rows[rows].Cells[3].Value.ToString();
                data.in_Condition = cmb_inCondition.SelectedIndex;
                data.in_Type = cmb_inType.SelectedIndex;
                /*MIT*/
                data.MIT = 0;
                data.mit_BuySell = "0";
                data.mit_TriggerPrice = "0";
                data.mit_MarketPrice = "0";
                /*出清(停損)*/
                if (ckb_loss.Checked)
                {
                    data.Loss = 1;
                    data.loss_Condition = cmb_lossCondition.SelectedIndex;
                    // %停損
                    if (rdb_lossPercent.Checked)
                    {
                        data.loss_Percent = 1;
                        data.loss_Percent_value = txt_lossPerVal.Text.Trim();

                        data.loss_TriggerPrice = 0;
                        data.loss_TriggerPrice_value = "";
                    }
                    // tick停損
                    else if (rdb_lossTick.Checked)
                    {
                        data.loss_TriggerPrice = 1;
                        if (rdb_lossMax.Checked)
                        {
                            data.loss_TriggerPrice_value = myFunction.GetTick(lossEarn[0], int.Parse(txt_lossTickVal.Text.Trim()), false).ToString();
                        }
                        else
                        {
                            data.loss_TriggerPrice_value = myFunction.GetTick(lossEarn[1], int.Parse(txt_lossTickVal.Text.Trim()), true).ToString();
                        }

                        data.loss_Percent = 0;
                        data.loss_Percent_value = "";
                    }

                    // 出清
                    if (cmb_lossType.SelectedIndex == 0)
                    {
                        data.loss_MarketPrice = 1;
                        data.loss_DefinePrice = 0;
                        data.loss_DefinePrice_value = "";
                    }
                    else
                    {
                        data.loss_MarketPrice = 0;
                        data.loss_DefinePrice = 1;
                        if (rdb_lossMax.Checked)
                        {
                            data.loss_DefinePrice_value = myFunction.GetTick(lossEarn[0], int.Parse(txt_loss_c_t.Text.Trim()), false).ToString();
                        }
                        else
                        {
                            data.loss_DefinePrice_value = myFunction.GetTick(lossEarn[1], int.Parse(txt_loss_c_t.Text.Trim()), true).ToString();
                        }
                    }
                }
                /*出清(停利)*/
                if (ckb_loss.Checked)
                {
                    data.Earn = 1;
                    data.earn_Condition = cmb_earnCondition.SelectedIndex;
                    
                    
                    // %停利
                    if (rdb_earnPercent.Checked)
                    {
                        data.Earn_Percent = 1;
                        data.Earn_Percent_value = txt_earnPerVal.Text.Trim();

                        data.earn_TriggerPrice = 0;
                        data.earn_TriggerPrice_value = "";
                    }
                    // tick停利
                    else if (rdb_earnTick.Checked)
                    {
                        data.earn_TriggerPrice = 1;
                        if (rdb_earnMin.Checked)
                        {
                            data.earn_TriggerPrice_value = myFunction.GetTick(lossEarn[1], int.Parse(txt_earnTickVal.Text.Trim()), true).ToString();
                        }
                        else
                        {
                            data.earn_TriggerPrice_value = myFunction.GetTick(lossEarn[0], int.Parse(txt_earnTickVal.Text.Trim()), false).ToString();
                        }

                        data.Earn_Percent = 0;
                        data.Earn_Percent_value = "";
                    }

                    // 出清
                    if (cmb_earnType.SelectedIndex == 0)
                    {
                        data.earn_MarketPrice = 1;
                        data.earn_DefinePrice = 0;
                        data.earn_DefinePrice_value = "";
                    }
                    else
                    {
                        data.earn_MarketPrice = 0;
                        data.earn_DefinePrice = 1;
                        if (rdb_earnMin.Checked)
                        {
                            data.earn_DefinePrice_value = myFunction.GetTick(lossEarn[1], int.Parse(txt_loss_c_t.Text.Trim()), true).ToString();
                        }
                        else
                        {
                            data.earn_DefinePrice_value = myFunction.GetTick(lossEarn[0], int.Parse(txt_loss_c_t.Text.Trim()), false).ToString();
                        }
                    }
                }
                /*時間出清*/
                if (ckb_timeClear.Checked)
                {
                    data.Clear = 1;
                    data.c_Time = cmb_Hr.Text.Trim() + cmb_Min.Text.Trim();
                    data.c_Condition = cmb_cleanCondition.SelectedIndex;
                    if (cmb_cleanType.SelectedIndex == 0)
                    {
                        data.c_DefinePrice = 0;
                        data.c_MarketPrice = 1;
                        data.c_DefinePrice_value = "";
                    }
                    else
                    {
                        data.c_DefinePrice = 1;
                        data.c_MarketPrice = 0;
                        if (ckb_c_loss.Checked)
                        {
                            data.c_DefinePrice_value = myFunction.GetTick(lossEarn[0], int.Parse(txt_loss_c_t.Text.Trim()), false).ToString();
                        }
                        else
                        {
                            data.c_DefinePrice_value = myFunction.GetTick(lossEarn[1], int.Parse(txt_loss_c_t.Text.Trim()), true).ToString();
                        }
                    }
                }
                else
                {
                    data.Clear = 0;
                }
                data.FinalSet = 0;
                OrderData.Add(data);
            }

            if (dgv_data.Rows.Count < 1)
            {
                MessageBox.Show("沒有資料", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (File.Exists(Application.StartupPath + @"\Excel\Order\Order" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx"))
            {
                Console.WriteLine(Application.StartupPath + @"\Excel\Order\Order" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx");
                if (MessageBox.Show("檔名已存在，是否覆蓋", "文件已存在", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    writer.OrderToExcel(DateTime.Now.ToString("yyyyMMdd"), OrderData);
                else
                    return;
            }
            else
                writer.OrderToExcel(DateTime.Now.ToString("yyyyMMdd"), OrderData);
        }

        private void btn_openExe_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\OrderTool\OrderSystem.exe";
            //string path = @"D:\478646資料檔\Desktop\Dev\OrderSystem\OrderSystem\bin\Debug\OrderSystem.exe";
            Process[] processes = Process.GetProcessesByName("OrderSystem");
            if (processes.Length == 0)
            {
                Process.Start(path);
            }
        }
    }
}
