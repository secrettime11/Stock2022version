using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class OrderForm : Form
    {
        MyFunction myFunction = new MyFunction();
        public OrderForm(List<Model.MS1.OrderInit> inits)
        {
            InitializeComponent();
            cmb_BuySell.SelectedIndex = 1;
            cmb_inCondition.SelectedIndex = 0;
            cmb_lossCondition.SelectedIndex = 0;
            cmb_earnCondition.SelectedIndex = 0;
            cmb_cleanCondition.SelectedIndex = 0;

            cmb_inType.SelectedIndex = 1;
            cmb_lossType.SelectedIndex = 0;
            cmb_earnType.SelectedIndex = 0;
            cmb_cleanType.SelectedIndex = 0;
            dgv_data.DataSource = myFunction.OrderInitToDGV(inits);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void dgv_data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal total = 0;
            if (dgv_data.CurrentCell.ColumnIndex == 3)
            {
                decimal close = Convert.ToDecimal(dgv_data.Rows[dgv_data.CurrentRow.Index].Cells[2].Value);
                decimal qty = Convert.ToDecimal(dgv_data.Rows[dgv_data.CurrentRow.Index].Cells[3].Value);
                dgv_data.Rows[dgv_data.CurrentRow.Index].Cells[4].Value = (qty * close).ToString();

                foreach (DataGridViewRow row in dgv_data.Rows)
                {
                    if (!string.IsNullOrEmpty(row.Cells[4].Value.ToString()))
                    {
                        total += Convert.ToDecimal(row.Cells[4].Value.ToString());
                    }
                }
                lbl_total.Text = $"下單價格總和 : {total}";
            }

        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            ExcelWriter writer = new ExcelWriter();

            string Path = Application.StartupPath + @"\Excel\Order";
            if (!Directory.Exists(Path))
                Directory.CreateDirectory(Path);

            List<Model.MS1.OrderInit> OrderData = new List<Model.MS1.OrderInit>();

            // -1 => 最後一行為空
            for (int rows = 0; rows < dgv_data.Rows.Count; rows++)
            {
                Model.MS1.OrderInit data = new Model.MS1.OrderInit();
                data.Id = dgv_data.Rows[rows].Cells[0].Value.ToString();
                data.Name = dgv_data.Rows[rows].Cells[1].Value.ToString();
                data.Price = dgv_data.Rows[rows].Cells[2].Value.ToString();
                data.Qty = dgv_data.Rows[rows].Cells[3].Value.ToString();
                data.totalPrice = dgv_data.Rows[rows].Cells[4].Value.ToString();
                OrderData.Add(data);
            }

            if (dgv_data.Rows.Count < 1)
            {
                MessageBox.Show("沒有資料", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (File.Exists(Application.StartupPath + @"\Excel\Order\" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx"))
            {
                if (MessageBox.Show("檔名已存在，是否覆蓋", "文件已存在", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    writer.OrderToExcel(DateTime.Now.ToString("yyyyMMdd"), OrderData);
                else
                    return;
            }
            else
                writer.OrderToExcel(DateTime.Now.ToString("yyyyMMdd"), OrderData);
        }

        private void btn_openExe_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Brumby\Desktop\Project\OrderSystem\OrderSystem\bin\Debug\OrderSystem.exe";
            Process[] processes = Process.GetProcessesByName("OrderSystem");
            if (processes.Length == 0)
            {
                Process.Start(path);
            }
        }
    }
}
