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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_data = new Sunny.UI.UIDataGridView();
            this.cmb_inCondition = new Sunny.UI.UIComboBox();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.cmb_BuySell = new Sunny.UI.UIComboBox();
            this.cmb_inType = new Sunny.UI.UIComboBox();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.txt_lossTickVal = new System.Windows.Forms.TextBox();
            this.txt_lossPerVal = new System.Windows.Forms.TextBox();
            this.rdb_lossTick = new System.Windows.Forms.RadioButton();
            this.rdb_lossPercent = new System.Windows.Forms.RadioButton();
            this.cmb_lossType = new Sunny.UI.UIComboBox();
            this.cmb_lossCondition = new Sunny.UI.UIComboBox();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.txt_earnTickVal = new System.Windows.Forms.TextBox();
            this.txt_earnPerVal = new System.Windows.Forms.TextBox();
            this.rdb_earnTick = new System.Windows.Forms.RadioButton();
            this.rdb_earnPercent = new System.Windows.Forms.RadioButton();
            this.cmb_earnType = new Sunny.UI.UIComboBox();
            this.cmb_earnCondition = new Sunny.UI.UIComboBox();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.cmb_Min = new System.Windows.Forms.ComboBox();
            this.cmb_Hr = new System.Windows.Forms.ComboBox();
            this.cmb_cleanType = new Sunny.UI.UIComboBox();
            this.cmb_cleanCondition = new Sunny.UI.UIComboBox();
            this.lbl_total = new Sunny.UI.UILabel();
            this.btn_out = new Sunny.UI.UIButton();
            this.btn_openExe = new Sunny.UI.UIButton();
            this.rdb_inMin = new Sunny.UI.UIRadioButton();
            this.rdb_inMax = new Sunny.UI.UIRadioButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.rdb_inTick = new Sunny.UI.UIRadioButton();
            this.txt_inTickVal = new System.Windows.Forms.TextBox();
            this.ckb_loss = new Sunny.UI.UICheckBox();
            this.ckb_earn = new Sunny.UI.UICheckBox();
            this.rdb_earnMin = new Sunny.UI.UIRadioButton();
            this.rdb_earnMax = new Sunny.UI.UIRadioButton();
            this.rdb_lossMin = new Sunny.UI.UIRadioButton();
            this.rdb_lossMax = new Sunny.UI.UIRadioButton();
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
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.dgv_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_data.BackgroundColor = System.Drawing.Color.White;
            this.dgv_data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(227)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_data.EnableHeadersVisualStyles = false;
            this.dgv_data.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.dgv_data.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgv_data.Location = new System.Drawing.Point(13, 171);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgv_data.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_data.RowTemplate.Height = 29;
            this.dgv_data.SelectedIndex = -1;
            this.dgv_data.ShowGridLine = true;
            this.dgv_data.Size = new System.Drawing.Size(735, 291);
            this.dgv_data.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.dgv_data.Style = Sunny.UI.UIStyle.Green;
            this.dgv_data.TabIndex = 0;
            this.dgv_data.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_CellValueChanged);
            // 
            // cmb_inCondition
            // 
            this.cmb_inCondition.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_inCondition.FillColor = System.Drawing.Color.White;
            this.cmb_inCondition.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cmb_inCondition.Items.AddRange(new object[] {
            "ROD",
            "IOC",
            "FOK"});
            this.cmb_inCondition.Location = new System.Drawing.Point(9, 74);
            this.cmb_inCondition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_inCondition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_inCondition.Name = "cmb_inCondition";
            this.cmb_inCondition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_inCondition.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_inCondition.Size = new System.Drawing.Size(63, 25);
            this.cmb_inCondition.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_inCondition.TabIndex = 2;
            this.cmb_inCondition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.txt_inTickVal);
            this.uiGroupBox1.Controls.Add(this.rdb_inTick);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.rdb_inMin);
            this.uiGroupBox1.Controls.Add(this.cmb_BuySell);
            this.uiGroupBox1.Controls.Add(this.rdb_inMax);
            this.uiGroupBox1.Controls.Add(this.cmb_inType);
            this.uiGroupBox1.Controls.Add(this.cmb_inCondition);
            this.uiGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.uiGroupBox1.Location = new System.Drawing.Point(13, 11);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiGroupBox1.Size = new System.Drawing.Size(199, 152);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.LightGreen;
            this.uiGroupBox1.TabIndex = 3;
            this.uiGroupBox1.Text = "進場";
            // 
            // cmb_BuySell
            // 
            this.cmb_BuySell.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_BuySell.FillColor = System.Drawing.Color.White;
            this.cmb_BuySell.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cmb_BuySell.Items.AddRange(new object[] {
            "買",
            "賣"});
            this.cmb_BuySell.Location = new System.Drawing.Point(9, 35);
            this.cmb_BuySell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_BuySell.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_BuySell.Name = "cmb_BuySell";
            this.cmb_BuySell.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_BuySell.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_BuySell.Size = new System.Drawing.Size(63, 25);
            this.cmb_BuySell.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_BuySell.TabIndex = 3;
            this.cmb_BuySell.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_inType
            // 
            this.cmb_inType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_inType.FillColor = System.Drawing.Color.White;
            this.cmb_inType.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cmb_inType.Items.AddRange(new object[] {
            "市價",
            "限價"});
            this.cmb_inType.Location = new System.Drawing.Point(9, 113);
            this.cmb_inType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_inType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_inType.Name = "cmb_inType";
            this.cmb_inType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_inType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_inType.Size = new System.Drawing.Size(63, 25);
            this.cmb_inType.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_inType.TabIndex = 3;
            this.cmb_inType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.rdb_lossMin);
            this.uiGroupBox2.Controls.Add(this.rdb_lossMax);
            this.uiGroupBox2.Controls.Add(this.txt_lossTickVal);
            this.uiGroupBox2.Controls.Add(this.ckb_loss);
            this.uiGroupBox2.Controls.Add(this.txt_lossPerVal);
            this.uiGroupBox2.Controls.Add(this.rdb_lossTick);
            this.uiGroupBox2.Controls.Add(this.rdb_lossPercent);
            this.uiGroupBox2.Controls.Add(this.cmb_lossType);
            this.uiGroupBox2.Controls.Add(this.cmb_lossCondition);
            this.uiGroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.uiGroupBox2.Location = new System.Drawing.Point(219, 14);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiGroupBox2.Size = new System.Drawing.Size(199, 149);
            this.uiGroupBox2.Style = Sunny.UI.UIStyle.LightGreen;
            this.uiGroupBox2.TabIndex = 4;
            this.uiGroupBox2.Text = "停損";
            // 
            // txt_lossTickVal
            // 
            this.txt_lossTickVal.Location = new System.Drawing.Point(136, 67);
            this.txt_lossTickVal.Name = "txt_lossTickVal";
            this.txt_lossTickVal.Size = new System.Drawing.Size(50, 25);
            this.txt_lossTickVal.TabIndex = 9;
            this.txt_lossTickVal.Text = "5";
            this.txt_lossTickVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_lossPerVal
            // 
            this.txt_lossPerVal.Location = new System.Drawing.Point(136, 33);
            this.txt_lossPerVal.Name = "txt_lossPerVal";
            this.txt_lossPerVal.Size = new System.Drawing.Size(50, 25);
            this.txt_lossPerVal.TabIndex = 8;
            this.txt_lossPerVal.Text = "8";
            this.txt_lossPerVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdb_lossTick
            // 
            this.rdb_lossTick.AutoSize = true;
            this.rdb_lossTick.Checked = true;
            this.rdb_lossTick.Location = new System.Drawing.Point(76, 68);
            this.rdb_lossTick.Name = "rdb_lossTick";
            this.rdb_lossTick.Size = new System.Drawing.Size(51, 24);
            this.rdb_lossTick.TabIndex = 7;
            this.rdb_lossTick.TabStop = true;
            this.rdb_lossTick.Text = "tick";
            this.rdb_lossTick.UseVisualStyleBackColor = true;
            // 
            // rdb_lossPercent
            // 
            this.rdb_lossPercent.AutoSize = true;
            this.rdb_lossPercent.Location = new System.Drawing.Point(78, 34);
            this.rdb_lossPercent.Name = "rdb_lossPercent";
            this.rdb_lossPercent.Size = new System.Drawing.Size(39, 24);
            this.rdb_lossPercent.TabIndex = 6;
            this.rdb_lossPercent.Text = "%";
            this.rdb_lossPercent.UseVisualStyleBackColor = true;
            // 
            // cmb_lossType
            // 
            this.cmb_lossType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_lossType.FillColor = System.Drawing.Color.White;
            this.cmb_lossType.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cmb_lossType.Items.AddRange(new object[] {
            "市價",
            "限價"});
            this.cmb_lossType.Location = new System.Drawing.Point(9, 104);
            this.cmb_lossType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_lossType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_lossType.Name = "cmb_lossType";
            this.cmb_lossType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_lossType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_lossType.Size = new System.Drawing.Size(63, 25);
            this.cmb_lossType.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_lossType.TabIndex = 3;
            this.cmb_lossType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_lossCondition
            // 
            this.cmb_lossCondition.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_lossCondition.FillColor = System.Drawing.Color.White;
            this.cmb_lossCondition.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cmb_lossCondition.Items.AddRange(new object[] {
            "ROD",
            "IOC",
            "FOK"});
            this.cmb_lossCondition.Location = new System.Drawing.Point(9, 70);
            this.cmb_lossCondition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_lossCondition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_lossCondition.Name = "cmb_lossCondition";
            this.cmb_lossCondition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_lossCondition.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_lossCondition.Size = new System.Drawing.Size(63, 25);
            this.cmb_lossCondition.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_lossCondition.TabIndex = 2;
            this.cmb_lossCondition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.rdb_earnMin);
            this.uiGroupBox3.Controls.Add(this.rdb_earnMax);
            this.uiGroupBox3.Controls.Add(this.ckb_earn);
            this.uiGroupBox3.Controls.Add(this.txt_earnTickVal);
            this.uiGroupBox3.Controls.Add(this.txt_earnPerVal);
            this.uiGroupBox3.Controls.Add(this.rdb_earnTick);
            this.uiGroupBox3.Controls.Add(this.rdb_earnPercent);
            this.uiGroupBox3.Controls.Add(this.cmb_earnType);
            this.uiGroupBox3.Controls.Add(this.cmb_earnCondition);
            this.uiGroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.uiGroupBox3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.uiGroupBox3.Location = new System.Drawing.Point(426, 14);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiGroupBox3.Size = new System.Drawing.Size(199, 149);
            this.uiGroupBox3.Style = Sunny.UI.UIStyle.LightGreen;
            this.uiGroupBox3.TabIndex = 5;
            this.uiGroupBox3.Text = "停利";
            // 
            // txt_earnTickVal
            // 
            this.txt_earnTickVal.Location = new System.Drawing.Point(137, 64);
            this.txt_earnTickVal.Name = "txt_earnTickVal";
            this.txt_earnTickVal.Size = new System.Drawing.Size(50, 25);
            this.txt_earnTickVal.TabIndex = 11;
            this.txt_earnTickVal.Text = "0";
            this.txt_earnTickVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_earnPerVal
            // 
            this.txt_earnPerVal.Location = new System.Drawing.Point(137, 33);
            this.txt_earnPerVal.Name = "txt_earnPerVal";
            this.txt_earnPerVal.Size = new System.Drawing.Size(50, 25);
            this.txt_earnPerVal.TabIndex = 10;
            this.txt_earnPerVal.Text = "8";
            this.txt_earnPerVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdb_earnTick
            // 
            this.rdb_earnTick.AutoSize = true;
            this.rdb_earnTick.Checked = true;
            this.rdb_earnTick.Location = new System.Drawing.Point(77, 67);
            this.rdb_earnTick.Name = "rdb_earnTick";
            this.rdb_earnTick.Size = new System.Drawing.Size(51, 24);
            this.rdb_earnTick.TabIndex = 5;
            this.rdb_earnTick.TabStop = true;
            this.rdb_earnTick.Text = "tick";
            this.rdb_earnTick.UseVisualStyleBackColor = true;
            // 
            // rdb_earnPercent
            // 
            this.rdb_earnPercent.AutoSize = true;
            this.rdb_earnPercent.Location = new System.Drawing.Point(79, 33);
            this.rdb_earnPercent.Name = "rdb_earnPercent";
            this.rdb_earnPercent.Size = new System.Drawing.Size(39, 24);
            this.rdb_earnPercent.TabIndex = 4;
            this.rdb_earnPercent.Text = "%";
            this.rdb_earnPercent.UseVisualStyleBackColor = true;
            // 
            // cmb_earnType
            // 
            this.cmb_earnType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_earnType.FillColor = System.Drawing.Color.White;
            this.cmb_earnType.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cmb_earnType.Items.AddRange(new object[] {
            "市價",
            "限價"});
            this.cmb_earnType.Location = new System.Drawing.Point(7, 104);
            this.cmb_earnType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_earnType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_earnType.Name = "cmb_earnType";
            this.cmb_earnType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_earnType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_earnType.Size = new System.Drawing.Size(63, 25);
            this.cmb_earnType.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_earnType.TabIndex = 3;
            this.cmb_earnType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_earnCondition
            // 
            this.cmb_earnCondition.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_earnCondition.FillColor = System.Drawing.Color.White;
            this.cmb_earnCondition.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cmb_earnCondition.Items.AddRange(new object[] {
            "ROD",
            "IOC",
            "FOK"});
            this.cmb_earnCondition.Location = new System.Drawing.Point(7, 70);
            this.cmb_earnCondition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_earnCondition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_earnCondition.Name = "cmb_earnCondition";
            this.cmb_earnCondition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_earnCondition.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_earnCondition.Size = new System.Drawing.Size(63, 25);
            this.cmb_earnCondition.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_earnCondition.TabIndex = 2;
            this.cmb_earnCondition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.cmb_Min);
            this.uiGroupBox4.Controls.Add(this.cmb_Hr);
            this.uiGroupBox4.Controls.Add(this.cmb_cleanType);
            this.uiGroupBox4.Controls.Add(this.cmb_cleanCondition);
            this.uiGroupBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.uiGroupBox4.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.uiGroupBox4.Location = new System.Drawing.Point(633, 14);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiGroupBox4.Size = new System.Drawing.Size(115, 149);
            this.uiGroupBox4.Style = Sunny.UI.UIStyle.LightGreen;
            this.uiGroupBox4.TabIndex = 5;
            this.uiGroupBox4.Text = "出清";
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
            this.cmb_Min.Location = new System.Drawing.Point(55, 102);
            this.cmb_Min.Name = "cmb_Min";
            this.cmb_Min.Size = new System.Drawing.Size(47, 27);
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
            this.cmb_Hr.Location = new System.Drawing.Point(11, 102);
            this.cmb_Hr.Name = "cmb_Hr";
            this.cmb_Hr.Size = new System.Drawing.Size(40, 27);
            this.cmb_Hr.TabIndex = 38;
            this.cmb_Hr.Text = "13";
            // 
            // cmb_cleanType
            // 
            this.cmb_cleanType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_cleanType.FillColor = System.Drawing.Color.White;
            this.cmb_cleanType.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cmb_cleanType.Items.AddRange(new object[] {
            "市價",
            "限價"});
            this.cmb_cleanType.Location = new System.Drawing.Point(22, 69);
            this.cmb_cleanType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_cleanType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_cleanType.Name = "cmb_cleanType";
            this.cmb_cleanType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_cleanType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.cmb_cleanType.Size = new System.Drawing.Size(63, 25);
            this.cmb_cleanType.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_cleanType.TabIndex = 3;
            this.cmb_cleanType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_cleanCondition
            // 
            this.cmb_cleanCondition.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_cleanCondition.FillColor = System.Drawing.Color.White;
            this.cmb_cleanCondition.Font = new System.Drawing.Font("微软雅黑", 10F);
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
            this.cmb_cleanCondition.Size = new System.Drawing.Size(63, 25);
            this.cmb_cleanCondition.Style = Sunny.UI.UIStyle.LightGreen;
            this.cmb_cleanCondition.TabIndex = 2;
            this.cmb_cleanCondition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_total
            // 
            this.lbl_total.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_total.Location = new System.Drawing.Point(13, 465);
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
            this.btn_out.Location = new System.Drawing.Point(542, 471);
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
            this.btn_openExe.Location = new System.Drawing.Point(648, 471);
            this.btn_openExe.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_openExe.Name = "btn_openExe";
            this.btn_openExe.Size = new System.Drawing.Size(100, 35);
            this.btn_openExe.TabIndex = 8;
            this.btn_openExe.Text = "下單系統";
            this.btn_openExe.Click += new System.EventHandler(this.btn_openExe_Click);
            // 
            // rdb_inMin
            // 
            this.rdb_inMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_inMin.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.rdb_inMin.Location = new System.Drawing.Point(84, 82);
            this.rdb_inMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_inMin.Name = "rdb_inMin";
            this.rdb_inMin.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_inMin.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.rdb_inMin.Size = new System.Drawing.Size(56, 29);
            this.rdb_inMin.Style = Sunny.UI.UIStyle.LightGreen;
            this.rdb_inMin.TabIndex = 13;
            this.rdb_inMin.Text = "跌停";
            // 
            // rdb_inMax
            // 
            this.rdb_inMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_inMax.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.rdb_inMax.Location = new System.Drawing.Point(84, 50);
            this.rdb_inMax.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_inMax.Name = "rdb_inMax";
            this.rdb_inMax.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_inMax.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.rdb_inMax.Size = new System.Drawing.Size(56, 29);
            this.rdb_inMax.Style = Sunny.UI.UIStyle.LightGreen;
            this.rdb_inMax.TabIndex = 12;
            this.rdb_inMax.Text = "漲停";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.uiLabel2.Location = new System.Drawing.Point(88, 20);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(52, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.LightGreen;
            this.uiLabel2.TabIndex = 14;
            this.uiLabel2.Text = "限價▼";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdb_inTick
            // 
            this.rdb_inTick.Checked = true;
            this.rdb_inTick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_inTick.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.rdb_inTick.Location = new System.Drawing.Point(84, 113);
            this.rdb_inTick.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_inTick.Name = "rdb_inTick";
            this.rdb_inTick.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_inTick.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.rdb_inTick.Size = new System.Drawing.Size(56, 29);
            this.rdb_inTick.Style = Sunny.UI.UIStyle.LightGreen;
            this.rdb_inTick.TabIndex = 15;
            this.rdb_inTick.Text = "tick";
            // 
            // txt_inTickVal
            // 
            this.txt_inTickVal.Location = new System.Drawing.Point(140, 114);
            this.txt_inTickVal.Name = "txt_inTickVal";
            this.txt_inTickVal.Size = new System.Drawing.Size(50, 25);
            this.txt_inTickVal.TabIndex = 10;
            this.txt_inTickVal.Text = "-3";
            this.txt_inTickVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckb_loss
            // 
            this.ckb_loss.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.ckb_loss.Checked = true;
            this.ckb_loss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckb_loss.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ckb_loss.Location = new System.Drawing.Point(9, 33);
            this.ckb_loss.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckb_loss.Name = "ckb_loss";
            this.ckb_loss.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ckb_loss.Size = new System.Drawing.Size(63, 29);
            this.ckb_loss.Style = Sunny.UI.UIStyle.LightGreen;
            this.ckb_loss.TabIndex = 9;
            this.ckb_loss.Text = "停損";
            // 
            // ckb_earn
            // 
            this.ckb_earn.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.ckb_earn.Checked = true;
            this.ckb_earn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckb_earn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ckb_earn.Location = new System.Drawing.Point(7, 34);
            this.ckb_earn.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckb_earn.Name = "ckb_earn";
            this.ckb_earn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ckb_earn.Size = new System.Drawing.Size(63, 29);
            this.ckb_earn.Style = Sunny.UI.UIStyle.LightGreen;
            this.ckb_earn.TabIndex = 10;
            this.ckb_earn.Text = "停利";
            // 
            // rdb_earnMin
            // 
            this.rdb_earnMin.Checked = true;
            this.rdb_earnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_earnMin.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.rdb_earnMin.Location = new System.Drawing.Point(133, 100);
            this.rdb_earnMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_earnMin.Name = "rdb_earnMin";
            this.rdb_earnMin.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_earnMin.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.rdb_earnMin.Size = new System.Drawing.Size(56, 29);
            this.rdb_earnMin.Style = Sunny.UI.UIStyle.LightGreen;
            this.rdb_earnMin.TabIndex = 15;
            this.rdb_earnMin.Text = "跌停";
            // 
            // rdb_earnMax
            // 
            this.rdb_earnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_earnMax.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.rdb_earnMax.Location = new System.Drawing.Point(74, 100);
            this.rdb_earnMax.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_earnMax.Name = "rdb_earnMax";
            this.rdb_earnMax.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_earnMax.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.rdb_earnMax.Size = new System.Drawing.Size(56, 29);
            this.rdb_earnMax.Style = Sunny.UI.UIStyle.LightGreen;
            this.rdb_earnMax.TabIndex = 14;
            this.rdb_earnMax.Text = "漲停";
            // 
            // rdb_lossMin
            // 
            this.rdb_lossMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_lossMin.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.rdb_lossMin.Location = new System.Drawing.Point(133, 100);
            this.rdb_lossMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_lossMin.Name = "rdb_lossMin";
            this.rdb_lossMin.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_lossMin.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.rdb_lossMin.Size = new System.Drawing.Size(56, 29);
            this.rdb_lossMin.Style = Sunny.UI.UIStyle.LightGreen;
            this.rdb_lossMin.TabIndex = 17;
            this.rdb_lossMin.Text = "跌停";
            // 
            // rdb_lossMax
            // 
            this.rdb_lossMax.Checked = true;
            this.rdb_lossMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_lossMax.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.rdb_lossMax.Location = new System.Drawing.Point(74, 100);
            this.rdb_lossMax.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_lossMax.Name = "rdb_lossMax";
            this.rdb_lossMax.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_lossMax.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.rdb_lossMax.Size = new System.Drawing.Size(56, 29);
            this.rdb_lossMax.Style = Sunny.UI.UIStyle.LightGreen;
            this.rdb_lossMax.TabIndex = 16;
            this.rdb_lossMax.Text = "漲停";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 518);
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
            this.uiGroupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_lossTickVal;
        private System.Windows.Forms.TextBox txt_lossPerVal;
        private System.Windows.Forms.TextBox txt_earnTickVal;
        private System.Windows.Forms.TextBox txt_earnPerVal;
        private Sunny.UI.UILabel lbl_total;
        private Sunny.UI.UIButton btn_out;
        private Sunny.UI.UIButton btn_openExe;
        private System.Windows.Forms.ComboBox cmb_Min;
        private System.Windows.Forms.ComboBox cmb_Hr;
        private Sunny.UI.UIComboBox cmb_BuySell;
        private System.Windows.Forms.TextBox txt_inTickVal;
        private Sunny.UI.UIRadioButton rdb_inTick;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIRadioButton rdb_inMin;
        private Sunny.UI.UIRadioButton rdb_inMax;
        private Sunny.UI.UICheckBox ckb_loss;
        private Sunny.UI.UICheckBox ckb_earn;
        private Sunny.UI.UIRadioButton rdb_lossMin;
        private Sunny.UI.UIRadioButton rdb_lossMax;
        private Sunny.UI.UIRadioButton rdb_earnMin;
        private Sunny.UI.UIRadioButton rdb_earnMax;
    }
}