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
    public partial class DeleteReloadForm : Form
    {
        MyFunction myFunction = new MyFunction();
        public DeleteReloadForm()
        {
            InitializeComponent();
        }

        private void DeleteReloadForm_Load(object sender, EventArgs e)
        {
            dp_start.Value = StartDate(90);
            dp_end.Value = DateTime.Today;
        }

        private DateTime StartDate(int minusDays)
        {
            return DateTime.Today.AddDays(-minusDays);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // 日期區間
            var alldaysTmp = myFunction.GetAllTestDate(dp_start.Text.Trim(), dp_end.Text.Trim());
            var alldays = (alldaysTmp.Select(item => myFunction.VidsDumpSlash(item))).ToList();
            using (var db = new DataModels.StockDB())
            {
                var query =
                    (from c in db.Listeds
                     where alldays.Contains(c.Date)
                     select c).ToList();
                List<Model.ListedAlert> data = new List<Model.ListedAlert>();
                foreach (var item in query)
                {
                    Model.ListedAlert temp = new Model.ListedAlert();
                    temp.Date = item.Date;
                    //temp.Id = Convert.ToInt32(item.Id);
                    temp.Name = item.Name;
                    //temp.FirstCapital = item.FirstCapital;
                    //temp.NowCapital = item.NowCapital;
                    data.Add(temp);
                }
                Console.WriteLine(data.Count.ToString());
                DataTable OutputTable = ToView(data);
                this.Invoke((MethodInvoker)delegate
                {
                    dgv_dataset.DataSource = OutputTable;
                });
            }
        }

        public DataTable ToView(List<Model.ListedAlert> data)
        {
            DataTable dataTable = new DataTable();
            if (data.Count > 0)
            {
                // Add column
                foreach (var item in Header.Capital_header)
                    dataTable.Columns.Add(item);

                int rowC = 0;
                foreach (var item in data)
                {
                    dataTable.Rows.Add();
                    dataTable.Rows[rowC][0] = item.Date;
                    //dataTable.Rows[rowC][1] = item.Id;
                    dataTable.Rows[rowC][2] = item.Name;
                    //dataTable.Rows[rowC][3] = item.FirstCapital;
                    //dataTable.Rows[rowC][4] = item.NowCapital;
                    rowC++;
                }
            }
            return dataTable;
        }
    }
}
