using DataModels;
using HtmlAgilityPack;
using Stock.CS;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public class MyFunction
    {
        /// <summary>
        /// Total backtest dates
        /// </summary>
        /// <param name="startDate">2020-01-01</param>
        /// <param name="endDate">2020-01-31</param>
        /// <returns>yyyy/MM/dd</returns>
        public List<string> GetAllTestDate(string startDate, string endDate)
        {
            string[] start = startDate.Split('-');
            string[] end = endDate.Split('-');
            List<string> DatesResult = new List<string>();
            for (DateTime dt = new DateTime(Convert.ToInt32(start[0]), Convert.ToInt32(start[1]), Convert.ToInt32(start[2])); dt <= new DateTime(Convert.ToInt32(end[0]), Convert.ToInt32(end[1]), Convert.ToInt32(end[2])); dt = dt.AddDays(1))
            {
                // Get day of week
                string date = Convert.ToDateTime(dt.ToString("yyyy-MM-dd")).DayOfWeek.ToString();

                if (date != "Saturday" && date != "Sunday")
                {
                    if (!Market.CloseDay.Contains(dt.ToString("yyyyMMdd")))
                        DatesResult.Add(dt.ToString("yyyy/MM/dd"));
                }
                else if (Market.OpenWeekend.Contains(dt.ToString("yyyyMMdd"))) DatesResult.Add(dt.ToString("yyyy/MM/dd"));
            }

            return DatesResult;
        }

        /// <summary>
        /// Date - Backtest days => All days
        /// </summary>
        /// <param name="date">2020/08/29</param>
        /// <param name="minusDays">Minus days</param>
        /// <returns>20200829</returns>
        public List<string> GetEachTestDates(string date, string minusDays)
        {
            List<string> AllDays = new List<string>();
            try
            {
                for (int i = 0; i < Convert.ToInt32(minusDays); i++)
                {
                    date = DateTime.Parse(date).AddDays(-1).ToString("yyyy/MM/dd");
                    string week = Convert.ToDateTime(date).DayOfWeek.ToString();
                    string DateNoSlash = VidsDumpSlash(date);
                    string[] data = date.Split('/');

                    if (week != "Saturday" && week != "Sunday")
                    {
                        if (!Market.CloseDay.Contains(DateNoSlash))
                            AllDays.Add(DateNoSlash);
                    }
                    // Market open on weekend => Add
                    else if (Market.OpenWeekend.Contains(DateNoSlash))
                    {
                        AllDays.Add(DateNoSlash);
                    }
                }
            }
            catch (Exception)
            {
            }

            return AllDays;
        }

        /// <summary>
        /// Check data table exist
        /// </summary>
        public void CheckDataTableExist()
        {
            SQliteDb SQlite = new SQliteDb();
            Dictionary<string, List<string>> TableList = new Dictionary<string, List<string>>
            {
                { "Capital",Header.Capital_header},
                { "Listed",Header.Listed_header},
                { "ListedAlert",Header.ListedAlert_header},
                { "ListedBuySell",Header.ListedBuySell_header},
                { "OTC",Header.OTC_header},
                { "OTCAlert",Header.OTCAlert_header},
                { "OTCBuySell",Header.OTCBuySell_header}
            };
            foreach (var item in TableList)
            {
                if (!SQlite.CheckDatatable(item.Key))
                {
                    SQlite.CreateTable(FilePath.DB_saveDir, SQlite.CreateTableString(item.Key, item.Value));
                }
            }
        }

        /// <summary>
        /// Solar to vids
        /// </summary>
        /// <param name="date">108/08/08</param>
        /// <param name="Slash">return with slash 2019/08/08</param>
        /// <returns></returns>
        public string SolarToVids(string date, bool Slash)
        {

            string[] dateSplit = date.Trim().Split('/');
            string year = (Convert.ToInt32(dateSplit[0]) + 1911).ToString();
            string returnDate = "";
            if (Slash)
                returnDate = $"{year}/{dateSplit[1]}/{dateSplit[2]}";
            else
                returnDate = $"{year}{dateSplit[1]}{dateSplit[2]}";

            return returnDate;
        }

        /// <summary>
        /// Vids to solar
        /// </summary>
        /// <param name="date">Date(2020/08/22)</param>
        /// <param name="Slash">Slash</param>
        /// <returns></returns>
        public string VidsToSolar(string date, bool Slash)
        {
            string[] dateSplit = date.Trim().Split('/');
            string year = (Convert.ToInt32(dateSplit[0]) - 1911).ToString();
            string returnDate = string.Empty;

            if (Slash)
                returnDate = $"{year}/{dateSplit[1]}/{dateSplit[2]}";
            else
                returnDate = $"{year}{dateSplit[1]}{dateSplit[2]}";

            return returnDate;
        }

        /// <summary>
        /// Vids add slash
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public string VidsAddSlash(string date)
        {
            Console.WriteLine(date.Length);
            string result = String.Empty;
            if (date.Length == 8)
                result = date.Substring(0, 4) + "/" + date.Substring(4, 2) + "/" + date.Substring(6, 2);
            return result;
        }

        /// <summary>
        /// Solar to vids with dash
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public string SolarToVidsDash(string date)
        {
            string[] dateSplit = date.Trim().Split('/');
            string year = (Convert.ToInt32(dateSplit[0]) + 1911).ToString();
            string returnDate = "";
            returnDate = $"{year}-{dateSplit[1]}-{dateSplit[2]}";
            return returnDate;
        }

        /// <summary>
        /// Vids dump slash
        /// </summary>
        /// <param name="date">2020/01/01</param>
        /// <returns>20200101</returns>
        public string VidsDumpSlash(string date)
        {
            return Convert.ToDateTime(date).ToString("yyyyMMdd");
        }
        
        /// <summary>
        /// Get tomorrow date
        /// </summary>
        /// <param name="date">2020/01/01</param>
        /// <returns>2020/01/02</returns>
        public string GetTomorrow(string date)
        {
            DateTime Tomorrow = Convert.ToDateTime(date).AddDays(1);

            while (true)
            {
                string week = Tomorrow.DayOfWeek.ToString();

                if (Market.OpenWeekend.Contains(Tomorrow.ToString("yyyyMMdd")))
                    break;
                else
                {
                    if (week != "Saturday" && week != "Sunday" && !Market.CloseDay.Contains(Tomorrow.ToString("yyyyMMdd")))
                        break;
                    else
                        Tomorrow = Tomorrow.AddDays(1);
                }
            }
            return Tomorrow.ToString("yyyyMMdd");
        }
        /// <summary>
        /// Get yesterday
        /// </summary>
        /// <param name="date">2020/01/01</param>
        /// <returns></returns>
        public string GetYesterday(string date)
        {
            DateTime Yesterday = Convert.ToDateTime(date).AddDays(-1);
            Yesterday = FindYesterday(Yesterday);
            return Yesterday.ToString("yyyyMMdd");
        }
        /// <summary>
        /// 取上次回測日期
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public DateTime GetLastBacktestDay(string date)
        {
            DateTime Yesterday = Convert.ToDateTime(date).AddDays(-1);
            Yesterday = FindYesterday(Yesterday);

            if (DateTime.Now.Hour <= 18)
            {
                Yesterday = Yesterday.AddDays(-1);
                Yesterday = FindYesterday(Yesterday);
            }

            return DateTime.Parse(Yesterday.ToString("yyyy-MM-dd"));
        }
        /// <summary>
        /// 取昨日函數
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns></returns>
        public DateTime FindYesterday(DateTime date) 
        {
            while (true)
            {
                string week = date.DayOfWeek.ToString();

                if (Market.OpenWeekend.Contains(date.ToString("yyyyMMdd")))
                    break;
                else
                {
                    if (week != "Saturday" && week != "Sunday" && !Market.CloseDay.Contains(date.ToString("yyyyMMdd")))
                        break;
                    else
                        date = date.AddDays(-1);
                }
            }
            return date;
        }

        public DateTime GetPickDay(string date)
        {
            DateTime Today = Convert.ToDateTime(date);
            while (true)
            {
                string week = Today.DayOfWeek.ToString();
                if (Market.OpenWeekend.Contains(Today.ToString("yyyyMMdd")))
                    break;
                else
                {
                    if (week != "Saturday" && week != "Sunday" && !Market.CloseDay.Contains(Today.ToString("yyyyMMdd")))
                        break;
                    else
                        Today = Today.AddDays(1);
                }
            }
            if (DateTime.Now.Hour <= 18)
                Today = Today.AddDays(-1);

            return DateTime.Parse(Today.ToString("yyyy-MM-dd"));
        }
        /// <summary>
        /// Find table node in html
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public HtmlNode FindTable(HtmlNode node)
        {
            if (node.ParentNode.Name.Equals("table", StringComparison.OrdinalIgnoreCase))
            {
                return node.ParentNode;
            }
            else
            {
                return FindTable(node.ParentNode);
            }
        }

        /// <summary>
        /// 取得前幾日
        /// </summary>
        /// <param name="date">2020/12/09</param>
        /// <param name="avgDay">取得總共前幾日</param>
        /// <returns></returns>
        public List<string> GetAveragePriceDate(string date, int avgDay)
        {
            List<string> AllDays = new List<string>();
            try
            {
                int dayCount = 0;
                while (dayCount < avgDay)
                {
                    string week = Convert.ToDateTime(date).DayOfWeek.ToString();
                    if (!Market.CloseDay.Contains(VidsDumpSlash(date)))
                    {
                        if (Market.OpenWeekend.Contains(VidsDumpSlash(date)))
                        {
                            AllDays.Add(VidsDumpSlash(date));
                            dayCount++;
                            date = DateTime.Parse(date).AddDays(-1).ToString("yyyy/MM/dd");
                        }
                        else if (week != "Saturday" && week != "Sunday")
                        {
                            AllDays.Add(VidsDumpSlash(date));
                            dayCount++;
                            date = DateTime.Parse(date).AddDays(-1).ToString("yyyy/MM/dd");
                        }
                        else
                        {
                            date = DateTime.Parse(date).AddDays(-1).ToString("yyyy/MM/dd");
                        }
                    }
                    else
                    {
                        date = DateTime.Parse(date).AddDays(-1).ToString("yyyy/MM/dd");
                    }
                }
            }
            catch (Exception)
            {
            }

            return AllDays;
        }

        /// <summary>
        /// Result list to datagridview
        /// </summary>
        /// <param name="resultList"></param>
        /// <param name="PickStock"></param>
        /// <returns></returns>
        public DataTable S1ListToDGV(List<Model.MS1.Result> result, bool IsPick, bool DisplayDealprice)
        {
            DataTable dataTable = new DataTable();
            if (result.Count > 0)
            {
                // Add column
                if (!IsPick)
                {
                    if (DisplayDealprice)
                        foreach (var item in Header.Output_headerAvg)
                            dataTable.Columns.Add(item);
                    else
                        foreach (var item in Header.Output_header)
                            dataTable.Columns.Add(item);
                }
                else
                {
                    if (DisplayDealprice)
                        foreach (var item in Header.OutputPick_headerAvg)
                            dataTable.Columns.Add(item);
                    else
                        foreach (var item in Header.OutputPick_header)
                            dataTable.Columns.Add(item);
                }
                int rowC = 0;
                foreach (var item in result)
                {
                    dataTable.Rows.Add();

                    if (!IsPick)
                    {
                        dataTable.Rows[rowC][0] = item.Date;
                        dataTable.Rows[rowC][1] = item.Type;
                        dataTable.Rows[rowC][2] = item.Id;
                        dataTable.Rows[rowC][3] = item.Name;
                        dataTable.Rows[rowC][4] = item.Close;
                        dataTable.Rows[rowC][5] = item.TurnoverRate;
                        dataTable.Rows[rowC][6] = item.OpenT;
                        dataTable.Rows[rowC][7] = item.HighT;
                        dataTable.Rows[rowC][8] = item.LowT;
                        dataTable.Rows[rowC][9] = item.CloseT;
                        dataTable.Rows[rowC][10] = item.DealPrice;
                        dataTable.Rows[rowC][11] = item.Status;
                        dataTable.Rows[rowC][12] = item.Profit;
                        dataTable.Rows[rowC][13] = item.Average;
                        dataTable.Rows[rowC][14] = item.Order;
                        dataTable.Rows[rowC][15] = item.yOpen;
                        dataTable.Rows[rowC][16] = item.yHigh;
                        dataTable.Rows[rowC][17] = item.yLow;
                        dataTable.Rows[rowC][18] = item.yClose;
                        dataTable.Rows[rowC][19] = item.yDealprice;
                        dataTable.Rows[rowC][20] = item.RedLight;
                        dataTable.Rows[rowC][21] = item.HighVolume;
                        dataTable.Rows[rowC][22] = item.highPercent;
                        dataTable.Rows[rowC][23] = item.BuySell;
                        if (DisplayDealprice)
                            dataTable.Rows[rowC][24] = item.AvgDealPrice;
                    }
                    else
                    {
                        dataTable.Rows[rowC][0] = item.Date;
                        dataTable.Rows[rowC][1] = item.Type;
                        dataTable.Rows[rowC][2] = item.Id;
                        dataTable.Rows[rowC][3] = item.Name;
                        dataTable.Rows[rowC][4] = item.Open;
                        dataTable.Rows[rowC][5] = item.High;
                        dataTable.Rows[rowC][6] = item.Low;
                        dataTable.Rows[rowC][7] = item.Close;
                        dataTable.Rows[rowC][8] = item.TurnoverRate;
                        dataTable.Rows[rowC][9] = item.DealPrice;
                        dataTable.Rows[rowC][10] = item.yClose;
                        dataTable.Rows[rowC][11] = item.Order;
                        dataTable.Rows[rowC][12] = item.HighVolume;
                        dataTable.Rows[rowC][13] = item.highPercent;
                        dataTable.Rows[rowC][14] = item.BuySell;
                        if (DisplayDealprice)
                            dataTable.Rows[rowC][15] = item.AvgDealPrice;
                    }

                    rowC++;
                }
            }
            return dataTable;
        }
        /// <summary>
        /// 計算報酬
        /// </summary>
        /// <param name="args"></param>
        /// <param name="close"></param>
        /// <param name="info"></param>
        /// <param name="Day"></param>
        /// <returns></returns>
        public List<string> LCal(Args args, string close, Listed info, string Day)
        {
            List<string> result = new List<string>();
            if (info != null)
            {
                try
                {
                    double High = Convert.ToDouble(info.High);
                    double Low = Convert.ToDouble(info.Low);
                    double YClose = Convert.ToDouble(close);
                    double Open = Convert.ToDouble(info.Open);
                    double Close = Convert.ToDouble(info.Close);
                    string date = $"{Day.Substring(0, 4)}-{Day.Substring(4, 2)}-{Day.Substring(6, 2)}";

                    // 做空
                    if (args.ProfitLoss)
                    {
                        if (DateTime.Compare(DateTime.Parse(date), DateTime.Parse("2015-05-31")) > 0)
                        {
                            // 停損 = 開盤價 -(前一日收盤價 *1.09) / 收盤價 =獲利%數 (盤中高點>=前一日收盤價 *1.09 則視為 停損情況)
                            if (High >= YClose * args.lossProfitValue[0])
                            {
                                result.Add("停損");
                                result.Add((((Open - (YClose * args.lossProfitValue[0])) / Close) * 100).ToString("F3"));
                            }
                            // 停利 = 開盤價 -(前一日收盤價 *0.90) / 收盤價 =獲利%數 (盤中低點<=前一日收盤價 *0.90 則視為 停利情況)
                            else if (Low <= YClose * args.lossProfitValue[1])
                            {
                                result.Add("停利");
                                result.Add((((Open - (YClose * args.lossProfitValue[1])) / Close) * 100).ToString("F3"));
                            }
                            // 一般情況 = (開盤價 -收盤價 )/收盤價 = 獲利%數
                            else
                            {
                                result.Add("一般");
                                result.Add((((Open - Close) / Close) * 100).ToString("F3"));
                            }
                        }
                        else
                        {
                            if (High >= YClose * args.lossProfitValue[2])
                            {
                                result.Add("停損");
                                result.Add((((Open - (YClose * args.lossProfitValue[2])) / Close) * 100).ToString("F3"));
                            }
                            else if (Low <= YClose * args.lossProfitValue[3])
                            {
                                result.Add("停利");
                                result.Add((((Open - (YClose * args.lossProfitValue[3])) / Close) * 100).ToString("F3"));
                            }
                            else
                            {
                                result.Add("一般");
                                result.Add((((Open - Close) / Close) * 100).ToString("F3"));
                            }
                        }
                    }
                    //做多
                    else
                    {
                        if (DateTime.Compare(DateTime.Parse(date), DateTime.Parse("2015-05-31")) > 0)
                        {
                            // 停利 = (前一日收盤價 *1.09) - 開盤價 / 開盤價 =獲利%數 (盤中高點>=前一日收盤價 *1.09 則視為 停利情況)
                            if (High >= YClose * args.lossProfitValue[0])
                            {
                                result.Add("停利");
                                result.Add(((((YClose * args.lossProfitValue[0]) - Open) / Open) * 100).ToString("F3"));
                            }
                            // 停損 = 開盤價 -(前一日收盤價 *0.90) / 開盤價 =獲利%數 (盤中低點<=前一日收盤價 *0.90 則視為 停損情況)
                            else if (Low <= YClose * args.lossProfitValue[1])
                            {
                                result.Add("停損");
                                result.Add(((((Open - (YClose * args.lossProfitValue[1])) / Open) * 100).ToString("F3")));
                            }
                            // 一般情況 = (開盤價 -收盤價 )/ 開盤價 = 獲利%數
                            else
                            {
                                result.Add("一般");
                                result.Add((((Close - Open) / Open) * 100).ToString("F3"));
                            }
                        }
                        else
                        {
                            if (High >= YClose * args.lossProfitValue[2])
                            {
                                result.Add("停利");
                                result.Add(((((YClose * args.lossProfitValue[2]) - Open) / Open) * 100).ToString("F3"));
                            }
                            else if (Low <= YClose * args.lossProfitValue[3])
                            {
                                result.Add("停損");
                                result.Add((((Open - (YClose * args.lossProfitValue[3])) / Open) * 100).ToString("F3"));
                            }
                            else
                            {
                                result.Add("一般");
                                result.Add((((Close - Open) / Open) * 100).ToString("F3"));
                            }
                        }
                    }
                }
                catch (Exception) { }


            }
            return result;
        }
        public List<string> OCal(Args args, string close, OTC info, string Day)
        {
            List<string> result = new List<string>();
            if (info != null)
            {
                try
                {
                    double High = Convert.ToDouble(info.High);
                    double Low = Convert.ToDouble(info.Low);
                    double YClose = Convert.ToDouble(close);
                    double Open = Convert.ToDouble(info.Open);
                    double Close = Convert.ToDouble(info.Close);
                    string date = $"{Day.Substring(0, 4)}-{Day.Substring(4, 2)}-{Day.Substring(6, 2)}";
                    if (args.ProfitLoss)
                    {
                        if (DateTime.Compare(DateTime.Parse(date), DateTime.Parse("2015-05-31")) > 0)
                        {
                            // 停損 = 開盤價 -(前一日收盤價 *1.09) / 收盤價 =獲利%數 (盤中高點>=前一日收盤價 *1.09 則視為 停損情況)
                            if (High >= YClose * args.lossProfitValue[0])
                            {
                                result.Add("停損");
                                result.Add((((Open - (YClose * args.lossProfitValue[0])) / Close) * 100).ToString("F3"));
                            }
                            // 停利 = 開盤價 -(前一日收盤價 *0.90) / 收盤價 =獲利%數 (盤中低點<=前一日收盤價 *0.90 則視為 停利情況)
                            else if (Low <= YClose * args.lossProfitValue[1])
                            {
                                result.Add("停利");
                                result.Add((((Open - (YClose * args.lossProfitValue[1])) / Close) * 100).ToString("F3"));
                            }
                            // 一般情況 = (開盤價 -收盤價 )/收盤價 = 獲利%數
                            else
                            {
                                result.Add("一般");
                                result.Add((((Open - Close) / Close) * 100).ToString("F3"));
                            }
                        }
                        else
                        {
                            if (High >= YClose * args.lossProfitValue[2])
                            {
                                result.Add("停損");
                                result.Add((((Open - (YClose * args.lossProfitValue[2])) / Close) * 100).ToString("F3"));
                            }
                            else if (Low <= YClose * args.lossProfitValue[3])
                            {
                                result.Add("停利");
                                result.Add((((Open - (YClose * args.lossProfitValue[3])) / Close) * 100).ToString("F3"));
                            }
                            else
                            {
                                result.Add("一般");
                                result.Add((((Open - Close) / Close) * 100).ToString("F3"));
                            }
                        }
                    }
                    else
                    {
                        if (DateTime.Compare(DateTime.Parse(date), DateTime.Parse("2015-05-31")) > 0)
                        {
                            // 停利 = (前一日收盤價 *1.09) - 開盤價 / 開盤價 =獲利%數 (盤中高點>=前一日收盤價 *1.09 則視為 停利情況)
                            if (High >= YClose * args.lossProfitValue[0])
                            {
                                result.Add("停利");
                                result.Add(((((YClose * args.lossProfitValue[0]) - Open) / Open) * 100).ToString("F3"));
                            }
                            // 停損 = 開盤價 -(前一日收盤價 *0.90) / 開盤價 =獲利%數 (盤中低點<=前一日收盤價 *0.90 則視為 停損情況)
                            else if (Low <= YClose * args.lossProfitValue[1])
                            {
                                result.Add("停損");
                                result.Add(((((Open - (YClose * args.lossProfitValue[1])) / Open) * 100).ToString("F3")));
                            }
                            // 一般情況 = (開盤價 -收盤價 )/收盤價 = 獲利%數
                            else
                            {
                                result.Add("一般");
                                result.Add((((Close - Open) / Open) * 100).ToString("F3"));
                            }
                        }
                        else
                        {
                            if (High >= YClose * args.lossProfitValue[2])
                            {
                                result.Add("停利");
                                result.Add(((((YClose * args.lossProfitValue[2]) - Open) / Open) * 100).ToString("F3"));
                            }
                            else if (Low <= YClose * args.lossProfitValue[3])
                            {
                                result.Add("停損");
                                result.Add((((Open - (YClose * args.lossProfitValue[3])) / Open) * 100).ToString("F3"));
                            }
                            else
                            {
                                result.Add("一般");
                                result.Add((((Close - Open) / Open) * 100).ToString("F3"));
                            }
                        }
                    }
                }
                catch (Exception) { }
            }
            return result;
        }
        public List<string> LProfitCal(Args args, string yclose, Listed info, string Day, decimal[] LossEarn, int InCondition, bool ProfitLoss, string PreMax)
        {
            List<string> result = new List<string>();
            if (info != null)
            {
                try
                {
                    decimal High = Convert.ToDecimal(info.High);
                    decimal Low = Convert.ToDecimal(info.Low);
                    decimal YClose = Convert.ToDecimal(yclose);
                    decimal Open = Convert.ToDecimal(info.Open);
                    decimal Close = Convert.ToDecimal(info.Close);
                    decimal Max = Convert.ToDecimal(PreMax);
                    string date = $"{Day.Substring(0, 4)}-{Day.Substring(4, 2)}-{Day.Substring(6, 2)}";
                    decimal SUM = 0;
                    decimal per = 0;
                    bool In = true;
                    if (ProfitLoss)
                    {
                        if (InCondition == 1)
                        {
                            decimal InPrice = GetTick(YClose, args.InTick, false);
                            if (InPrice <= High)
                            {
                                if (Open < InPrice)
                                    Open = InPrice;
                            }
                            else
                            {
                                result.Add("未達進場價位");
                                result.Add("0");
                                In = false;
                            }
                        }
                        else if (InCondition == 2)
                        {
                            decimal InPrice = GetTick(YClose, args.InTick, true);
                            if (InPrice <= High)
                            {
                                if (Open < InPrice)
                                    Open = InPrice;
                            }
                            else
                            {
                                result.Add("未達進場價位");
                                result.Add("0");
                                In = false;
                            }
                        }
                    }
                    else
                    {
                        if (InCondition == 1)
                        {
                            decimal InPrice = GetTick(YClose, args.InTick, false);
                            if (InPrice >= Low)
                            {
                                if (Open > InPrice)
                                    Open = InPrice;
                            }
                            else
                            {
                                result.Add("未達進場價位");
                                result.Add("0");
                                In = false;
                            }
                        }
                        else if (InCondition == 2)
                        {
                            decimal InPrice = GetTick(YClose, args.InTick, true);
                            if (InPrice >= Low)
                            {
                                if (Open > InPrice)
                                    Open = InPrice;
                            }
                            else
                            {
                                result.Add("未達進場價位");
                                result.Add("0");
                                In = false;
                            }
                        }
                    }
                    if (In)
                    {
                        // 手續費
                        decimal handfee = (0.001425M * (args.Discount / 10M));
                        // 做空
                        if (args.ProfitLoss)
                        {
                            decimal dis = Open * 1000M * handfee;
                            if (dis < 20)
                                dis = 20;

                            dis = dis + Open * 1000M * 0.0015M;
                            if (DateTime.Compare(DateTime.Parse(date), DateTime.Parse("2015-05-31")) > 0)
                            {
                                // 前高停損
                                if (args.s1HighStopLoss && LookUpDown(YClose)[0] >= Max && High >= Max)
                                {
                                    if (Open >= Max)
                                    {
                                        SUM = Open * 1000 * handfee;
                                        if (SUM < 20)
                                            SUM = 20;
                                        SUM = SUM + dis;
                                        per = (SUM / (Open * 1000)) * 100;
                                        result.Add("前高停損");
                                        result.Add((0 - per).ToString("F3"));
                                    }
                                    else
                                    {
                                        SUM = Max * 1000 * handfee;
                                        if (SUM < 20)
                                            SUM = 20;
                                        SUM = SUM + dis;
                                        per = (SUM / (Max * 1000)) * 100;
                                        result.Add("前高停損");
                                        result.Add(((((Open - Max) / Max) * 100) - per).ToString("F3"));
                                    }
                                }
                                else
                                {
                                    // 停損
                                    if (High >= LossEarn[0])
                                    {

                                        SUM = LossEarn[0] * 1000 * handfee;
                                        if (SUM < 20)
                                            SUM = 20;
                                        SUM = SUM + dis;
                                        per = (SUM / (LossEarn[0] * 1000)) * 100;
                                        result.Add("停損");

                                        result.Add(((((Open - LossEarn[0]) / LossEarn[0]) * 100) - per).ToString("F3"));
                                    }
                                    // 停利
                                    else if (Low <= LossEarn[1])
                                    {
                                        SUM = LossEarn[0] * 1000 * handfee;
                                        if (SUM < 20)
                                            SUM = 20;
                                        SUM = SUM + dis;
                                        per = (SUM / (LossEarn[1] * 1000)) * 100;
                                        result.Add("停利");
                                        result.Add(((((Open - LossEarn[1]) / LossEarn[1]) * 100) - per).ToString("F3"));
                                    }
                                    // 一般情況
                                    else
                                    {
                                        SUM = LossEarn[0] * 1000 * handfee;
                                        if (SUM < 20)
                                            SUM = 20;
                                        SUM = SUM + dis;
                                        per = (SUM / (Close * 1000)) * 100;
                                        result.Add("一般");
                                        result.Add(((((Open - Close) / Close) * 100) - per).ToString("F3"));
                                    }
                                }

                            }
                        }
                        //做多
                        else
                        {
                            decimal dis = Open * 1000M * (0.001425M * (args.Discount / 10M));
                            if (dis < 20)
                                dis = 20;
                            if (DateTime.Compare(DateTime.Parse(date), DateTime.Parse("2015-05-31")) > 0)
                            {
                                // 停利 = (前一日收盤價 *1.09) - 開盤價 / 開盤價 =獲利%數 (盤中高點>=前一日收盤價 *1.09 則視為 停利情況)
                                if (High >= LossEarn[1])
                                {
                                    SUM = LossEarn[1] * 1000 * 0.001425M * (args.Discount / 10M);
                                    if (SUM < 20)
                                        SUM = 20;
                                    SUM = SUM + LossEarn[1] * 1000M * 0.0015M + dis;
                                    per = (SUM / (Open * 1000)) * 100;
                                    result.Add("停利");
                                    result.Add(((((LossEarn[1] - Open) / Open) * 100) - per).ToString("F3"));
                                }
                                // 停損 = 開盤價 -(前一日收盤價 *0.90) / 開盤價 =獲利%數 (盤中低點<=前一日收盤價 *0.90 則視為 停損情況)
                                else if (Low <= LossEarn[0])
                                {
                                    SUM = LossEarn[1] * 1000 * 0.001425M * (args.Discount / 10M);
                                    if (SUM < 20)
                                        SUM = 20;
                                    SUM = SUM + LossEarn[1] * 1000M * 0.0015M + dis;
                                    per = (SUM / (Open * 1000)) * 100;
                                    result.Add("停損");
                                    result.Add((((((LossEarn[0] - Open) / Open) * 100) - per).ToString("F3")));
                                }
                                // 一般情況 = (開盤價 -收盤價 )/ 開盤價 = 獲利%數
                                else
                                {
                                    SUM = LossEarn[1] * 1000 * 0.001425M * (args.Discount / 10M);
                                    if (SUM < 20)
                                        SUM = 20;
                                    SUM = SUM + LossEarn[1] * 1000M * 0.0015M + dis;
                                    per = (SUM / (Open * 1000)) * 100;
                                    result.Add("一般");
                                    result.Add(((((Close - Open) / Open) * 100) - per).ToString("F3"));
                                }
                            }
                        }
                    }
                }
                catch (Exception) { }
            }
            return result;
        }
        public List<string> OProfitCal(Args args, string yclose, OTC info, string Day, decimal[] LossEarn, int InCondition, bool ProfitLoss, string PreMax)
        {
            List<string> result = new List<string>();
            if (info != null)
            {
                try
                {
                    decimal High = Convert.ToDecimal(info.High);
                    decimal Low = Convert.ToDecimal(info.Low);
                    decimal YClose = Convert.ToDecimal(yclose);
                    decimal Open = Convert.ToDecimal(info.Open);
                    decimal Close = Convert.ToDecimal(info.Close);
                    decimal Max = Convert.ToDecimal(PreMax);
                    string date = $"{Day.Substring(0, 4)}-{Day.Substring(4, 2)}-{Day.Substring(6, 2)}";
                    decimal SUM = 0;
                    decimal per = 0;
                    // 進場與否
                    bool In = true;
                    if (ProfitLoss)
                    {
                        if (InCondition == 1)
                        {
                            decimal InPrice = GetTick(YClose, args.InTick, false);
                            if (InPrice <= High)
                            {
                                if (Open < InPrice)
                                    Open = InPrice;
                            }
                            else
                            {
                                result.Add("未達進場價位");
                                result.Add("0");
                                In = false;
                            }
                        }
                        else if (InCondition == 2)
                        {
                            decimal InPrice = GetTick(YClose, args.InTick, true);
                            if (InPrice <= High)
                            {
                                if (Open < InPrice)
                                    Open = InPrice;
                            }
                            else
                            {
                                result.Add("未達進場價位");
                                result.Add("0");
                                In = false;
                            }
                        }
                    }
                    else
                    {
                        if (InCondition == 1)
                        {
                            decimal InPrice = GetTick(YClose, args.InTick, false);
                            if (InPrice >= Low)
                            {
                                if (Open > InPrice)
                                    Open = InPrice;
                            }
                            else
                            {
                                result.Add("未達進場價位");
                                result.Add("0");
                                In = false;
                            }
                        }
                        else if (InCondition == 2)
                        {
                            decimal InPrice = GetTick(YClose, args.InTick, true);
                            if (InPrice >= Low)
                            {
                                if (Open > InPrice)
                                    Open = InPrice;
                            }
                            else
                            {
                                result.Add("未達進場價位");
                                result.Add("0");
                                In = false;
                            }
                        }
                    }
                    if (In)
                    {
                        // 手續費
                        decimal handfee = (0.001425M * (args.Discount / 10M));
                        // 做空
                        if (args.ProfitLoss)
                        {
                            decimal dis = Open * 1000M * handfee;
                            if (dis < 20)
                                dis = 20;
                            dis = dis + Open * 1000M * 0.0015M;
                            if (DateTime.Compare(DateTime.Parse(date), DateTime.Parse("2015-05-31")) > 0)
                            {
                                // 前高停損
                                if (args.s1HighStopLoss && LookUpDown(YClose)[0] >= Max && High >= Max)
                                {
                                    if (Open >= Max)
                                    {
                                        SUM = Open * 1000 * handfee;
                                        if (SUM < 20)
                                            SUM = 20;
                                        SUM = SUM + dis;
                                        per = (SUM / (Open * 1000)) * 100;
                                        result.Add("前高停損");
                                        result.Add((0 - per).ToString("F3"));
                                    }
                                    else
                                    {
                                        SUM = Max * 1000 * handfee;
                                        if (SUM < 20)
                                            SUM = 20;
                                        SUM = SUM + dis;
                                        per = (SUM / (Max * 1000)) * 100;
                                        result.Add("前高停損");
                                        result.Add(((((Open - Max) / Max) * 100) - per).ToString("F3"));
                                    }
                                }
                                else
                                {
                                    // 停損
                                    if (High >= LossEarn[0])
                                    {
                                        SUM = LossEarn[0] * 1000 * handfee;
                                        if (SUM < 20)
                                            SUM = 20;
                                        SUM = SUM + dis;
                                        per = (SUM / (LossEarn[0] * 1000)) * 100;
                                        result.Add("停損");
                                        result.Add(((((Open - LossEarn[0]) / LossEarn[0]) * 100) - per).ToString("F3"));
                                    }
                                    // 停利
                                    else if (Low <= LossEarn[1])
                                    {
                                        SUM = LossEarn[0] * 1000 * handfee;
                                        if (SUM < 20)
                                            SUM = 20;
                                        SUM = SUM + dis;
                                        per = (SUM / (LossEarn[1] * 1000)) * 100;
                                        result.Add("停利");
                                        result.Add(((((Open - LossEarn[1]) / LossEarn[1]) * 100) - per).ToString("F3"));
                                    }
                                    // 一般情況
                                    else
                                    {
                                        SUM = LossEarn[0] * 1000 * handfee;
                                        if (SUM < 20)
                                            SUM = 20;
                                        SUM = SUM + dis;
                                        per = (SUM / (Close * 1000)) * 100;
                                        result.Add("一般");
                                        result.Add(((((Open - Close) / Close) * 100) - per).ToString("F3"));

                                    }
                                }

                            }
                        }
                        //做多
                        else
                        {
                            decimal dis = Open * 1000M * (0.001425M * (args.Discount / 10M));
                            if (dis < 20)
                                dis = 20;
                            if (DateTime.Compare(DateTime.Parse(date), DateTime.Parse("2015-05-31")) > 0)
                            {
                                // 停利 = (前一日收盤價 *1.09) - 開盤價 / 開盤價 =獲利%數 (盤中高點>=前一日收盤價 *1.09 則視為 停利情況)
                                if (High >= LossEarn[1])
                                {
                                    SUM = LossEarn[1] * 1000 * 0.001425M * (args.Discount / 10M);
                                    if (SUM < 20)
                                        SUM = 20;
                                    SUM = SUM + LossEarn[1] * 1000M * 0.0015M + dis;
                                    per = (SUM / (Open * 1000)) * 100;
                                    result.Add("停利");
                                    result.Add(((((LossEarn[1] - Open) / Open) * 100) - per).ToString("F3"));
                                }
                                // 停損 = 開盤價 -(前一日收盤價 *0.90) / 開盤價 =獲利%數 (盤中低點<=前一日收盤價 *0.90 則視為 停損情況)
                                else if (Low <= LossEarn[0])
                                {
                                    SUM = LossEarn[1] * 1000 * 0.001425M * (args.Discount / 10M);
                                    if (SUM < 20)
                                        SUM = 20;
                                    SUM = SUM + LossEarn[1] * 1000M * 0.0015M + dis;
                                    per = (SUM / (Open * 1000)) * 100;
                                    result.Add("停損");
                                    result.Add((((((LossEarn[0] - Open) / Open) * 100) - per).ToString("F3")));
                                }
                                // 一般情況 = (開盤價 -收盤價 )/ 開盤價 = 獲利%數
                                else
                                {
                                    SUM = LossEarn[1] * 1000 * 0.001425M * (args.Discount / 10M);
                                    if (SUM < 20)
                                        SUM = 20;
                                    SUM = SUM + LossEarn[1] * 1000M * 0.0015M + dis;
                                    per = (SUM / (Open * 1000)) * 100;
                                    result.Add("一般");
                                    result.Add(((((Close - Open) / Open) * 100) - per).ToString("F3"));
                                }
                            }
                        }
                    }
                }
                catch (Exception Exception) { }
            }
            return result;
        }
        /// <summary>
        /// 計算漲跌停 [0] = 漲停 [1] = 跌停
        /// </summary>
        /// <param name="Price"></param>
        /// <returns></returns>
        public decimal[] LookUpDown(decimal Price)
        {
            decimal close = Convert.ToDecimal(Price);
            decimal up = close * 1.1M;
            decimal down = close * 0.9M;
            decimal fUp = 0;
            decimal fDown = 0;
            decimal[] result = new decimal[2];
            if (up < 10 && down < 10)
            {
                fUp = ((Math.Floor((Math.Floor(up * 100) * 100))) / 100) / 100;
                fDown = ((Math.Floor((Math.Ceiling(down * 100) * 100))) / 100) / 100;
                result[0] = fUp;
                result[1] = fDown;
            }
            else if (up > 10 && down < 10)
            {
                fUp = ((Math.Floor(((Math.Floor(up / 0.05M) * 0.05M) * 100) * 100)) / 100) / 100;
                fDown = ((Math.Floor((Math.Ceiling(down * 100) * 100))) / 100) / 100;
                result[0] = fUp;
                result[1] = fDown;
            }
            else if (up >= 10 && down >= 10 && up <= 50 && down < 50)
            {
                fUp = ((Math.Floor(((Math.Floor(up / 0.05M) * 0.05M) * 100) * 100)) / 100) / 100;
                fDown = ((Math.Floor(((Math.Ceiling(down / 0.05M) * 0.05M) * 100) * 100)) / 100) / 100;
                result[0] = fUp;
                result[1] = fDown;
            }
            else if (up >= 50 && down >= 50 && up < 100 && down < 100)
            {
                fUp = ((Math.Floor(((Math.Floor(up / 0.1M) * 0.1M) * 100) * 100)) / 100) / 100;
                fDown = ((Math.Floor(((Math.Ceiling(down / 0.1M) * 0.1M) * 100) * 100)) / 100) / 100;
                result[0] = fUp;
                result[1] = fDown;
            }
            else if (up >= 50 && down < 50)
            {
                fUp = ((Math.Floor(((Math.Floor(up / 0.1M) * 0.1M) * 100) * 100)) / 100) / 100;
                fDown = (Math.Floor((Math.Ceiling(down / 0.05M) * 0.05M) * 100)) / 100;
                result[0] = fUp;
                result[1] = fDown;
            }
            else if (up >= 100 && down >= 100 && up < 500 && down < 500)
            {
                fUp = ((Math.Floor(((Math.Floor(up / 0.5M) * 0.5M) * 100) * 100)) / 100) / 100;
                fDown = ((Math.Floor(((Math.Ceiling(down / 0.5M) * 0.5M) * 100) * 100)) / 100) / 100;
                result[0] = fUp;
                result[1] = fDown;
            }
            else if (up >= 100 && down < 100)
            {
                fUp = ((Math.Floor(((Math.Floor(up / 0.5M) * 0.5M) * 100) * 100)) / 100) / 100;
                fDown = ((Math.Floor(((Math.Ceiling(down / 0.1M) * 0.1M) * 100) * 100)) / 100) / 100;
                result[0] = fUp;
                result[1] = fDown;
            }
            else if (up >= 500 && down >= 500 && up < 1000 && down < 1000)
            {
                fUp = ((Math.Floor(((Math.Floor(up / 1.0M) * 1.0M) * 100) * 100)) / 100) / 100;
                fDown = ((Math.Floor(((Math.Ceiling(down / 1.0M) * 1.0M) * 100) * 100)) / 100) / 100;
                result[0] = fUp;
                result[1] = fDown;
            }
            else if (up >= 500 && down < 500)
            {
                fUp = ((Math.Floor(((Math.Floor(up / 1.0M) * 1.0M) * 100) * 100)) / 100) / 100;
                fDown = ((Math.Floor(((Math.Ceiling(down / 0.5M) * 0.5M) * 100) * 100)) / 100) / 100;
                result[0] = fUp;
                result[1] = fDown;
            }
            else if (up >= 1000 && down >= 1000)
            {
                fUp = ((Math.Floor(((Math.Floor(up / 5.0M) * 5.0M) * 100) * 100)) / 100) / 100;
                fDown = ((Math.Floor(((Math.Ceiling(down / 5.0M) * 5.0M) * 100) * 100)) / 100) / 100;
                result[0] = fUp;
                result[1] = fDown;
            }
            else if (up >= 1000 && down < 1000)
            {
                fUp = ((Math.Floor(((Math.Floor(up / 5.0M) * 5.0M) * 100) * 100)) / 100) / 100;
                fDown = ((Math.Floor(((Math.Ceiling(down / 1.0M) * 1.0M) * 100) * 100)) / 100) / 100;
                result[0] = fUp;
                result[1] = fDown;
            }
            return result;
        }
        /// <summary>
        /// Tick停損停利
        /// </summary>
        /// <param name="Price">價格</param>
        /// <param name="LossTick">停損tick</param>
        /// <param name="EarnTick">停利tick</param>
        /// <param name="UpOrDown">做空true做多false</param>
        /// <returns>[0]停損 [1]停利</returns>
        public decimal[] LookUpTick(decimal Price, int LossTick, int EarnTick, bool UpOrDown)
        {
            // 漲停 0 跌停 1
            decimal[] UpDown = LookUpDown(Price);
            decimal[] result = new decimal[2];
            decimal LossResult = 0;
            decimal EarnResult = 0;
            if (UpOrDown)
            {
                LossResult = UpDown[0];
                while (LossTick > 0)
                {
                    if (LossResult <= 10M)
                        LossResult -= 0.01M;
                    else if (LossResult > 10 && LossResult <= 50)
                        LossResult -= 0.05M;
                    else if (LossResult > 50 && LossResult <= 100)
                        LossResult -= 0.1M;
                    else if (LossResult > 100 && LossResult <= 500)
                        LossResult -= 0.5M;
                    else if (LossResult > 500 && LossResult <= 1000)
                        LossResult -= 1.0M;
                    else
                        LossResult -= 5.0M;
                    LossTick--;
                }
                EarnResult = UpDown[1];
                while (EarnTick > 0)
                {
                    if (EarnResult < 10M)
                        EarnResult += 0.01M;
                    else if (EarnResult >= 10M && EarnResult < 50M)
                        EarnResult += 0.05M;
                    else if (EarnResult >= 50M && EarnResult < 100M)
                        EarnResult += 0.1M;
                    else if (EarnResult >= 100M && EarnResult < 500M)
                        EarnResult += 0.5M;
                    else if (EarnResult >= 500M && EarnResult < 1000M)
                        EarnResult += 1.0M;
                    else
                        EarnResult += 5.0M;
                    EarnTick--;
                }
                result[0] = LossResult;
                result[1] = EarnResult;
            }
            else
            {
                EarnResult = UpDown[0];
                while (EarnTick > 0)
                {
                    if (EarnResult < 10)
                        EarnResult -= 0.01M;
                    else if (EarnResult >= 10M && EarnResult < 50M)
                        EarnResult -= 0.05M;
                    else if (EarnResult >= 50M && EarnResult < 100M)
                        EarnResult -= 0.1M;
                    else if (EarnResult >= 100M && EarnResult < 500M)
                        EarnResult -= 0.5M;
                    else if (EarnResult >= 500M && EarnResult < 1000M)
                        EarnResult -= 1.0M;
                    else
                        EarnResult -= 5.0M;
                    EarnTick--;
                }
                LossResult = UpDown[1];
                while (LossTick > 0)
                {
                    if (LossResult <= 10M)
                        LossResult += 0.01M;
                    else if (LossResult > 10M && LossResult <= 50M)
                        LossResult += 0.05M;
                    else if (LossResult > 50M && LossResult < 100M)
                        LossResult += 0.1M;
                    else if (LossResult > 100M && LossResult <= 500M)
                        LossResult += 0.5M;
                    else if (LossResult > 500M && LossResult <= 1000M)
                        LossResult += 1.0M;
                    else
                        LossResult += 5.0M;
                    LossTick--;
                }
                result[0] = LossResult;
                result[1] = EarnResult;
            }
            return result;
        }
        /// <summary>
        /// 回傳tick價位
        /// </summary>
        /// <param name="price">價位</param>
        /// <param name="tick">tick</param>
        /// <param name="plus">+=true -=flase</param>
        /// <returns></returns> 
        public decimal GetTick(decimal price, int tick, bool plus)
        {
            decimal result = price;
            if (!plus)
            {
                while (tick > 0)
                {
                    if (result <= 10M)
                        result -= 0.01M;
                    else if (result > 10M && result <= 50M)
                        result -= 0.05M;
                    else if (result > 50M && result <= 100M)
                        result -= 0.1M;
                    else if (result > 100M && result <= 500M)
                        result -= 0.5M;
                    else if (result > 500M && result <= 1000M)
                    {
                        result -= 1.0M;
                    }
                    else
                        result -= 5.0M;
                    tick--;
                }
            }
            else
            {
                while (tick > 0)
                {
                    if (result < 10M)
                        result += 0.01M;
                    else if (result >= 10M && result < 50M)
                        result += 0.05M;
                    else if (result >= 50M && result < 100M)
                        result += 0.1M;
                    else if (result >= 100M && result < 500M)
                        result += 0.5M;
                    else if (result >= 500M && result < 1000M)
                        result += 1.0M;
                    else
                        result += 5.0M;
                    tick--;
                }
            }
            return result;
        }

        public DataTable S2ListToDGV(List<Model.MS1.S2Result> result)
        {
            DataTable dataTable = new DataTable();
            if (result.Count > 0)
            {

                foreach (var item in Header.S2Output_header)
                    dataTable.Columns.Add(item);

                int rowC = 0;
                foreach (var item in result)
                {
                    dataTable.Rows.Add();

                    dataTable.Rows[rowC][0] = item.Date;
                    dataTable.Rows[rowC][1] = item.Type;
                    dataTable.Rows[rowC][2] = item.Id;
                    dataTable.Rows[rowC][3] = item.Name;
                    dataTable.Rows[rowC][4] = item.Close;
                    dataTable.Rows[rowC][5] = item.RedGreen;
                    dataTable.Rows[rowC][6] = item.IsHigh;
                    dataTable.Rows[rowC][7] = item.Status;
                    dataTable.Rows[rowC][8] = item.linePercent;
                    dataTable.Rows[rowC][9] = item.Profit;
                    dataTable.Rows[rowC][10] = item.TurnoverRate;
                    dataTable.Rows[rowC][11] = item.Order;

                    rowC++;
                }
            }
            return dataTable;
        }
        public DataTable S3ListToDGV(List<Model.MS1.S3Result> result, bool IsPick)
        {
            DataTable dataTable = new DataTable();
            if (result.Count > 0)
            {
                // Add column
                if (!IsPick)
                {
                    foreach (var item in Header.S3Output_header)
                        dataTable.Columns.Add(item);
                }
                else
                {
                    foreach (var item in Header.S3OutputPick_header)
                        dataTable.Columns.Add(item);
                }
                int rowC = 0;
                foreach (var item in result)
                {
                    dataTable.Rows.Add();

                    if (!IsPick)
                    {
                        dataTable.Rows[rowC][0] = item.Date;
                        dataTable.Rows[rowC][1] = item.Type;
                        dataTable.Rows[rowC][2] = item.Id;
                        dataTable.Rows[rowC][3] = item.Name;
                        dataTable.Rows[rowC][4] = item.Close;
                        dataTable.Rows[rowC][5] = item.TurnoverRate;
                        dataTable.Rows[rowC][6] = item.OpenT;
                        dataTable.Rows[rowC][7] = item.HighT;
                        dataTable.Rows[rowC][8] = item.LowT;
                        dataTable.Rows[rowC][9] = item.CloseT;
                        dataTable.Rows[rowC][10] = item.DealPrice;
                        dataTable.Rows[rowC][11] = item.Status;
                        dataTable.Rows[rowC][12] = item.Profit;
                        dataTable.Rows[rowC][13] = item.Average;
                        dataTable.Rows[rowC][14] = item.Order;
                        dataTable.Rows[rowC][15] = item.yOpen;
                        dataTable.Rows[rowC][16] = item.yHigh;
                        dataTable.Rows[rowC][17] = item.yLow;
                        dataTable.Rows[rowC][18] = item.yClose;
                        dataTable.Rows[rowC][19] = item.yDealprice;
                        dataTable.Rows[rowC][20] = item.RedLight;
                        dataTable.Rows[rowC][21] = item.HighVolume;
                        dataTable.Rows[rowC][22] = item.highPercent;
                        dataTable.Rows[rowC][23] = item.BuySell;
                    }
                    else
                    {
                        dataTable.Rows[rowC][0] = item.Date;
                        dataTable.Rows[rowC][1] = item.Type;
                        dataTable.Rows[rowC][2] = item.Id;
                        dataTable.Rows[rowC][3] = item.Name;
                        dataTable.Rows[rowC][4] = item.Open;
                        dataTable.Rows[rowC][5] = item.High;
                        dataTable.Rows[rowC][6] = item.Low;
                        dataTable.Rows[rowC][7] = item.Close;
                        dataTable.Rows[rowC][8] = item.TurnoverRate;
                        dataTable.Rows[rowC][9] = item.DealPrice;
                        dataTable.Rows[rowC][10] = item.yClose;
                        dataTable.Rows[rowC][11] = item.Order;
                        dataTable.Rows[rowC][12] = item.HighVolume;
                        dataTable.Rows[rowC][13] = item.highPercent;
                        dataTable.Rows[rowC][14] = item.BuySell;
                    }

                    rowC++;
                }
            }
            return dataTable;
        }

        public DataTable OrderInitToDGV(List<Model.MS1.OrderInit> result)
        {
            DataTable dataTable = new DataTable();
            if (result.Count > 0)
            {
                foreach (var item in Header.Order_header)
                    dataTable.Columns.Add(item);

                int rowC = 0;
                foreach (var item in result)
                {
                    dataTable.Rows.Add();

                    dataTable.Rows[rowC][0] = item.Id;
                    dataTable.Rows[rowC][1] = item.Name;
                    dataTable.Rows[rowC][2] = item.Price;
                    dataTable.Rows[rowC][3] = "";
                    dataTable.Rows[rowC][4] = "";
                    rowC++;
                }
            }
            return dataTable;
        }
    }
    public class ListedFunction
    {
        MyFunction myFunction = new MyFunction();

        /// <summary>
        /// Read Listed alert data write into SQLite
        /// </summary>
        /// <param name="date">日期</param>
        public bool WriteListedAlertToSQL(string date)
        {
            List<string> Data = new List<string>();
            // 爬取資料
            var AlertIndfo = ParseListedAlert(date);
            if (AlertIndfo != null)
            {
                foreach (var item in AlertIndfo)
                {
                    Data.Add(date + "_" + "市_" + item.Key + "_" + item.Value);
                }

                // 寫入SQLite
                SQliteDb sQlite = new SQliteDb();
                string insertString = "";
                if (sQlite.DataAdd(FilePath.DB_saveDir, "ListedAlert", Header.ListedAlert_header, Data, insertString))
                {
                    Console.WriteLine($"{date} ListedAlert 新增成功!");
                    return true;
                }
            }

            //Stock_Form.Log.Debug($"{date}:上市當沖標的取得失敗!");
            return false;
        }

        /// <summary>
        /// Parse Listed alert data
        /// </summary>
        /// <param name="date">Example : 20200824 </param>
        /// <returns></returns>
        public Dictionary<string, string> ParseListedAlert(string date)
        {
            try
            {
                Dictionary<string, string> Securities = new Dictionary<string, string>();
                HtmlWeb webClient = new HtmlWeb();
                var doc = webClient.Load($"https://www.twse.com.tw/exchangeReport/TWTB4U?response=html&date={date}&selectType=All");
                var table = doc.DocumentNode.SelectSingleNode("/html/body//div[contains(text(),'日沖銷交易標的')]");
                if (table != null)
                {
                    table = myFunction.FindTable(table);

                    var tbody = table.SelectNodes(".//tbody//tr");
                    if (tbody != null)
                    {
                        foreach (var tr in tbody)
                        {
                            List<string> Info = new List<string>();
                            foreach (var td in tr.SelectNodes(".//td"))
                            {
                                Info.Add(td.InnerText.Trim());
                            }
                            // 無法當沖股
                            if (Info[2] == "Y")
                                //  0 => 公司代號 1 => 公司名稱
                                Securities.Add(Info[0], Info[1]);
                        }
                        return Securities;
                    }
                }
            }
            catch (Exception Exception)
            {
                //Stock_Form.Log.Debug($"ParseAllInfo:{Exception.Message}");
            }

            return null;
        }

        /// <summary>
        /// Parse Listed data
        /// </summary>
        /// <param name="date">Example : 20200824 </param>
        /// <returns></returns>
        public Dictionary<string, List<string>> ParseAllInfo(string date, Dictionary<string, string> CapitalDic)
        {
            try
            {
                Dictionary<string, List<string>> Securities = new Dictionary<string, List<string>>();
                HtmlWeb webClient = new HtmlWeb();
                var doc = webClient.Load($"https://www.twse.com.tw/exchangeReport/MI_INDEX?response=html&date={date}&type=ALLBUT0999");
                var table = doc.DocumentNode.SelectSingleNode("/html/body//th[contains(text(),'每日收盤行情')]");
                if (table != null)
                {
                    table = myFunction.FindTable(table);
                    var tbody = table.SelectNodes(".//tbody//tr");
                    foreach (var tr in tbody)
                    {
                        List<string> Info = new List<string>();
                        foreach (var td in tr.SelectNodes(".//td"))
                        {
                            Info.Add(td.InnerText.Trim());
                        }
                        if (CapitalDic.ContainsKey(Info[0]))
                        {
                            // 資本額
                            Info.Add(CapitalDic[Info[0]]);
                            // 周轉率
                            Info.Add(((Math.Floor(Convert.ToDouble(Info[2]) / 1000) / Convert.ToDouble(CapitalDic[Info[0]])) * 1000).ToString("F2"));
                        }
                        else
                        {
                            Info.Add("N");
                            Info.Add("N");
                        }
                        Securities.Add(Info[0], Info);
                    }
                    return Securities;
                }
            }
            catch (Exception Exception)
            {
                //Stock_Form.Log.Debug($"ParseAllInfo:{Exception.Message}");
            }
            return null;
        }

        /// <summary>
        /// Parse Listed major investors buy and sell
        /// </summary>
        /// <param name="date">20200101</param>
        /// <returns></returns>
        public Dictionary<string, string> ParseListedBuySell(string date)
        {
            try
            {
                Dictionary<string, string> Major = new Dictionary<string, string>();
                HtmlWeb webClient = new HtmlWeb();
                var doc = webClient.Load($"https://www.twse.com.tw/fund/T86?response=html&date={date}&selectType=ALLBUT0999");
                var table = doc.DocumentNode.SelectSingleNode("/html/body//div[contains(text(),'三大法人買賣超日報')]");
                if (table != null)
                {
                    table = myFunction.FindTable(table);

                    var tbody = table.SelectNodes(".//tbody//tr");
                    if (tbody != null)
                    {
                        foreach (var tr in tbody)
                        {
                            List<string> Info = new List<string>();
                            foreach (var td in tr.SelectNodes(".//td"))
                            {
                                Info.Add(td.InnerText.Trim());
                            }
                            if (DateTime.Compare(DateTime.Parse(myFunction.VidsToSolar(myFunction.VidsAddSlash(date), true)), DateTime.Parse("106/12/16")) < 0)
                            {
                                //  0 => 公司代號 15 => 公司名稱
                                Major.Add(Info[0], Info[15]);
                            }
                            else
                            {
                                //  0 => 公司代號 18 => 公司名稱
                                Major.Add(Info[0], Info[18]);
                            }
                        }

                        return Major;
                    }
                }
            }
            catch (Exception Exception)
            {
                Console.WriteLine(Exception.Message);
                //Stock_Form.Log.Debug($"ParseListedBuySell:{Exception.Message}");
            }

            return null;
        }

        /// <summary>
        /// Read Listed data and capital data(Calculate turnover) write into SQLite
        /// </summary>
        /// <param name="date">20200810</param>
        public bool WriteListedToSQL(string date, Dictionary<string, string> CapitalDic)
        {
            List<string> Data = new List<string>();

            // 爬取資料
            var ListedInfo = ParseAllInfo(date, CapitalDic);
            if (ListedInfo != null)
            {
                foreach (var item in ListedInfo)
                {
                    //Console.WriteLine($"{item.Key} : {string.Join("/", item.Value)}");
                    Data.Add(date + "_" + "市_" + string.Join("_", item.Value));
                }

                // 寫入SQLite
                SQliteDb sQlite = new SQliteDb();
                string insertString = "";
                if (sQlite.DataAdd(FilePath.DB_saveDir, "Listed", Header.Listed_header, Data, insertString))
                {
                    Console.WriteLine($"{date} Listed 新增成功!");
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// SQLite Read Listed major investors buy sell data write into SQLite
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool WriteListedBuySellToSQL(string date)
        {
            List<string> Data = new List<string>();
            // 爬取資料
            var AlertIndfo = ParseListedBuySell(date);
            if (AlertIndfo != null)
            {
                foreach (var item in AlertIndfo)
                    Data.Add(date + "_" + "市_" + item.Key + "_" + item.Value);

                // 寫入SQLite
                SQliteDb sQlite = new SQliteDb();
                string insertString = "";
                if (sQlite.DataAdd(FilePath.DB_saveDir, "ListedBuySell", Header.ListedBuySell_header, Data, insertString))
                {
                    Console.WriteLine($"{date} ListedBuySell 新增成功!");
                    return true;
                }
            }

            //Stock_Form.Log.Debug($"{date}:上市三大法人買賣超取得失敗!");
            return false;
        }

        /// <summary>
        /// 讀取資本額xls寫入SQLite
        /// </summary>
        public static void WriteCapitalToSQL()
        {
            // Before category
            List<string> RawData = new List<string>();
            List<string> Data = new List<string>();
            string FileName = "";

            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = Application.StartupPath + @"\CapitalData";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    XlsReader xlsReader = new XlsReader();
                    string Filepath = openFile.FileName;
                    FileName = Path.GetFileNameWithoutExtension(Filepath);
                    // Get xls raw data List<string>
                    RawData = xlsReader.ReadExcel(Filepath);
                    // Get sending data
                    foreach (var item in RawData)
                    {
                        string[] dataSplit = item.Split('_');

                        if (!string.IsNullOrEmpty(dataSplit[6]) && !string.IsNullOrEmpty(dataSplit[9]) && !string.IsNullOrEmpty(dataSplit[10]))
                        {
                            // 名稱 上市股本 現有股本 公司代號
                            Data.Add(FileName + "_" + dataSplit[6] + "_" + dataSplit[9] + "_" + dataSplit[10] + "_" + dataSplit[11]);
                        }
                    }
                    // Write into SQL
                    SQliteDb sQlite = new SQliteDb();
                    string insertString = "";
                    if (sQlite.DataAdd(FilePath.DB_saveDir, $"Capital", Header.Capital_header, Data, insertString))
                        MessageBox.Show("匯入資料庫成功!");
                    else
                        MessageBox.Show("匯入失敗(資料已存在)!");
                }
            }
        }

    }
    public class OTCFunction
    {
        MyFunction myFunction = new MyFunction();

        /// <summary>
        /// Read OTC alert data write into SQLite
        /// </summary>
        /// <param name="date">日期</param>
        public bool WriteOTCAlertToSQL(string date)
        {
            List<string> Data = new List<string>();
            string Date = myFunction.SolarToVids(date, false);

            // parse data
            var AlertIndfo = ParseOTCAlertInfo(date);
            if (AlertIndfo != null)
            {
                foreach (var item in AlertIndfo)
                {
                    Data.Add(Date + "_" + "櫃_" + item.Key + "_" + item.Value);
                }

                // write into SQLite
                SQliteDb sQlite = new SQliteDb();
                string insertString = "";
                if (sQlite.DataAdd(FilePath.DB_saveDir, "OTCAlert", Header.OTCAlert_header, Data, insertString))
                {
                    Console.WriteLine($"{date} OTCAlert 新增成功!");
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Parse OTC alert data
        /// </summary>
        /// <param name="date">Example : 109/08/24 </param>
        /// <returns></returns>
        public Dictionary<string, string> ParseOTCAlertInfo(string date)
        {
            try
            {
                Dictionary<string, string> Securities = new Dictionary<string, string>();
                HtmlWeb webClient = new HtmlWeb();
                var doc = webClient.Load($"https://www.tpex.org.tw/web/stock/trading/intraday_trading/intraday_trading_list_print.php?l=zh-tw&d={date}&stock_code=&s=0,asc,1");

                var table = doc.DocumentNode.SelectSingleNode("/html/body//td[contains(text(),'現股當沖交易標的')]");
                if (table != null)
                {
                    table = myFunction.FindTable(table);
                    var tbody = table.SelectNodes(".//tbody//tr");

                    if (tbody != null)
                    {
                        foreach (var tr in tbody)
                        {
                            List<string> Info = new List<string>();
                            foreach (var td in tr.SelectNodes(".//td"))
                            {
                                Info.Add(td.InnerText.Trim());
                            }
                            // cant day trade
                            if (!string.IsNullOrEmpty(Info[2]))
                                //  0 => 公司代號 1 => 公司名稱
                                Securities.Add(Info[0], Info[1]);
                        }
                        return Securities;
                    }
                }
            }
            catch (Exception Exception)
            {
                //Stock_Form.Log.Debug($"ParseOTCAlertInfo:{Exception.Message}");
            }
            return null;
        }

        /// <summary>
        /// Read OTC data write into SQLite
        /// </summary>
        /// <param name="date">日期</param>
        public bool WriteOTCToSQL(string date)
        {
            List<string> Data = new List<string>();
            string HolidayDate = myFunction.SolarToVids(date, false);

            // 爬取資料
            var ListedInfo = ParseOTCInfo(date);

            if (ListedInfo != null)
            {
                foreach (var item in ListedInfo)
                {
                    //Console.WriteLine($"{item.Key} : {string.Join("/", item.Value)}");
                    Data.Add(HolidayDate + "_" + "櫃_" + string.Join("_", item.Value));
                }

                // 寫入SQLite
                SQliteDb sQlite = new SQliteDb();
                string insertString = "";
                if (sQlite.DataAdd(FilePath.DB_saveDir, "OTC", Header.OTC_header, Data, insertString))
                {
                    Console.WriteLine($"{date} OTC 新增成功!");
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Parse OTC data
        /// </summary>
        /// <param name="date">Example : 109/08/24 </param>
        /// <returns></returns>
        public Dictionary<string, List<string>> ParseOTCInfo(string date)
        {
            try
            {
                // 抓取周轉率
                Dictionary<string, string> turnOver = ParseOTCTurnoverInfo(date);
                Dictionary<string, List<string>> Securities = new Dictionary<string, List<string>>();
                HtmlWeb webClient = new HtmlWeb();
                var doc = webClient.Load($"https://www.tpex.org.tw/web/stock/aftertrading/otc_quotes_no1430/stk_wn1430_result.php?l=zh-tw&o=htm&d={date}&se=EW&s=0,asc,0");
                var table = doc.DocumentNode.SelectSingleNode("/html/body//th[contains(text(),'上櫃股票每日收盤行情')]");

                if (table != null)
                {
                    table = myFunction.FindTable(table);
                    var tbody = table.SelectNodes(".//tbody//tr");
                    if (tbody != null)
                    {
                        foreach (var tr in tbody)
                        {
                            List<string> Info = new List<string>();
                            foreach (var td in tr.SelectNodes(".//td"))
                            {
                                Info.Add(td.InnerText.Trim());
                            }
                            // 2020-04-30多出買量賣量
                            if (DateTime.Compare(DateTime.Parse(myFunction.SolarToVidsDash(date)), DateTime.Parse("2020-04-29")) > 0)
                            {
                                Info.RemoveAt(11);
                                Info.RemoveAt(12);
                            }
                            if (turnOver.ContainsKey(Info[0]) && Info[0].Length < 5)
                            {
                                // 加入周轉率
                                Info.Add(turnOver[Info[0]]);
                            }
                            else
                            {
                                Info.Add("N");
                            }
                            if (Info[0].Length < 5)
                            {
                                Securities.Add(Info[0], Info);
                            }
                        }
                        return Securities;
                    }
                }
            }
            catch (Exception Exception)
            {
                //Stock_Form.Log.Debug($"ParseOTCAlertInfo:{Exception.Message}");
            }

            return null;
        }

        /// <summary>
        /// Parse OTC turnover data
        /// </summary>
        /// <param name="date">Example : 109/08/24 </param>
        /// <returns></returns>
        private Dictionary<string, string> ParseOTCTurnoverInfo(string date)
        {
            try
            {
                Dictionary<string, string> Securities = new Dictionary<string, string>();
                HtmlWeb webClient = new HtmlWeb();
                var doc = webClient.Load($"https://www.tpex.org.tw/web/stock/aftertrading/daily_turnover/trn_result.php?l=zh-tw&t=D&d={date}&s=0,asc,1&o=htm");
                var table = doc.DocumentNode.SelectSingleNode("/html/body//td[contains(text(),'上櫃股票個股')]");
                if (table != null)
                {
                    table = myFunction.FindTable(table);
                    var tbody = table.SelectNodes(".//tbody//tr");
                    if (tbody != null)
                    {
                        foreach (var tr in tbody)
                        {
                            List<string> Info = new List<string>();
                            foreach (var td in tr.SelectNodes(".//td"))
                            {
                                Info.Add(td.InnerText.Trim());
                            }
                            //  0=> 排行 1=> 股票代號  5=> 周轉率
                            Securities.Add(Info[1], Info[5]);
                        }
                        return Securities;
                    }
                }
            }
            catch (Exception Exception)
            {
                //Stock_Form.Log.Debug($"ParseOTCTurnoverInfo:{Exception.Message}");
            }

            return null;
        }

        /// <summary>
        /// Parse OTC major investors buy sell data
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public Dictionary<string, string> ParseOTCBuySell(string date)
        {
            try
            {
                Dictionary<string, string> Major = new Dictionary<string, string>();
                HtmlWeb webClient = new HtmlWeb();
                var doc = webClient.Load($"https://www.tpex.org.tw/web/stock/3insti/daily_trade/3itrade_hedge_result.php?l=zh-tw&o=htm&se=EW&t=D&d={date}&s=0,asc");

                var table = doc.DocumentNode.SelectSingleNode("/html/body//h1[contains(text(),'三大法人日交易資訊')]");
                if (table != null)
                {
                    table = myFunction.FindTable(table);
                    var tbody = table.SelectNodes(".//tbody//tr");

                    if (tbody != null)
                    {
                        foreach (var tr in tbody)
                        {
                            List<string> Info = new List<string>();
                            foreach (var td in tr.SelectNodes(".//td"))
                            {
                                Info.Add(td.InnerText.Trim());
                            }
                            if (DateTime.Compare(DateTime.Parse(date), DateTime.Parse("107/01/13")) < 0)
                            {
                                //  0 => 公司代號 18 => 三大法人買賣超
                                Major.Add(Info[0], Info[15]);
                            }
                            else
                            {
                                //  0 => 公司代號 23 => 三大法人買賣超
                                Major.Add(Info[0], Info[23]);
                            }
                        }
                        return Major;
                    }
                }
            }
            catch (Exception Exception)
            {
                //Stock_Form.Log.Debug($"ParseOTCBuySell:{Exception.Message}");
                //Console.WriteLine($"ParseOTCBuySell:{Exception.Message}");
            }
            return null;
        }

        /// <summary>
        /// Write OTC major investors buy and sell data into SQLites
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool WriteOTCBuySellToSQL(string date)
        {
            List<string> Data = new List<string>();
            string HolidayDate = myFunction.SolarToVids(date, false);

            // 爬取資料
            var AlertIndfo = ParseOTCBuySell(date);
            if (AlertIndfo != null)
            {
                foreach (var item in AlertIndfo)
                {
                    Data.Add(HolidayDate + "_" + "櫃_" + item.Key + "_" + item.Value);
                }
                // 寫入SQLite
                SQliteDb sQlite = new SQliteDb();
                string insertString = "";
                if (sQlite.DataAdd(FilePath.DB_saveDir, "OTCBuySell", Header.OTCBuySell_header, Data, insertString))
                {
                    Console.WriteLine($"{date} OTCBuySell 新增成功!");
                    return true;
                }

            }

            //Stock_Form.Log.Debug($"{date}:上櫃三大法人買賣超取得失敗!");
            return false;
        }


    }
}
