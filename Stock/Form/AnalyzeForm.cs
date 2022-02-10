using ExcelDataReader;
using Stock.CS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class AnalyzeForm : Form
    {
        DataTableCollection tableCollection;
        public AnalyzeForm()
        {
            InitializeComponent();
        }

        private void AnalyzeForm_Load(object sender, EventArgs e)
        {
            ini();
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx;*.xlsm" })
            {
                openFileDialog.InitialDirectory = txt_dir.Text;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_FileName.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cb_sheet.Items.Clear();
                            foreach (DataTable item in tableCollection)
                            {
                                cb_sheet.Items.Add(item.TableName);
                                cb_sheet.SelectedIndex = 0;
                            }
                        }
                    }
                }
            }
        }
        private void ini()
        {
            txt_dir.Text = SettingConfig.getitemvalue("dirPath");
        }

        private void cb_sheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cb_sheet.SelectedItem.ToString()];
            dgv_data.DataSource = dt;
            foreach (DataGridViewColumn item in dgv_data.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void dgv_data_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //自動編號，與資料無關
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
               e.RowBounds.Location.Y,
               dgv_data.RowHeadersWidth - 4,
               e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics,
                  (e.RowIndex + 1).ToString(),
                   dgv_data.RowHeadersDefaultCellStyle.Font,
                   rectangle,
                   dgv_data.RowHeadersDefaultCellStyle.ForeColor,
                   TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void btn_setDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog path = new FolderBrowserDialog())
            {
                path.ShowDialog();
                txt_dir.Text = path.SelectedPath;
                SettingConfig.modifyitem("dirPath", path.SelectedPath);
            }
        }
    }
}
