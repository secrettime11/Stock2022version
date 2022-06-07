using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Model
{
    public class MS1
    {
        public class First
        {
            public string Id { get; set; }
            public string Type { get; set; }
            public string Close { get; set; }
            public string High { get; set; }
            public string Open { get; set; }
            public string Low { get; set; }
            public string UpDown { get; set; }
            public string TurnoverRate { get; set; }
            public string DealPrice { get; set; }
        }
        public class Second
        {
            public string Id { get; set; }
            public string Type { get; set; }
            public string Close { get; set; }
            public string Open { get; set; }
            public string High { get; set; }
            public string Low { get; set; }
            public string TurnoverRate { get; set; }
            public string DealPrice { get; set; }
            public string PreMax { get; set; }
            public string HighVolume { get; set; }
            public string HighPercent { get; set; }
            public string BuySell { get; set; }

        }
        public class Result
        {
            public string Date { get; set; }
            public string Type { get; set; }
            public string Id { get; set; }
            public string Name { get; set; }
            public string Close { get; set; }
            public string Open { get; set; }
            public string High { get; set; }
            public string Low { get; set; }
            public string TurnoverRate { get; set; }
            public string OpenT { get; set; }
            public string HighT { get; set; }
            public string LowT { get; set; }
            public string CloseT { get; set; }
            public string DealPrice { get; set; }
            public string Status { get; set; }
            public string Profit { get; set; }
            public string Average { get; set; }
            public string Order { get; set; }

            public string yOpen { get; set; }
            public string yHigh { get; set; }
            public string yLow { get; set; }
            public string yClose { get; set; }
            public string yDealprice { get; set; }
            public string RedLight { get; set; }
            public string HighVolume { get; set; }
            public string highPercent { get; set; }
            public string BuySell { get; set; }
            public string AvgDealPrice { get; set; }
        }
        public class SmartExcelResult
        {
            public string Date { get; set; }
            public string Id { get; set; }
            public string Name { get; set; }
            public string Close { get; set; }
            public string TurnoverRate { get; set; }
            public string DealPrice { get; set; }
            public string MaxPrice { get; set; }
        }
        public class S2Result
        {
            public string Date { get; set; }
            public string Type { get; set; }
            public string Id { get; set; }
            public string Name { get; set; }
            public string Close { get; set; }
            public string RedGreen { get; set; }
            public string IsHigh { get; set; }
            public string Status { get; set; }
            public string linePercent { get; set; }
            public string Profit { get; set; }
            public string TurnoverRate { get; set; }
            public string Order { get; set; }
        }
        public class S3Second
        {
            public string Id { get; set; }
            public string Type { get; set; }
            public string Close { get; set; }
            public string Open { get; set; }
            public string High { get; set; }
            public string Low { get; set; }
            public string TurnoverRate { get; set; }
            public string DealPrice { get; set; }
            public string PreMax { get; set; }
            public string HighVolume { get; set; }
            public string HighPercent { get; set; }
            public string BuySell { get; set; }

        }
        public class S3Result
        {
            public string Date { get; set; }
            public string Type { get; set; }
            public string Id { get; set; }
            public string Name { get; set; }
            public string Close { get; set; }
            public string Open { get; set; }
            public string High { get; set; }
            public string Low { get; set; }
            public string TurnoverRate { get; set; }
            public string OpenT { get; set; }
            public string HighT { get; set; }
            public string LowT { get; set; }
            public string CloseT { get; set; }
            public string DealPrice { get; set; }
            public string Status { get; set; }
            public string Profit { get; set; }
            public string Average { get; set; }
            public string Order { get; set; }

            public string yOpen { get; set; }
            public string yHigh { get; set; }
            public string yLow { get; set; }
            public string yClose { get; set; }
            public string yDealprice { get; set; }
            public string RedLight { get; set; }
            public string HighVolume { get; set; }
            public string highPercent { get; set; }
            public string BuySell { get; set; }
        }
        public class OrderInit 
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Price { get; set; }
            public string Qty { get; set; }
            public string totalPrice { get; set; }
        }
        public class S1SmartOrder 
        {
            /*進場*/
            /// <summary>
            /// 代號
            /// </summary>
            public string in_Id { get; set; }
            /// <summary>
            /// 名稱
            /// </summary>
            public string in_Name { get; set; }
            /// <summary>
            /// (入)買賣別
            /// </summary>
            public int in_BuySell { get; set; }
            /// <summary>
            /// 委託價
            /// </summary>
            public string in_Price { get; set; }
            /// <summary>
            /// 委託量
            /// </summary>
            public string in_Qty { get; set; }
            /// <summary>
            /// 委託條件
            /// </summary>
            public int in_Condition { get; set; }
            /// <summary>
            /// 委託類型
            /// </summary>
            public int in_Type { get; set; }
            
            /*MIT*/
            /// <summary>
            /// MIT
            /// </summary>
            public int MIT { get; set; }
            /// <summary>
            /// MIT買賣別
            /// </summary>
            public string mit_BuySell { get; set; }
            /// <summary>
            /// MIT觸發價
            /// </summary>
            public string mit_TriggerPrice { get; set; }
            /// <summary>
            /// MIT當前市價
            /// </summary>
            public string mit_MarketPrice { get; set; }

            /*出清(停損)*/
            /// <summary>
            /// 停損
            /// </summary>
            public int Loss { get; set; }
            /// <summary>
            /// (損)委託條件
            /// </summary>
            public int loss_Condition { get; set; }
            /// <summary>
            /// (損)%
            /// </summary>
            public int loss_Percent { get; set; }
            /// <summary>
            /// (損)%值
            /// </summary>
            public string loss_Percent_value { get; set; }
            /// <summary>
            /// (損)觸發價
            /// </summary>
            public int loss_TriggerPrice { get; set; }
            /// <summary>
            /// (損)觸發價值
            /// </summary>
            public string loss_TriggerPrice_value { get; set; }
            /// <summary>
            /// (損)限價
            /// </summary>
            public int loss_DefinePrice { get; set; }
            /// <summary>
            /// (損)限價值
            /// </summary>
            public string loss_DefinePrice_value { get; set; }
            /// <summary>
            /// (損)市價
            /// </summary>
            public bool loss_MarketPrice { get; set; }

            /*出清(停利)*/
            /// <summary>
            /// 停利
            /// </summary>
            public bool Earn { get; set; }
            /// <summary>
            /// (利)委託條件
            /// </summary>
            public string earn_Condition { get; set; }
            /// <summary>
            /// (利)%
            /// </summary>
            public bool Earn_Percent { get; set; }
            /// <summary>
            /// (利)%值
            /// </summary>
            public string Earn_Percent_value { get; set; }
            /// <summary>
            /// (利)觸發價
            /// </summary>
            public bool earn_TriggerPrice { get; set; }
            /// <summary>
            /// (利)觸發價值
            /// </summary>
            public string earn_TriggerPrice_value { get; set; }
            /// <summary>
            /// (利)限價
            /// </summary>
            public bool earn_DefinePrice { get; set; }
            /// <summary>
            /// (利)限價值
            /// </summary>
            public string earn_DefinePrice_value { get; set; }
            /// <summary>
            /// (利)市價
            /// </summary>
            public bool earn_MarketPrice { get; set; }

            /// <summary>
            /// 出清
            /// </summary>
            public bool Clear { get; set; }
            /// <summary>
            /// 出清時間
            /// </summary>
            public string c_Time { get; set; }
            /// <summary>
            /// (清)委託條件
            /// </summary>
            public string c_Condition { get; set; }
            /// <summary>
            /// (清)限價
            /// </summary>
            public bool c_DefinePrice { get; set; }
            /// <summary>
            /// (清)限價值
            /// </summary>
            public string c_DefinePrice_value { get; set; }
            /// <summary>
            /// (清)市價
            /// </summary>
            public string c_MarketPrice { get; set; }
            /// <summary>
            /// 盤後定盤
            /// </summary>
            public bool FinalSet { get; set; }
        }
        /*
            **進場**
            代號
            買賣別
            委託價
            委託量
            條件ROD
            類型 限價
            **MIT**
            買賣別
            觸發價
            當前市價
            **出清(停損停利)**
            條件ROD
            觸發 % 價格 出清類型(市價/限價)
            出清時間 條件ROD 出清類型(市價/限價)
         */
    }
}
