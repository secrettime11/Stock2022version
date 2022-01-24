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
    }
}
