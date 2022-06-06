namespace Stock
{
    partial class OrderForm
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
            this.dgv_data = new Sunny.UI.UIDataGridView();
            this.cmb_inCondition = new Sunny.UI.UIComboBox();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.cmb_inType = new Sunny.UI.UIComboBox();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.cmb_lossType = new Sunny.UI.UIComboBox();
            this.cmb_lossCondition = new Sunny.UI.UIComboBox();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.cmb_earnType = new Sunny.UI.UIComboBox();
            this.cmb_earnCondition = new Sunny.UI.UIComboBox();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.cmb_cleanType = new Sunny.UI.UIComboBox();
            this.cmb_cleanCondition = new Sunny.UI.UIComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            this.uiGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.dgv_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_data.BackgroundColor = System.Drawing.Color.White;
            this.dgv_data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_data.EnableHeadersVisualStyles = false;
            this.dgv_data.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.dgv_data.Location = new System.Drawing.Point(12, 94);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgv_data.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_data.RowTemplate.Height = 29;
            this.dgv_data.SelectedIndex = -1;
            this.dgv_data.ShowGridLine = true;
            this.dgv_data.Size = new System.Drawing.Size(921, 344);
            this.dgv_data.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.dgv_data.Style = Sunny.UI.UIStyle.Orange;
            this.dgv_data.TabIndex = 0;
            this.dgv_data.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_CellValueChanged);
            // 
            // cmb_inCondition
            // 
            this.cmb_inCondition.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_inCondition.FillColor = System.Drawing.Color.White;
            this.cmb_inCondition.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_inCondition.Items.AddRange(new object[] {
            "ROD",
            "IOC",
            "FOK"});
            this.cmb_inCondition.Location = new System.Drawing.Point(18, 34);
            this.cmb_inCondition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_inCondition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_inCondition.Name = "cmb_inCondition";
            this.cmb_inCondition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_inCondition.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_inCondition.Size = new System.Drawing.Size(79, 29);
            this.cmb_inCondition.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_inCondition.TabIndex = 2;
            this.cmb_inCondition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.cmb_inType);
            this.uiGroupBox1.Controls.Add(this.cmb_inCondition);
            this.uiGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(13, 11);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiGroupBox1.Size = new System.Drawing.Size(224, 75);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.LightGreen;
            this.uiGroupBox1.TabIndex = 3;
            this.uiGroupBox1.Text = "進場";
            // 
            // cmb_inType
            // 
            this.cmb_inType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_inType.FillColor = System.Drawing.Color.White;
            this.cmb_inType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_inType.Items.AddRange(new object[] {
            "市價",
            "限價"});
            this.cmb_inType.Location = new System.Drawing.Point(124, 34);
            this.cmb_inType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_inType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_inType.Name = "cmb_inType";
            this.cmb_inType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_inType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_inType.Size = new System.Drawing.Size(74, 29);
            this.cmb_inType.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_inType.TabIndex = 3;
            this.cmb_inType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.cmb_lossType);
            this.uiGroupBox2.Controls.Add(this.cmb_lossCondition);
            this.uiGroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(245, 11);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiGroupBox2.Size = new System.Drawing.Size(224, 75);
            this.uiGroupBox2.Style = Sunny.UI.UIStyle.LightGreen;
            this.uiGroupBox2.TabIndex = 4;
            this.uiGroupBox2.Text = "停損";
            // 
            // cmb_lossType
            // 
            this.cmb_lossType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_lossType.FillColor = System.Drawing.Color.White;
            this.cmb_lossType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_lossType.Items.AddRange(new object[] {
            "市價",
            "限價"});
            this.cmb_lossType.Location = new System.Drawing.Point(124, 34);
            this.cmb_lossType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_lossType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_lossType.Name = "cmb_lossType";
            this.cmb_lossType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_lossType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_lossType.Size = new System.Drawing.Size(74, 29);
            this.cmb_lossType.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_lossType.TabIndex = 3;
            this.cmb_lossType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_lossCondition
            // 
            this.cmb_lossCondition.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_lossCondition.FillColor = System.Drawing.Color.White;
            this.cmb_lossCondition.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_lossCondition.Items.AddRange(new object[] {
            "ROD",
            "IOC",
            "FOK"});
            this.cmb_lossCondition.Location = new System.Drawing.Point(18, 34);
            this.cmb_lossCondition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_lossCondition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_lossCondition.Name = "cmb_lossCondition";
            this.cmb_lossCondition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_lossCondition.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_lossCondition.Size = new System.Drawing.Size(79, 29);
            this.cmb_lossCondition.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_lossCondition.TabIndex = 2;
            this.cmb_lossCondition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.cmb_earnType);
            this.uiGroupBox3.Controls.Add(this.cmb_earnCondition);
            this.uiGroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.uiGroupBox3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox3.Location = new System.Drawing.Point(477, 11);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiGroupBox3.Size = new System.Drawing.Size(224, 75);
            this.uiGroupBox3.Style = Sunny.UI.UIStyle.LightGreen;
            this.uiGroupBox3.TabIndex = 5;
            this.uiGroupBox3.Text = "停利";
            // 
            // cmb_earnType
            // 
            this.cmb_earnType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_earnType.FillColor = System.Drawing.Color.White;
            this.cmb_earnType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_earnType.Items.AddRange(new object[] {
            "市價",
            "限價"});
            this.cmb_earnType.Location = new System.Drawing.Point(124, 34);
            this.cmb_earnType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_earnType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_earnType.Name = "cmb_earnType";
            this.cmb_earnType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_earnType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_earnType.Size = new System.Drawing.Size(74, 29);
            this.cmb_earnType.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_earnType.TabIndex = 3;
            this.cmb_earnType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_earnCondition
            // 
            this.cmb_earnCondition.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_earnCondition.FillColor = System.Drawing.Color.White;
            this.cmb_earnCondition.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_earnCondition.Items.AddRange(new object[] {
            "ROD",
            "IOC",
            "FOK"});
            this.cmb_earnCondition.Location = new System.Drawing.Point(18, 34);
            this.cmb_earnCondition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_earnCondition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_earnCondition.Name = "cmb_earnCondition";
            this.cmb_earnCondition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_earnCondition.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_earnCondition.Size = new System.Drawing.Size(79, 29);
            this.cmb_earnCondition.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_earnCondition.TabIndex = 2;
            this.cmb_earnCondition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.cmb_cleanType);
            this.uiGroupBox4.Controls.Add(this.cmb_cleanCondition);
            this.uiGroupBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.uiGroupBox4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox4.Location = new System.Drawing.Point(709, 11);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiGroupBox4.Size = new System.Drawing.Size(224, 75);
            this.uiGroupBox4.Style = Sunny.UI.UIStyle.LightGreen;
            this.uiGroupBox4.TabIndex = 5;
            this.uiGroupBox4.Text = "出清";
            // 
            // cmb_cleanType
            // 
            this.cmb_cleanType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_cleanType.FillColor = System.Drawing.Color.White;
            this.cmb_cleanType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_cleanType.Items.AddRange(new object[] {
            "市價",
            "限價"});
            this.cmb_cleanType.Location = new System.Drawing.Point(124, 34);
            this.cmb_cleanType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_cleanType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_cleanType.Name = "cmb_cleanType";
            this.cmb_cleanType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_cleanType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_cleanType.Size = new System.Drawing.Size(74, 29);
            this.cmb_cleanType.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_cleanType.TabIndex = 3;
            this.cmb_cleanType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_cleanCondition
            // 
            this.cmb_cleanCondition.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_cleanCondition.FillColor = System.Drawing.Color.White;
            this.cmb_cleanCondition.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_cleanCondition.Items.AddRange(new object[] {
            "ROD",
            "IOC",
            "FOK"});
            this.cmb_cleanCondition.Location = new System.Drawing.Point(18, 34);
            this.cmb_cleanCondition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_cleanCondition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_cleanCondition.Name = "cmb_cleanCondition";
            this.cmb_cleanCondition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_cleanCondition.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_cleanCondition.Size = new System.Drawing.Size(79, 29);
            this.cmb_cleanCondition.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_cleanCondition.TabIndex = 2;
            this.cmb_cleanCondition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.uiGroupBox4);
            this.Controls.Add(this.uiGroupBox3);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.dgv_data);
            this.Name = "OrderForm";
            this.Text = "下單系統";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgv_data;
        private Sunny.UI.UIComboBox cmb_inCondition;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIComboBox cmb_inType;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIComboBox cmb_lossType;
        private Sunny.UI.UIComboBox cmb_lossCondition;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UIComboBox cmb_earnType;
        private Sunny.UI.UIComboBox cmb_earnCondition;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private Sunny.UI.UIComboBox cmb_cleanType;
        private Sunny.UI.UIComboBox cmb_cleanCondition;
    }
}