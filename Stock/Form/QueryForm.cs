using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        protected void Initial()
        {
            txt_date.Text = DateTime.Now.ToString("yyyyMMdd");

            Lbox_cmd.Items.Add($"SELECT * FROM Listed WHERE date='{txt_date.Text}'");
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {

        }

        private void Lbox_cmd_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Lbox_cmd_Click(object sender, EventArgs e)
        {
            lb_status.ForeColor = Color.Orange;
            lb_status.Text = "查詢中...";
            try
            {
                string query = Lbox_cmd.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(query))
                {
                    DataTable result = sQliteDb.GetDataTable(FilePath.DB_saveDir, query);
                    if (result != null)
                        dgv_data.DataSource = result;
                    lb_status.ForeColor = Color.Green;
                    lb_status.Text = "查詢結束 !!!";
                }
            }
            catch (Exception)
            {
                lb_status.ForeColor = Color.Red;
                lb_status.Text = "查詢失敗...";
            }

        }
    }
}
