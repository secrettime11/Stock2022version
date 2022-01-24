using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Model
{
    public class OTCAlert
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
    }
}
