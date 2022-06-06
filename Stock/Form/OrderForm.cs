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
            cmb_inCondition.SelectedIndex = 0;
            cmb_lossCondition.SelectedIndex = 0;
            cmb_earnCondition.SelectedIndex = 0;
            cmb_cleanCondition.SelectedIndex = 0;

            cmb_inType.SelectedIndex = 1;
            cmb_lossType.SelectedIndex = 0;
            cmb_earnType.SelectedIndex = 0;
            cmb_cleanType.SelectedIndex = 0;
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
