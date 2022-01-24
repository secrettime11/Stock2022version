using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Model
{
    public class Capital
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 起始資本額
        /// </summary>
        public string FirstCapital { get; set; }
        /// <summary>
        /// 現有資本額
        /// </summary>
        public string NowCapital { get; set; }
    }
}
