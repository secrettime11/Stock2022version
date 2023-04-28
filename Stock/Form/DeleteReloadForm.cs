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
            var alldays = myFunction.GetAllTestDate(dp_start.Text.Trim(), dp_end.Text.Trim());

            using (var db = new DataModels.StockDB())
            {
                var query =
                    (from c in db.Capitals
                     where alldays.Contains(c.Date)
                     select c).ToList();
                List<Model.Capital> data = new List<Model.Capital>();
                foreach (var item in query)
                {
                    Model.Capital temp = new Model.Capital();
                    temp.Date = item.Date;
                    temp.Id = Convert.ToInt32(item.Id);
                    temp.Name = item.Name;
                    temp.FirstCapital = item.FirstCapital;
                    temp.NowCapital = item.NowCapital;
                    data.Add(temp);
                }
                //DataTable OutputTable = ToView(data);
                this.Invoke((MethodInvoker)delegate
                {
                    //dgv_employee.DataSource = OutputTable;
                });
            }
        }

        //public DataTable ToView(List<Model.Capital> result)
        //{
        //    DataTable dataTable = new DataTable();
        //    if (result.Count > 0)
        //    {
        //        // Add column
        //        foreach (var item in Args.Capital_header)
        //            dataTable.Columns.Add(item);

        //        int rowC = 0;
        //        foreach (var item in result)
        //        {
        //            dataTable.Rows.Add();
        //            dataTable.Rows[rowC][0] = item.Id;
        //            dataTable.Rows[rowC][1] = item.Name;
        //            dataTable.Rows[rowC][2] = item.Team;
        //            dataTable.Rows[rowC][3] = item.Title;
        //            dataTable.Rows[rowC][4] = item.PCId;
        //            dataTable.Rows[rowC][5] = item.Ip;
        //            dataTable.Rows[rowC][6] = item.Extension;
        //            rowC++;
        //        }
        //    }
        //    return dataTable;
        //}
    }
}
