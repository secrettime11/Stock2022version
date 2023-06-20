namespace Stock
{
    partial class DeleteReloadRForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.dgv_employee = new Sunny.UI.UIDataGridView();
            this.btn_reload = new Sunny.UI.UIButton();
            this.btn_search = new Sunny.UI.UIButton();
            this.dp_end = new Sunny.UI.UIDatePicker();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.dp_start = new Sunny.UI.UIDatePicker();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.cmb_database = new Sunny.UI.UIComboBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.txt_timespan = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.btn_delete = new Sunny.UI.UIButton();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.cmb_database);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.dp_start);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Controls.Add(this.dp_end);
            this.uiGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(13, 14);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiGroupBox1.Size = new System.Drawing.Size(188, 235);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.Orange;
            this.uiGroupBox1.TabIndex = 6;
            this.uiGroupBox1.Text = "搜尋";
            // 
            // dgv_employee
            // 
            this.dgv_employee.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_employee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_employee.BackgroundColor = System.Drawing.Color.White;
            this.dgv_employee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_employee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_employee.EnableHeadersVisualStyles = false;
            this.dgv_employee.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_employee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_employee.Location = new System.Drawing.Point(208, 14);
            this.dgv_employee.Name = "dgv_employee";
            this.dgv_employee.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_employee.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_employee.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_employee.RowTemplate.Height = 29;
            this.dgv_employee.SelectedIndex = -1;
            this.dgv_employee.ShowGridLine = true;
            this.dgv_employee.Size = new System.Drawing.Size(608, 498);
            this.dgv_employee.Style = Sunny.UI.UIStyle.Custom;
            this.dgv_employee.TabIndex = 7;
            // 
            // btn_reload
            // 
            this.btn_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_reload.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.btn_reload.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btn_reload.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btn_reload.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_reload.Location = new System.Drawing.Point(23, 117);
            this.btn_reload.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_reload.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.btn_reload.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btn_reload.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btn_reload.Size = new System.Drawing.Size(150, 35);
            this.btn_reload.Style = Sunny.UI.UIStyle.Orange;
            this.btn_reload.TabIndex = 11;
            this.btn_reload.Text = "重新載入";
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btn_search.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.btn_search.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.btn_search.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.btn_search.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_search.Location = new System.Drawing.Point(13, 257);
            this.btn_search.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_search.Name = "btn_search";
            this.btn_search.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btn_search.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.btn_search.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.btn_search.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.btn_search.Size = new System.Drawing.Size(188, 35);
            this.btn_search.Style = Sunny.UI.UIStyle.Green;
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "查詢";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dp_end
            // 
            this.dp_end.FillColor = System.Drawing.Color.White;
            this.dp_end.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dp_end.Location = new System.Drawing.Point(23, 126);
            this.dp_end.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dp_end.MaxLength = 10;
            this.dp_end.MinimumSize = new System.Drawing.Size(63, 0);
            this.dp_end.Name = "dp_end";
            this.dp_end.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dp_end.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.dp_end.Size = new System.Drawing.Size(150, 29);
            this.dp_end.Style = Sunny.UI.UIStyle.Orange;
            this.dp_end.SymbolDropDown = 61555;
            this.dp_end.SymbolNormal = 61555;
            this.dp_end.TabIndex = 89;
            this.dp_end.Text = "2023-06-20";
            this.dp_end.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dp_end.Value = new System.DateTime(2023, 6, 20, 13, 47, 49, 210);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(19, 32);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(78, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Orange;
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "起始日期";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dp_start
            // 
            this.dp_start.FillColor = System.Drawing.Color.White;
            this.dp_start.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dp_start.Location = new System.Drawing.Point(23, 60);
            this.dp_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dp_start.MaxLength = 10;
            this.dp_start.MinimumSize = new System.Drawing.Size(63, 0);
            this.dp_start.Name = "dp_start";
            this.dp_start.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dp_start.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.dp_start.Size = new System.Drawing.Size(150, 29);
            this.dp_start.Style = Sunny.UI.UIStyle.Orange;
            this.dp_start.SymbolDropDown = 61555;
            this.dp_start.SymbolNormal = 61555;
            this.dp_start.TabIndex = 90;
            this.dp_start.Text = "2023-06-20";
            this.dp_start.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dp_start.Value = new System.DateTime(2023, 6, 20, 13, 47, 49, 210);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(19, 98);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(78, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Orange;
            this.uiLabel2.TabIndex = 91;
            this.uiLabel2.Text = "結束日期";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_database
            // 
            this.cmb_database.FillColor = System.Drawing.Color.White;
            this.cmb_database.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_database.Items.AddRange(new object[] {
            "上市",
            "上櫃",
            "禁沖(市)",
            "禁沖(櫃)",
            "買賣超(市)",
            "買賣超(櫃)"});
            this.cmb_database.Location = new System.Drawing.Point(23, 192);
            this.cmb_database.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_database.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_database.Name = "cmb_database";
            this.cmb_database.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_database.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.cmb_database.Size = new System.Drawing.Size(150, 29);
            this.cmb_database.Style = Sunny.UI.UIStyle.Orange;
            this.cmb_database.TabIndex = 92;
            this.cmb_database.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmb_database.Watermark = "Database";
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(19, 164);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(78, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Orange;
            this.uiLabel3.TabIndex = 93;
            this.uiLabel3.Text = "資料集";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.uiLabel4);
            this.uiGroupBox2.Controls.Add(this.txt_timespan);
            this.uiGroupBox2.Controls.Add(this.btn_reload);
            this.uiGroupBox2.Controls.Add(this.uiLabel6);
            this.uiGroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(13, 344);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiGroupBox2.Size = new System.Drawing.Size(188, 168);
            this.uiGroupBox2.Style = Sunny.UI.UIStyle.Orange;
            this.uiGroupBox2.TabIndex = 94;
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(19, 32);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(97, 23);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Orange;
            this.uiLabel6.TabIndex = 1;
            this.uiLabel6.Text = "TimeSpan";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_timespan
            // 
            this.txt_timespan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_timespan.DoubleValue = 60D;
            this.txt_timespan.FillColor = System.Drawing.Color.White;
            this.txt_timespan.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_timespan.IntValue = 60;
            this.txt_timespan.Location = new System.Drawing.Point(23, 69);
            this.txt_timespan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_timespan.Maximum = 2147483647D;
            this.txt_timespan.Minimum = -2147483648D;
            this.txt_timespan.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_timespan.Name = "txt_timespan";
            this.txt_timespan.Padding = new System.Windows.Forms.Padding(5);
            this.txt_timespan.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_timespan.Size = new System.Drawing.Size(118, 29);
            this.txt_timespan.Style = Sunny.UI.UIStyle.Orange;
            this.txt_timespan.TabIndex = 2;
            this.txt_timespan.Text = "60";
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(145, 75);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(35, 23);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Orange;
            this.uiLabel4.TabIndex = 12;
            this.uiLabel4.Text = "sec";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_delete.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btn_delete.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_delete.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_delete.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_delete.Location = new System.Drawing.Point(14, 301);
            this.btn_delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_delete.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btn_delete.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_delete.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_delete.Size = new System.Drawing.Size(188, 35);
            this.btn_delete.Style = Sunny.UI.UIStyle.Red;
            this.btn_delete.TabIndex = 95;
            this.btn_delete.Text = "刪除";
            // 
            // DeleteReloadRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 523);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.dgv_employee);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.btn_search);
            this.Name = "DeleteReloadRForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteReloadRForm";
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIDataGridView dgv_employee;
        private Sunny.UI.UIButton btn_reload;
        private Sunny.UI.UIButton btn_search;
        private Sunny.UI.UIComboBox cmb_database;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIDatePicker dp_start;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDatePicker dp_end;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txt_timespan;
        private Sunny.UI.UIButton btn_delete;
    }
}