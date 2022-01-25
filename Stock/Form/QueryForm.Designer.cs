namespace Stock
{
    partial class QueryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_data = new Sunny.UI.UIDataGridView();
            this.btn_add = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txt_date = new Sunny.UI.UITextBox();
            this.txt_companyId = new Sunny.UI.UITextBox();
            this.Lbox_cmd = new System.Windows.Forms.ListBox();
            this.lb_status = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_data
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_data.BackgroundColor = System.Drawing.Color.White;
            this.dgv_data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.EnableHeadersVisualStyles = false;
            this.dgv_data.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_data.Location = new System.Drawing.Point(12, 111);
            this.dgv_data.Name = "dgv_data";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgv_data.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_data.RowTemplate.Height = 29;
            this.dgv_data.SelectedIndex = -1;
            this.dgv_data.ShowGridLine = true;
            this.dgv_data.Size = new System.Drawing.Size(754, 450);
            this.dgv_data.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_add.Location = new System.Drawing.Point(692, 12);
            this.btn_add.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(74, 93);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "新增";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(492, 12);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(43, 23);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "日期";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(490, 47);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(75, 23);
            this.uiLabel2.TabIndex = 5;
            this.uiLabel2.Text = "公司編號";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_date
            // 
            this.txt_date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_date.FillColor = System.Drawing.Color.White;
            this.txt_date.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_date.Location = new System.Drawing.Point(540, 11);
            this.txt_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_date.Maximum = 2147483647D;
            this.txt_date.Minimum = -2147483648D;
            this.txt_date.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_date.Name = "txt_date";
            this.txt_date.Padding = new System.Windows.Forms.Padding(5);
            this.txt_date.Size = new System.Drawing.Size(130, 29);
            this.txt_date.TabIndex = 6;
            this.txt_date.Text = "uiTextBox1";
            // 
            // txt_companyId
            // 
            this.txt_companyId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_companyId.FillColor = System.Drawing.Color.White;
            this.txt_companyId.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_companyId.Location = new System.Drawing.Point(565, 45);
            this.txt_companyId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_companyId.Maximum = 2147483647D;
            this.txt_companyId.Minimum = -2147483648D;
            this.txt_companyId.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_companyId.Name = "txt_companyId";
            this.txt_companyId.Padding = new System.Windows.Forms.Padding(5);
            this.txt_companyId.Size = new System.Drawing.Size(105, 29);
            this.txt_companyId.TabIndex = 7;
            // 
            // Lbox_cmd
            // 
            this.Lbox_cmd.Font = new System.Drawing.Font("新細明體", 11F);
            this.Lbox_cmd.FormattingEnabled = true;
            this.Lbox_cmd.ItemHeight = 15;
            this.Lbox_cmd.Location = new System.Drawing.Point(12, 11);
            this.Lbox_cmd.Name = "Lbox_cmd";
            this.Lbox_cmd.Size = new System.Drawing.Size(472, 94);
            this.Lbox_cmd.TabIndex = 2;
            this.Lbox_cmd.Click += new System.EventHandler(this.Lbox_cmd_Click);
            this.Lbox_cmd.DoubleClick += new System.EventHandler(this.Lbox_cmd_DoubleClick);
            // 
            // lb_status
            // 
            this.lb_status.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lb_status.Location = new System.Drawing.Point(492, 79);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(113, 23);
            this.lb_status.TabIndex = 8;
            this.lb_status.Text = "查詢狀態";
            this.lb_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 573);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.Lbox_cmd);
            this.Controls.Add(this.txt_companyId);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_data);
            this.Name = "QueryForm";
            this.Text = "資料庫查詢";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgv_data;
        private Sunny.UI.UIButton btn_add;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txt_date;
        private Sunny.UI.UITextBox txt_companyId;
        private System.Windows.Forms.ListBox Lbox_cmd;
        private Sunny.UI.UILabel lb_status;
    }
}