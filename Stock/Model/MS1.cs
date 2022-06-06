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
            public string in_Id { get; set; }
            /// <summary>
            /// 0 = Buy
            /// </summary>
            public string in_BuySell { get; set; }
            public string in_Price { get; set; }
            public string in_Qty { get; set; }
            public string in_Condition { get; set; }
            /// <summary>
            /// 0 = 市價
            /// </summary>
            public string in_Type { get; set; }

            /*MIT*/
            /// <summary>
            /// True = Buy
            /// </summary>
            public string mit_BuySell { get; set; }
            public string mit_TriggerPrice { get; set; }
            public string mit_MarketPrice { get; set; }

            /*出清*/
            public string loss_Condition { get; set; }
            public string loss_Percent { get; set; }
            public string loss_TriggerPrice { get; set; }
            public string loss_Type { get; set; }
            public string loss_c_Price { get; set; }

            public string earn_Condition { get; set; }
            public string earn_Percent { get; set; }
            public string earn_TriggerPrice { get; set; }
            public string earn_Type { get; set; }
            public string earn_c_Price { get; set; }

            public string c_Time { get; set; }
            public string c_Condition { get; set; }
            public string c_Type { get; set; }
            public string c_c_Price { get; set; }
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
