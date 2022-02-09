using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public class Args
    {
        #region Public args
        /// <summary>
        /// Backtest start day
        /// </summary>
        public string startDay { get; set; }
        /// <summary>
        /// Backtest end day
        /// </summary>
        public string endDay { get; set; }
        /// <summary>
        /// Pick quantity
        /// </summary>
        public string pickQuantity { get; set; }
        /// <summary>
        /// Average days
        /// </summary>
        public string averageDays { get; set; }
        /// <summary>
        /// Total backtest days
        /// </summary>
        public string totalTestDays { get; set; }
        /// <summary>
        /// Stop loss and take profit calculate value
        /// </summary>
        public List<double> lossProfitValue { get; set; }
        /// <summary>
        /// All test date (yyyy/MM/dd)
        /// </summary>
        public List<string> BacktestDates { get; set; }
        /// <summary>
        /// One run days (20200101)
        /// </summary>
        public List<string> DaysOneRun { get; set; }
        /// <summary>
        /// OTCAlert list
        /// </summary>
        public List<string> OTCAlert { get; set; }
        /// <summary>
        /// Listed list
        /// </summary>
        public List<string> ListedAlert { get; set; }
        /// <summary>
        /// Listed ["Company id" : "BuySell"]
        /// </summary>
        public Dictionary<string, string> ListedBuySellDic { get; set; }
        /// <summary>
        /// OTC ["Company id" : "BuySell"]
        /// </summary>
        public Dictionary<string, string> OTCBuySellDic { get; set; }
        /// <summary>
        /// OTC [Type : Value]
        /// </summary>
        public Dictionary<string, string> TurnoverDic { get; set; }
        /// <summary>
        /// 做空TRUE 做多FALSE
        /// </summary>
        public bool ProfitLoss { get; set; }
        /// <summary>
        /// 收盤價Value
        /// </summary>
        public string ClosePrice { get; set; }
        /// <summary>
        /// 收盤價條件 0=無限制 1=大於等於 2=小於等於 3=介於
        /// </summary>
        public int closeCondition { get; set; }
        /// <summary>
        /// Pick stock date
        /// </summary>
        public string PickDate { get; set; }
        /// <summary>
        /// close between small
        /// </summary>
        public string close1 { get; set; }
        /// <summary>
        /// close between big
        /// </summary>
        public string close2 { get; set; }
        /// <summary>
        /// 獲利計算 當沖=true
        /// </summary>
        public bool DayTrade { get; set; }
        /// <summary>
        /// 停損tick
        /// </summary>
        public int LossTick { get; set; }
        /// <summary>
        /// 停利tick
        /// </summary>
        public int EarnTick { get; set; }
        /// <summary>
        /// 手續費折數
        /// </summary>
        public decimal Discount { get; set; }
        /// <summary>
        /// 進場tick
        /// </summary>
        public int InTick { get; set; }
        /// <summary>
        /// 進場價格條件 0=開盤價 1=平盤下 2=平盤上
        /// </summary>
        public int InCondition { get; set; }
        #endregion

        #region S1
        /// <summary>
        /// + - K
        /// </summary>
        public string s1UpDown { get; set; }
        /// <summary>
        /// 前高類型 最高價=false 收盤價=true
        /// </summary>
        public bool s1HighType { get; set; }
        /// <summary>
        /// >deal price
        /// </summary>
        public string s1tPrice { get; set; }
        /// <summary>
        /// vibration value
        /// </summary>
        public string s1VibValue { get; set; }
        /// <summary>
        /// 前高停損 true
        /// </summary>
        public bool s1HighStopLoss { get; set; }
        /// <summary>
        /// 前高數量 > x
        /// </summary>
        public string highVolume { get; set; }

        /// <summary>
        /// 前高對比 今收盤||最高 true=最高 false=收盤
        /// </summary>
        public bool THighClose { get; set; }
        public string NotHighDisValue { get; set; }
        public bool DisplayDealpriceAvg { get; set; }
        #endregion

        #region S2
        /// <summary>
        /// 周轉率前X value
        /// </summary>
        public string s2turnovertValue { get; set; }
        /// <summary>
        /// 上隱線 yes = true ; no = false
        /// </summary>
        public bool s2virtualLine { get; set; }
        #endregion

        #region S3
        /// <summary>
        /// 周轉率前X value
        /// </summary>
        public string s3turnovertValue { get; set; }
        #endregion
    }

    public class Market
    {
        /// <summary>
        /// Market open on weekend
        /// </summary>
        public static readonly List<string> OpenWeekend = new List<string>() { "20141227", "20160130", "20160604", "20160910", "20170218", "20170603", "20170930", "20180331", "20181222" };
        /// <summary>
        /// National holiday (Market not open and not weekend)
        /// </summary>
        public static readonly List<string> CloseDay = new List<string>() { "20150403", "20150406", "20150501", "20150619", "20150928", "20151009", "20160101", "20160204", "20160205", "20160208", "20160209", "20160210", "20160211", "20160212", "20160229", "20160404", "20160405", "20160502", "20160609", "20160610", "20160915", "20160916", "20161010", "20170102", "20170125", "20170126", "20170127", "20170130", "20170131", "20170201", "20170227", "20170228", "20170403", "20170404", "20170501", "20170529", "20170530", "20171004", "20171009", "20171010", "20180101", "20180213", "20180214", "20180215", "20180216", "20180219", "20180220", "20180228", "20180404", "20180405", "20180406", "20180501", "20180618", "20180924", "20181010", "20181231", "20190101", "20190131", "20190201", "20190204", "20190205", "20190206", "20190207", "20190208", "20190228", "20190301", "20190404", "20190405", "20190501", "20190607", "20190913", "20191010", "20191011", "20200101", "20200121", "20200122", "20200123", "20200124", "20200127", "20200128", "20200129", "20200228", "20200402", "20200403", "20200501", "20200625", "20200626", "20201001", "20201002", "20201009", "20210101", "20210208", "20210209", "20210210", "20210211", "20210212", "20210215", "20210216", "20210301", "20210402", "20210405", "20210430", "20210614", "20210920", "20210921", "20211011", "20211231","20220127","20220128","20220131","20220201", "20220202", "20220203", "20220204", "20220228", "20220404", "20220405", "20220502", "20220603", "20220909", "20221010" };
    }

    public class FilePath
    {
        /// <summary>
        /// Database path
        /// </summary>
        public const string DB_saveDir = @"C:\Data\Stock.db";
    }

    public class Header
    {
        /// <summary>
        /// Listed capital header
        /// </summary>
        public static readonly List<string> Capital_header = new List<string>() { "Date", "Name", "FirstCapital", "NowCapital", "Id" };
        /// <summary>
        /// Listed header
        /// </summary>
        public static readonly List<string> Listed_header = new List<string>() { "Date", "Type", "Id", "Name", "DealVolume", "DealNums", "DealPrice", "Open", "High", "Low", "Close", "UpDown", "Pircedif", "LastBuyPrice", "LastBuyVolume", "LastSellPrice", "LastSellVolume", "PEratio", "NowCapital", "TurnoverRate" };
        /// <summary>
        /// Listed day trade header
        /// </summary>
        public static readonly List<string> ListedAlert_header = new List<string>() { "Date", "Type", "Id", "Name" };
        /// <summary>
        /// Listed buy sell header
        /// </summary>
        public static readonly List<string> ListedBuySell_header = new List<string>() { "Date", "Type", "Id", "MBuySell" };
        /// <summary>
        /// OTC header
        /// </summary>
        public static readonly List<string> OTC_header = new List<string>() { "Date", "Type", "Id", "Name", "Close", "UpDown", "Open", "High", "Low", "DealVolume", "DealPrice", "DealNums", "LastBuyPrice", "LastSellPrice", "NowCapital", "MaxPriceT", "MinPriceT", "TurnoverRate" };
        /// <summary>
        /// OTC day trade header
        /// </summary>
        public static readonly List<string> OTCAlert_header = new List<string>() { "Date", "Type", "Id", "Name" };
        /// <summary>
        /// OTC buy sell header
        /// </summary>
        public static readonly List<string> OTCBuySell_header = new List<string>() { "Date", "Type", "Id", "MBuySell" };

        public static readonly List<string> Output_header = new List<string>() { "日期", "市櫃", "代號", "名稱", "收盤價", "周轉率", "隔開盤價", "隔最高價", "隔最低價", "隔收盤價", "成交金額", "狀態", "獲利%", "平均", "排行", "前開", "前最高", "前最低", "前收", "前成交金額", "漲停","前高數量" ,"前高距離(%)", "三大法人" };

        public static readonly List<string> Output_headerAvg = new List<string>() { "日期", "市櫃", "代號", "名稱", "收盤價", "周轉率", "隔開盤價", "隔最高價", "隔最低價", "隔收盤價", "成交金額", "狀態", "獲利%", "平均", "排行", "前開", "前最高", "前最低", "前收", "前成交金額", "漲停", "前高數量", "前高距離(%)", "三大法人", "前成交金額平均" };

        public static readonly List<string> OutputPick_header = new List<string>() { "日期", "市櫃", "代號", "名稱", "開盤價", "最高價", "最低價", "收盤價", "周轉率", "成交金額", "昨收", "排行", "前高數量", "前高距離(%)", "三大法人" };
        public static readonly List<string> OutputPick_headerAvg = new List<string>() { "日期", "市櫃", "代號", "名稱", "開盤價", "最高價", "最低價", "收盤價", "周轉率", "成交金額", "昨收", "排行", "前高數量", "前高距離(%)", "三大法人", "成交金額平均" };

        public static readonly List<string> S2Output_header = new List<string>() { "日期", "市櫃", "代號", "名稱","前收", "紅綠K", "新高", "狀態","隱線長(%)", "獲利","周轉率","排名" };

        public static readonly List<string> S3Output_header = new List<string>() { "日期", "市櫃", "代號", "名稱", "收盤價", "周轉率", "隔開盤價", "隔最高價", "隔最低價", "隔收盤價", "成交金額", "狀態", "獲利%", "平均", "排行", "前開", "前最高", "前最低", "前收", "前成交金額", "漲停", "前高數量", "前高距離(%)","三大法人" };
        public static readonly List<string> S3OutputPick_header = new List<string>() { "日期", "市櫃", "代號", "名稱", "開盤價", "最高價", "最低價", "收盤價", "周轉率", "成交金額", "昨收", "排行", "前高數量", "前高距離(%)", "三大法人" };

    }
}
