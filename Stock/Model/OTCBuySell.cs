using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Model
{
    public class OTCBuySell
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Type { get; set; }
        public string MBuySell { get; set; }
    }
}
