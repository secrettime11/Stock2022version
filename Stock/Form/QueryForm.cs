using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class QueryForm : Form
    {
        SQliteDb sQliteDb = new SQliteDb();
        public QueryForm()
        {
            InitializeComponent();
            Initial();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {

        }

        #region Control
        private void Lbox_cmd_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void Lbox_cmd_Click(object sender, EventArgs e)
        {
        }
        private void Lbox_cmd_DoubleClick(object sender, EventArgs e)
        {
            lb_status.ForeColor = Color.Orange;
            Thread mission = new Thread(searchMisson);
            mission.Start();
        }
        #endregion

        #region Function
        protected void Initial()
        {
            txt_date.Text = DateTime.Now.AddDays(-5).ToString("yyyyMMdd");

            Lbox_cmd.Items.Add($"SELECT * FROM Listed WHERE date='{txt_date.Text}'");
        }
        private void searchMisson()
        {
            string query = String.Empty;
            try
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    lb_status.Text = "查詢中...";
                    query = Lbox_cmd.SelectedItem.ToString();
                });

                if (!string.IsNullOrEmpty(query))
                {
                    DataTable result = sQliteDb.GetDataTable(FilePath.DB_saveDir, query);
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        if (result != null)
                            dgv_data.DataSource = result;
                        lb_status.Text = "查詢結束 !!!";
                        lb_status.ForeColor = Color.Green;
                    });
                }

            }
            catch (Exception)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    lb_status.Text = "查詢失敗...";
                    lb_status.ForeColor = Color.Red;
                });
            }
        }
        #endregion
    }
}
