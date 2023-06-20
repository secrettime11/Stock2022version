namespace Stock
{
    partial class DeleteReloadForm
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
            this.dp_end = new Sunny.UI.UIDatePicker();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLine7 = new Sunny.UI.UILine();
            this.dp_start = new Sunny.UI.UIDatePicker();
            this.cmb_dataset = new Sunny.UI.UIComboBox();
            this.dgv_dataset = new Sunny.UI.UIDataGridView();
            this.btn_deleteandreload = new Sunny.UI.UIButton();
            this.btn_delete = new Sunny.UI.UIButton();
            this.btn_reload = new Sunny.UI.UIButton();
            this.btn_search = new Sunny.UI.UIButton();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataset)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.dp_end);
            this.uiGroupBox1.Controls.Add(this.uiLine1);
            this.uiGroupBox1.Controls.Add(this.uiLine7);
            this.uiGroupBox1.Controls.Add(this.dp_start);
            this.uiGroupBox1.Controls.Add(this.cmb_dataset);
            this.uiGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(13, 14);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiGroupBox1.Size = new System.Drawing.Size(434, 115);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.Orange;
            this.uiGroupBox1.TabIndex = 6;
            this.uiGroupBox1.Text = "搜尋";
            // 
            // dp_end
            // 
            this.dp_end.FillColor = System.Drawing.Color.White;
            this.dp_end.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dp_end.Location = new System.Drawing.Point(170, 72);
            this.dp_end.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dp_end.MaxLength = 10;
            this.dp_end.MinimumSize = new System.Drawing.Size(63, 0);
            this.dp_end.Name = "dp_end";
            this.dp_end.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dp_end.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.dp_end.Size = new System.Drawing.Size(137, 29);
            this.dp_end.Style = Sunny.UI.UIStyle.Orange;
            this.dp_end.SymbolDropDown = 61555;
            this.dp_end.SymbolNormal = 61555;
            this.dp_end.TabIndex = 145;
            this.dp_end.Text = "2021-04-07";
            this.dp_end.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dp_end.Value = new System.DateTime(2021, 4, 7, 0, 0, 0, 0);
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiLine1.Location = new System.Drawing.Point(170, 35);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(74, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Orange;
            this.uiLine1.TabIndex = 146;
            this.uiLine1.Text = "結束日";
            // 
            // uiLine7
            // 
            this.uiLine7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.uiLine7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiLine7.Location = new System.Drawing.Point(13, 35);
            this.uiLine7.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine7.Name = "uiLine7";
            this.uiLine7.Size = new System.Drawing.Size(74, 29);
            this.uiLine7.Style = Sunny.UI.UIStyle.Orange;
            this.uiLine7.TabIndex = 145;
            this.uiLine7.Text = "起始日";
            // 
            // dp_start
            // 
            this.dp_start.FillColor = System.Drawing.Color.White;
            this.dp_start.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dp_start.Location = new System.Drawing.Point(13, 72);
            this.dp_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dp_start.MaxLength = 10;
            this.dp_start.MinimumSize = new System.Drawing.Size(63, 0);
            this.dp_start.Name = "dp_start";
            this.dp_start.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dp_start.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.dp_start.Size = new System.Drawing.Size(137, 29);
            this.dp_start.Style = Sunny.UI.UIStyle.Orange;
            this.dp_start.SymbolDropDown = 61555;
            this.dp_start.SymbolNormal = 61555;
            this.dp_start.TabIndex = 144;
            this.dp_start.Text = "2021-04-07";
            this.dp_start.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dp_start.Value = new System.DateTime(2021, 4, 7, 0, 0, 0, 0);
            // 
            // cmb_dataset
            // 
            this.cmb_dataset.FillColor = System.Drawing.Color.White;
            this.cmb_dataset.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_dataset.Items.AddRange(new object[] {
            "上市資本額",
            "上市",
            "上櫃",
            "上市法人買賣超",
            "上櫃法人買賣超",
            "上市禁沖",
            "上櫃禁沖"});
            this.cmb_dataset.Location = new System.Drawing.Point(328, 72);
            this.cmb_dataset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_dataset.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_dataset.Name = "cmb_dataset";
            this.cmb_dataset.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_dataset.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.cmb_dataset.Size = new System.Drawing.Size(91, 29);
            this.cmb_dataset.Style = Sunny.UI.UIStyle.Orange;
            this.cmb_dataset.TabIndex = 6;
            this.cmb_dataset.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmb_dataset.Watermark = "資料表";
            // 
            // dgv_dataset
            // 
            this.dgv_dataset.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_dataset.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_dataset.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dataset.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dataset.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_dataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_dataset.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_dataset.EnableHeadersVisualStyles = false;
            this.dgv_dataset.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_dataset.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_dataset.Location = new System.Drawing.Point(13, 137);
            this.dgv_dataset.Name = "dgv_dataset";
            this.dgv_dataset.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dataset.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_dataset.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_dataset.RowTemplate.Height = 29;
            this.dgv_dataset.SelectedIndex = -1;
            this.dgv_dataset.ShowGridLine = true;
            this.dgv_dataset.Size = new System.Drawing.Size(631, 365);
            this.dgv_dataset.Style = Sunny.UI.UIStyle.Custom;
            this.dgv_dataset.TabIndex = 7;
            // 
            // btn_deleteandreload
            // 
            this.btn_deleteandreload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteandreload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_deleteandreload.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btn_deleteandreload.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btn_deleteandreload.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btn_deleteandreload.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_deleteandreload.Location = new System.Drawing.Point(557, 94);
            this.btn_deleteandreload.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_deleteandreload.Name = "btn_deleteandreload";
            this.btn_deleteandreload.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_deleteandreload.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btn_deleteandreload.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btn_deleteandreload.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btn_deleteandreload.Size = new System.Drawing.Size(87, 35);
            this.btn_deleteandreload.Style = Sunny.UI.UIStyle.Custom;
            this.btn_deleteandreload.TabIndex = 11;
            this.btn_deleteandreload.Text = "刪除並重載";
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_delete.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btn_delete.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_delete.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_delete.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_delete.Location = new System.Drawing.Point(557, 30);
            this.btn_delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_delete.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btn_delete.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_delete.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_delete.Size = new System.Drawing.Size(87, 35);
            this.btn_delete.Style = Sunny.UI.UIStyle.Red;
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "刪除";
            // 
            // btn_reload
            // 
            this.btn_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_reload.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.btn_reload.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btn_reload.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btn_reload.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_reload.Location = new System.Drawing.Point(454, 94);
            this.btn_reload.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_reload.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.btn_reload.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btn_reload.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btn_reload.Size = new System.Drawing.Size(87, 35);
            this.btn_reload.Style = Sunny.UI.UIStyle.Orange;
            this.btn_reload.TabIndex = 9;
            this.btn_reload.Text = "重載";
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btn_search.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.btn_search.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.btn_search.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.btn_search.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_search.Location = new System.Drawing.Point(454, 30);
            this.btn_search.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_search.Name = "btn_search";
            this.btn_search.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btn_search.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.btn_search.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.btn_search.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.btn_search.Size = new System.Drawing.Size(87, 35);
            this.btn_search.Style = Sunny.UI.UIStyle.Green;
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "查詢";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // DeleteReloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 513);
            this.Controls.Add(this.btn_deleteandreload);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_dataset);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "DeleteReloadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteReloadForm";
            this.Load += new System.EventHandler(this.DeleteReloadForm_Load);
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIComboBox cmb_dataset;
        private Sunny.UI.UIDataGridView dgv_dataset;
        private Sunny.UI.UIButton btn_deleteandreload;
        private Sunny.UI.UIButton btn_delete;
        private Sunny.UI.UIButton btn_reload;
        private Sunny.UI.UIButton btn_search;
        private Sunny.UI.UIDatePicker dp_start;
        private Sunny.UI.UIDatePicker dp_end;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine7;
    }
}