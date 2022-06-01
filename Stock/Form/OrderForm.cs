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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            foreach (var item in Header.Order_header)
            {
                dataTable.Columns.Add(item);
            }
            dgv_data.DataSource = dataTable;
        }

        private void dgv_data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dgv_data.Rows[dgv_data.CurrentRow.Index].Cells[dgv_data.CurrentCell.ColumnIndex+1].Value = "99";
        }
    }
}
