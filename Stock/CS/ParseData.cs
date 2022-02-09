using DataModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stock
{
    public class ParseData
    {
        OTCFunction oTCFunction = new OTCFunction();
        ListedFunction listedFunction = new ListedFunction();
        MyFunction myFunction = new MyFunction();
        StockDB db = new StockDB();
        /// <summary>
        /// OTC data
        /// </summary>
        /// <param name="Day">20200808</param>
        public void Excuted(string Day, string type)
        {
            if (type == "市")
            {
                Dictionary<string, string> CapitalDic = new Dictionary<string, string>();
                string CapitalYear = (Convert.ToInt32(Day.Substring(0, 4)) - 1912).ToString();

                if (CapitalYear == "110")
                {
                    CapitalYear = (Convert.ToInt32(Day.Substring(0, 4)) - 1913).ToString();
                }

                var CapitalInfo = db.Capitals.Where(p => p.Date == CapitalYear).ToList();
                foreach (var item in CapitalInfo)
                    CapitalDic.Add(item.Id, item.NowCapital);

                listedFunction.WriteListedToSQL(Day, CapitalDic);
            }
            else if (type == "櫃")
            {
                oTCFunction.WriteOTCToSQL(myFunction.VidsToSolar(myFunction.VidsAddSlash(Day), true));
            }
        }
        /// <summary>
        /// Day trade data
        /// </summary>
        /// <param name="Day">20200808</param>
        public void DayTradeExcuted(string Day, string type)
        {
            if (type == "市")
            {
                listedFunction.WriteListedAlertToSQL(Day);
            }
            else if (type == "櫃")
            {
                oTCFunction.WriteOTCAlertToSQL(myFunction.VidsToSolar(myFunction.VidsAddSlash(Day), true));
            }
        }
        /// <summary>
        /// Buy & Sell of major investors data
        /// </summary>
        /// <param name="Day">20200808</param>
        public void BuySellExcuted(string Day, string type)
        {
            if (type == "市")
            {
                listedFunction.WriteListedBuySellToSQL(Day);
            }
            else if (type == "櫃")
            {
                oTCFunction.WriteOTCBuySellToSQL(myFunction.VidsToSolar(myFunction.VidsAddSlash(Day), true));
            }
        }

    }
}
