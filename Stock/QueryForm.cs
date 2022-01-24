﻿using System;
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
            txt_date.Text = DateTime.Now.AddDays(-5).ToString("yyyyMMdd");

            Lbox_cmd.Items.Add($"SELECT * FROM Listed WHERE date='{txt_date.Text}'");
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            foreach (var item in Lbox_cmd.Items)
            {
                
            }
            
        }

        private void Lbox_cmd_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("HHH");
            string query = Lbox_cmd.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(query))
            {
                DataTable result = sQliteDb.GetDataTable(FilePath.DB_saveDir, query);
                if (result != null)
                {
                    dgv_data.DataSource = result;
                }
            }
        }
    }
}
