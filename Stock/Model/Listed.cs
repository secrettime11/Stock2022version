﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Model
{
    public class Listed
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        /// <summary>
        /// 漲跌
        /// </summary>
        public string UpDown { get; set; }
        /// <summary>
        /// 漲跌價差
        /// </summary>
        public string Pircedif { get; set; }
        /// <summary>
        /// 成交股數
        /// </summary>
        public string DealVolume { get; set; }
        /// <summary>
        /// 成交筆數
        /// </summary>
        public string DealNums { get; set; }
        /// <summary>
        /// 成交金額
        /// </summary>
        public string DealPrice { get; set; }
        /// <summary>
        /// 最後揭示買價
        /// </summary>
        public string LastBuyPrice { get; set; }
        /// <summary>
        /// 最後揭示買量
        /// </summary>
        public string LastBuyVolume { get; set; }
        /// <summary>
        /// 最後揭示賣價
        /// </summary>
        public string LastSellPrice { get; set; }
        /// <summary>
        /// 最後揭示賣量
        /// </summary>
        public string LastSellVolume { get; set; }
        /// <summary>
        /// 本益比
        /// </summary>
        public string PEratio { get; set; }
        /// <summary>
        /// 現有資本額
        /// </summary>
        public double NowCapital { get; set; }
        public double TurnoverRate { get; set; }
    }
}
