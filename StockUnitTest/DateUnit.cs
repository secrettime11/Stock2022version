using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StockUnitTest
{
    [TestClass]
    public class DateUnit
    {
        [TestMethod]
        public void DateTest()
        {

        }
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
        public string VidsToSolar(string date, bool Slash)
        {
            Console.WriteLine(Convert.ToDateTime(date).ToString("yyyMMdd"));
            string[] dateSplit = date.Trim().Split('/');
            string year = (Convert.ToInt32(dateSplit[0]) - 1911).ToString();
            string returnDate = "";

            if (Slash)
                returnDate = $"{year}/{dateSplit[1]}/{dateSplit[2]}";
            else
                returnDate = $"{year}{dateSplit[1]}{dateSplit[2]}";

            return returnDate;
        }
        public string VidsAddSlash(string date)
        {
            Console.WriteLine(date.Length);
            string result = String.Empty;
            if (date.Length == 8)
                result = date.Substring(0, 4) + "/" + date.Substring(4, 2) + "/" + date.Substring(6, 2);
            return result;
        }
    }
}
