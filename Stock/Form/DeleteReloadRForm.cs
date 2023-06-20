using DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class DeleteReloadRForm : Form
    {
        
        public DeleteReloadRForm()
        {
            InitializeComponent();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            string start = dp_start.Text.Trim();
            string end = dp_end.Text.Trim();
            string database = string.Empty;
            int timespan = Convert.ToInt16(txt_timespan.Text.Trim());
            switch (cmb_database.SelectedIndex)
            {
                case 0:
                    database = "Listed";
                    break;
                case 1:
                    database = "OTC";
                    break;
                case 2:
                    database = "ListedAlert";
                    break;
                case 3:
                    database = "OTCAlert";
                    break;
                case 4:
                    database = "ListedBuySell";
                    break;
                case 5:
                    database = "OTCBuySell";
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 資料庫查詢
        /// </summary>
        private void search()
        {
            using (StockDB db = new StockDB())
            {
                var x = db.Listeds;
                //var query = x.Where();
            }
        }
    }
}
