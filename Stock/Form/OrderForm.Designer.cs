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
            this.rdb_earnPercent = new System.Windows.Forms.RadioButton();
            this.rdb_earnTick = new System.Windows.Forms.RadioButton();
            this.rdb_lossTick = new System.Windows.Forms.RadioButton();
            this.rdb_lossPercent = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_total = new Sunny.UI.UILabel();
            this.btn_out = new Sunny.UI.UIButton();
            this.btn_openExe = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cmb_Min = new System.Windows.Forms.ComboBox();
            this.cmb_Hr = new System.Windows.Forms.ComboBox();
            this.cmb_BuySell = new Sunny.UI.UIComboBox();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.dgv_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_data.BackgroundColor = System.Drawing.Color.White;
            this.dgv_data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(227)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_data.EnableHeadersVisualStyles = false;
            this.dgv_data.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.dgv_data.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgv_data.Location = new System.Drawing.Point(219, 11);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgv_data.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_data.RowTemplate.Height = 29;
            this.dgv_data.SelectedIndex = -1;
            this.dgv_data.ShowGridLine = true;
            this.dgv_data.Size = new System.Drawing.Size(525, 376);
            this.dgv_data.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.dgv_data.Style = Sunny.UI.UIStyle.Green;
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
            this.cmb_inCondition.Location = new System.Drawing.Point(68, 34);
            this.cmb_inCondition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_inCondition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_inCondition.Name = "cmb_inCondition";
            this.cmb_inCondition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_inCondition.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_inCondition.Size = new System.Drawing.Size(63, 29);
            this.cmb_inCondition.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_inCondition.TabIndex = 2;
            this.cmb_inCondition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.cmb_BuySell);
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
            this.uiGroupBox1.Size = new System.Drawing.Size(199, 75);
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
            this.cmb_inType.Location = new System.Drawing.Point(133, 34);
            this.cmb_inType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_inType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_inType.Name = "cmb_inType";
            this.cmb_inType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_inType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_inType.Size = new System.Drawing.Size(63, 29);
            this.cmb_inType.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_inType.TabIndex = 3;
            this.cmb_inType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.textBox2);
            this.uiGroupBox2.Controls.Add(this.textBox1);
            this.uiGroupBox2.Controls.Add(this.rdb_lossTick);
            this.uiGroupBox2.Controls.Add(this.rdb_lossPercent);
            this.uiGroupBox2.Controls.Add(this.cmb_lossType);
            this.uiGroupBox2.Controls.Add(this.cmb_lossCondition);
            this.uiGroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(13, 96);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiGroupBox2.Size = new System.Drawing.Size(199, 100);
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
            this.cmb_lossType.Location = new System.Drawing.Point(8, 62);
            this.cmb_lossType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_lossType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_lossType.Name = "cmb_lossType";
            this.cmb_lossType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_lossType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_lossType.Size = new System.Drawing.Size(63, 29);
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
            this.cmb_lossCondition.Location = new System.Drawing.Point(8, 30);
            this.cmb_lossCondition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_lossCondition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_lossCondition.Name = "cmb_lossCondition";
            this.cmb_lossCondition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_lossCondition.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_lossCondition.Size = new System.Drawing.Size(63, 29);
            this.cmb_lossCondition.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_lossCondition.TabIndex = 2;
            this.cmb_lossCondition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.textBox3);
            this.uiGroupBox3.Controls.Add(this.textBox4);
            this.uiGroupBox3.Controls.Add(this.rdb_earnTick);
            this.uiGroupBox3.Controls.Add(this.rdb_earnPercent);
            this.uiGroupBox3.Controls.Add(this.cmb_earnType);
            this.uiGroupBox3.Controls.Add(this.cmb_earnCondition);
            this.uiGroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.uiGroupBox3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox3.Location = new System.Drawing.Point(13, 206);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiGroupBox3.Size = new System.Drawing.Size(199, 100);
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
            this.cmb_earnType.Location = new System.Drawing.Point(9, 63);
            this.cmb_earnType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_earnType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_earnType.Name = "cmb_earnType";
            this.cmb_earnType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_earnType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_earnType.Size = new System.Drawing.Size(63, 29);
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
            this.cmb_earnCondition.Location = new System.Drawing.Point(9, 29);
            this.cmb_earnCondition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_earnCondition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_earnCondition.Name = "cmb_earnCondition";
            this.cmb_earnCondition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_earnCondition.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_earnCondition.Size = new System.Drawing.Size(63, 29);
            this.cmb_earnCondition.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_earnCondition.TabIndex = 2;
            this.cmb_earnCondition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.cmb_Min);
            this.uiGroupBox4.Controls.Add(this.cmb_Hr);
            this.uiGroupBox4.Controls.Add(this.uiLabel1);
            this.uiGroupBox4.Controls.Add(this.cmb_cleanType);
            this.uiGroupBox4.Controls.Add(this.cmb_cleanCondition);
            this.uiGroupBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.uiGroupBox4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox4.Location = new System.Drawing.Point(13, 316);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiGroupBox4.Size = new System.Drawing.Size(199, 115);
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
            this.cmb_cleanType.Location = new System.Drawing.Point(113, 34);
            this.cmb_cleanType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_cleanType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_cleanType.Name = "cmb_cleanType";
            this.cmb_cleanType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_cleanType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_cleanType.Size = new System.Drawing.Size(63, 29);
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
            this.cmb_cleanCondition.Location = new System.Drawing.Point(22, 34);
            this.cmb_cleanCondition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_cleanCondition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_cleanCondition.Name = "cmb_cleanCondition";
            this.cmb_cleanCondition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_cleanCondition.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_cleanCondition.Size = new System.Drawing.Size(63, 29);
            this.cmb_cleanCondition.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_cleanCondition.TabIndex = 2;
            this.cmb_cleanCondition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdb_earnPercent
            // 
            this.rdb_earnPercent.AutoSize = true;
            this.rdb_earnPercent.Checked = true;
            this.rdb_earnPercent.Location = new System.Drawing.Point(79, 29);
            this.rdb_earnPercent.Name = "rdb_earnPercent";
            this.rdb_earnPercent.Size = new System.Drawing.Size(42, 25);
            this.rdb_earnPercent.TabIndex = 4;
            this.rdb_earnPercent.TabStop = true;
            this.rdb_earnPercent.Text = "%";
            this.rdb_earnPercent.UseVisualStyleBackColor = true;
            // 
            // rdb_earnTick
            // 
            this.rdb_earnTick.AutoSize = true;
            this.rdb_earnTick.Location = new System.Drawing.Point(77, 63);
            this.rdb_earnTick.Name = "rdb_earnTick";
            this.rdb_earnTick.Size = new System.Drawing.Size(55, 25);
            this.rdb_earnTick.TabIndex = 5;
            this.rdb_earnTick.Text = "tick";
            this.rdb_earnTick.UseVisualStyleBackColor = true;
            // 
            // rdb_lossTick
            // 
            this.rdb_lossTick.AutoSize = true;
            this.rdb_lossTick.Checked = true;
            this.rdb_lossTick.Location = new System.Drawing.Point(77, 64);
            this.rdb_lossTick.Name = "rdb_lossTick";
            this.rdb_lossTick.Size = new System.Drawing.Size(55, 25);
            this.rdb_lossTick.TabIndex = 7;
            this.rdb_lossTick.TabStop = true;
            this.rdb_lossTick.Text = "tick";
            this.rdb_lossTick.UseVisualStyleBackColor = true;
            // 
            // rdb_lossPercent
            // 
            this.rdb_lossPercent.AutoSize = true;
            this.rdb_lossPercent.Location = new System.Drawing.Point(79, 30);
            this.rdb_lossPercent.Name = "rdb_lossPercent";
            this.rdb_lossPercent.Size = new System.Drawing.Size(42, 25);
            this.rdb_lossPercent.TabIndex = 6;
            this.rdb_lossPercent.Text = "%";
            this.rdb_lossPercent.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 29);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "8";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 29);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "5";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 29);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(137, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(50, 29);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "8";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_total
            // 
            this.lbl_total.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_total.Location = new System.Drawing.Point(219, 390);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(248, 41);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "下單價格總和 :";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_out
            // 
            this.btn_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_out.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_out.Location = new System.Drawing.Point(538, 396);
            this.btn_out.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(100, 35);
            this.btn_out.TabIndex = 7;
            this.btn_out.Text = "匯出";
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // btn_openExe
            // 
            this.btn_openExe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_openExe.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_openExe.Location = new System.Drawing.Point(644, 396);
            this.btn_openExe.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_openExe.Name = "btn_openExe";
            this.btn_openExe.Size = new System.Drawing.Size(100, 35);
            this.btn_openExe.TabIndex = 8;
            this.btn_openExe.Text = "下單系統";
            this.btn_openExe.Click += new System.EventHandler(this.btn_openExe_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(23, 68);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(53, 41);
            this.uiLabel1.Style = Sunny.UI.UIStyle.LightGreen;
            this.uiLabel1.TabIndex = 7;
            this.uiLabel1.Text = "時間:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Min
            // 
            this.cmb_Min.FormattingEnabled = true;
            this.cmb_Min.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmb_Min.Location = new System.Drawing.Point(129, 75);
            this.cmb_Min.Name = "cmb_Min";
            this.cmb_Min.Size = new System.Drawing.Size(47, 29);
            this.cmb_Min.TabIndex = 39;
            this.cmb_Min.Text = "23";
            // 
            // cmb_Hr
            // 
            this.cmb_Hr.FormattingEnabled = true;
            this.cmb_Hr.Items.AddRange(new object[] {
            "09",
            "10",
            "11",
            "12",
            "13"});
            this.cmb_Hr.Location = new System.Drawing.Point(85, 75);
            this.cmb_Hr.Name = "cmb_Hr";
            this.cmb_Hr.Size = new System.Drawing.Size(40, 29);
            this.cmb_Hr.TabIndex = 38;
            this.cmb_Hr.Text = "13";
            // 
            // cmb_BuySell
            // 
            this.cmb_BuySell.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_BuySell.FillColor = System.Drawing.Color.White;
            this.cmb_BuySell.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_BuySell.Items.AddRange(new object[] {
            "買",
            "賣"});
            this.cmb_BuySell.Location = new System.Drawing.Point(4, 34);
            this.cmb_BuySell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_BuySell.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_BuySell.Name = "cmb_BuySell";
            this.cmb_BuySell.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_BuySell.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_BuySell.Size = new System.Drawing.Size(63, 29);
            this.cmb_BuySell.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_BuySell.TabIndex = 3;
            this.cmb_BuySell.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 445);
            this.Controls.Add(this.btn_openExe);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.lbl_total);
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
            this.uiGroupBox2.PerformLayout();
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox3.PerformLayout();
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
        private System.Windows.Forms.RadioButton rdb_earnTick;
        private System.Windows.Forms.RadioButton rdb_earnPercent;
        private System.Windows.Forms.RadioButton rdb_lossTick;
        private System.Windows.Forms.RadioButton rdb_lossPercent;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private Sunny.UI.UILabel lbl_total;
        private Sunny.UI.UIButton btn_out;
        private Sunny.UI.UIButton btn_openExe;
        private System.Windows.Forms.ComboBox cmb_Min;
        private System.Windows.Forms.ComboBox cmb_Hr;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cmb_BuySell;
    }
}