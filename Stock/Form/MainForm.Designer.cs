namespace Stock
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.capitalDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smartPickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DonateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setIniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_result = new Sunny.UI.UIDataGridView();
            this.tabC_Strategy = new Sunny.UI.UITabControlMenu();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_c2 = new Sunny.UI.UITextBox();
            this.txt_c1 = new Sunny.UI.UITextBox();
            this.rdb_between = new Sunny.UI.UIRadioButton();
            this.ckcb_daytrade = new System.Windows.Forms.CheckBox();
            this.uiLine6 = new Sunny.UI.UILine();
            this.ud_testDays = new Sunny.UI.UIIntegerUpDown();
            this.uiLine4 = new Sunny.UI.UILine();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLine3 = new Sunny.UI.UILine();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiLine1 = new Sunny.UI.UILine();
            this.ud_avgDays = new Sunny.UI.UIIntegerUpDown();
            this.ud_pickquantity = new Sunny.UI.UIIntegerUpDown();
            this.UpDown_closePrice = new Sunny.UI.UIIntegerUpDown();
            this.rdb_bigger = new Sunny.UI.UIRadioButton();
            this.rdb_smaller = new Sunny.UI.UIRadioButton();
            this.rdb_ultimate = new Sunny.UI.UIRadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiRadioButtonGroup13 = new Sunny.UI.UIRadioButtonGroup();
            this.rdb_TClose = new Sunny.UI.UIRadioButton();
            this.rdb_THigh = new Sunny.UI.UIRadioButton();
            this.uiRadioButtonGroup6 = new Sunny.UI.UIRadioButtonGroup();
            this.rdb_highReal = new Sunny.UI.UIRadioButton();
            this.rdb_highVirtual = new Sunny.UI.UIRadioButton();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiRadioButtonGroup4 = new Sunny.UI.UIRadioButtonGroup();
            this.rdb_s1HighNone = new Sunny.UI.UIRadioButton();
            this.rdb_s1HighYes = new Sunny.UI.UIRadioButton();
            this.rdb_s1HighNo = new Sunny.UI.UIRadioButton();
            this.uiRadioButtonGroup3 = new Sunny.UI.UIRadioButtonGroup();
            this.rdb_s1MajorNone = new Sunny.UI.UIRadioButton();
            this.rdb_s1MajorBuy = new Sunny.UI.UIRadioButton();
            this.rdb_s1MajorSell = new Sunny.UI.UIRadioButton();
            this.uiRadioButtonGroup1 = new Sunny.UI.UIRadioButtonGroup();
            this.ckcb_s1FlDown = new Sunny.UI.UICheckBox();
            this.ckcb_redK = new Sunny.UI.UICheckBox();
            this.ckcb_s1FlUp = new Sunny.UI.UICheckBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            this.ud_s1TurnoverSmaller = new Sunny.UI.UIIntegerUpDown();
            this.ckcb_s1TurnoverSmaller = new Sunny.UI.UICheckBox();
            this.ud_s1TurnoverBigger = new Sunny.UI.UIIntegerUpDown();
            this.ckcb_s1TurnoverBigger = new Sunny.UI.UICheckBox();
            this.ud_s1TurnoverTop = new Sunny.UI.UIIntegerUpDown();
            this.ckcb_s1TurnoverTop = new Sunny.UI.UICheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.uiCheckBoxGroup2 = new Sunny.UI.UICheckBoxGroup();
            this.ckcb_displayDealpriceAvg = new Sunny.UI.UICheckBox();
            this.ckcb_dealpriceOrder = new Sunny.UI.UICheckBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiRadioButtonGroup12 = new Sunny.UI.UIRadioButtonGroup();
            this.rdb_noneMax = new Sunny.UI.UIRadioButton();
            this.rdb_notMax = new Sunny.UI.UIRadioButton();
            this.rdb_max = new Sunny.UI.UIRadioButton();
            this.ckcb_notHighDis = new Sunny.UI.UICheckBox();
            this.ckcb_highVolume = new Sunny.UI.UICheckBox();
            this.txt_notHighDisValue = new Sunny.UI.UITextBox();
            this.ud_highVolume = new Sunny.UI.UIIntegerUpDown();
            this.ckcb_highStopLoss = new Sunny.UI.UICheckBox();
            this.uiRadioButtonGroup7 = new Sunny.UI.UIRadioButtonGroup();
            this.rdb_vidNone = new Sunny.UI.UIRadioButton();
            this.txt_vibValue = new Sunny.UI.UITextBox();
            this.rdb_vibSmall = new Sunny.UI.UIRadioButton();
            this.rdb_vibBig = new Sunny.UI.UIRadioButton();
            this.ckcb_tPrice = new Sunny.UI.UICheckBox();
            this.ud_tPrice = new Sunny.UI.UIIntegerUpDown();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.uiRadioButtonGroup15 = new Sunny.UI.UIRadioButtonGroup();
            this.rdb_S2topLineFalse = new Sunny.UI.UIRadioButton();
            this.rdb_S2topLineTrue = new Sunny.UI.UIRadioButton();
            this.uiCheckBoxGroup3 = new Sunny.UI.UICheckBoxGroup();
            this.rdb_S2Turnoverrate = new Sunny.UI.UIRadioButton();
            this.ud_S2Turnoverrate = new Sunny.UI.UIIntegerUpDown();
            this.uiSymbolLabel8 = new Sunny.UI.UISymbolLabel();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiCheckBoxGroup4 = new Sunny.UI.UICheckBoxGroup();
            this.rdb_S3Turnoverrate = new Sunny.UI.UIRadioButton();
            this.ud_S3Turnoverrate = new Sunny.UI.UIIntegerUpDown();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.txt_aprofit = new Sunny.UI.UITextBox();
            this.txt_bprofit = new Sunny.UI.UITextBox();
            this.txt_aloss = new Sunny.UI.UITextBox();
            this.txt_bloss = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiCheckBox8 = new Sunny.UI.UICheckBox();
            this.uiCheckBox7 = new Sunny.UI.UICheckBox();
            this.uiIntegerUpDown5 = new Sunny.UI.UIIntegerUpDown();
            this.uiCheckBox4 = new Sunny.UI.UICheckBox();
            this.uiIntegerUpDown6 = new Sunny.UI.UIIntegerUpDown();
            this.uiCheckBox5 = new Sunny.UI.UICheckBox();
            this.uiIntegerUpDown7 = new Sunny.UI.UIIntegerUpDown();
            this.uiCheckBox6 = new Sunny.UI.UICheckBox();
            this.uiRadioButtonGroup2 = new Sunny.UI.UIRadioButtonGroup();
            this.rdb_s1ProfitLong = new Sunny.UI.UIRadioButton();
            this.rdb_s1ProfitShort = new Sunny.UI.UIRadioButton();
            this.dp_start = new Sunny.UI.UIDatePicker();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.dp_end = new Sunny.UI.UIDatePicker();
            this.uiLine8 = new Sunny.UI.UILine();
            this.uiLine7 = new Sunny.UI.UILine();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.btn_excelOutput = new Sunny.UI.UISymbolButton();
            this.txt_fileName = new Sunny.UI.UITextBox();
            this.uiLine9 = new Sunny.UI.UILine();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.lb_status = new Sunny.UI.UILabel();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.cb_Strategy = new Sunny.UI.UIComboBox();
            this.btn_run = new Sunny.UI.UISymbolButton();
            this.btn_pause = new Sunny.UI.UISymbolButton();
            this.uiGroupBox5 = new Sunny.UI.UIGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ud_smLoss = new Sunny.UI.UIIntegerUpDown();
            this.ud_smProfit = new Sunny.UI.UIIntegerUpDown();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLine11 = new Sunny.UI.UILine();
            this.btn_smartExcel = new Sunny.UI.UISymbolButton();
            this.uiLine10 = new Sunny.UI.UILine();
            this.btn_pick = new Sunny.UI.UIButton();
            this.dp_pickDate = new Sunny.UI.UIDatePicker();
            this.uiRadioButtonGroup5 = new Sunny.UI.UIRadioButtonGroup();
            this.rdb_notsave = new Sunny.UI.UIRadioButton();
            this.rdb_save = new Sunny.UI.UIRadioButton();
            this.uiLine5 = new Sunny.UI.UILine();
            this.uiRadioButtonGroup8 = new Sunny.UI.UIRadioButtonGroup();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.ud_earn = new Sunny.UI.UIIntegerUpDown();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.ud_loss = new Sunny.UI.UIIntegerUpDown();
            this.uiRadioButtonGroup9 = new Sunny.UI.UIRadioButtonGroup();
            this.txt_discount = new Sunny.UI.UITextBox();
            this.uiRadioButtonGroup10 = new Sunny.UI.UIRadioButtonGroup();
            this.rdb_proDaytradeNo = new Sunny.UI.UIRadioButton();
            this.rdb_proDaytradeYes = new Sunny.UI.UIRadioButton();
            this.uiRadioButtonGroup11 = new Sunny.UI.UIRadioButtonGroup();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.ud_InTick = new Sunny.UI.UIIntegerUpDown();
            this.rdb_InUpper = new Sunny.UI.UIRadioButton();
            this.rdb_InUnder = new Sunny.UI.UIRadioButton();
            this.rdb_InOpen = new Sunny.UI.UIRadioButton();
            this.uiToolTip1 = new Sunny.UI.UIToolTip(this.components);
            this.ckcb_parse = new System.Windows.Forms.CheckBox();
            this.uiLine12 = new Sunny.UI.UILine();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.tabC_Strategy.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.uiRadioButtonGroup13.SuspendLayout();
            this.uiRadioButtonGroup6.SuspendLayout();
            this.uiRadioButtonGroup4.SuspendLayout();
            this.uiRadioButtonGroup3.SuspendLayout();
            this.uiRadioButtonGroup1.SuspendLayout();
            this.uiCheckBoxGroup1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.uiCheckBoxGroup2.SuspendLayout();
            this.uiRadioButtonGroup12.SuspendLayout();
            this.uiRadioButtonGroup7.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.uiRadioButtonGroup15.SuspendLayout();
            this.uiCheckBoxGroup3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.uiCheckBoxGroup4.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.uiRadioButtonGroup2.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            this.uiGroupBox4.SuspendLayout();
            this.uiGroupBox5.SuspendLayout();
            this.uiRadioButtonGroup5.SuspendLayout();
            this.uiRadioButtonGroup8.SuspendLayout();
            this.uiRadioButtonGroup9.SuspendLayout();
            this.uiRadioButtonGroup10.SuspendLayout();
            this.uiRadioButtonGroup11.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capitalDataToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.openExcelToolStripMenuItem,
            this.smartPickerToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.MarkToolStripMenuItem,
            this.DonateToolStripMenuItem,
            this.BlogToolStripMenuItem,
            this.QueryToolStripMenuItem,
            this.analyzeTableToolStripMenuItem,
            this.setIniToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1302, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // capitalDataToolStripMenuItem
            // 
            this.capitalDataToolStripMenuItem.Name = "capitalDataToolStripMenuItem";
            this.capitalDataToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.capitalDataToolStripMenuItem.Text = "資本額";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.databaseToolStripMenuItem.Text = "資料庫";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // openExcelToolStripMenuItem
            // 
            this.openExcelToolStripMenuItem.Name = "openExcelToolStripMenuItem";
            this.openExcelToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.openExcelToolStripMenuItem.Text = "開啟 Excel";
            this.openExcelToolStripMenuItem.Click += new System.EventHandler(this.openExcelToolStripMenuItem_Click);
            // 
            // smartPickerToolStripMenuItem
            // 
            this.smartPickerToolStripMenuItem.Name = "smartPickerToolStripMenuItem";
            this.smartPickerToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.smartPickerToolStripMenuItem.Text = "Smart Picker";
            this.smartPickerToolStripMenuItem.Click += new System.EventHandler(this.smartPickerToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.restartToolStripMenuItem.Text = "重啟";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // MarkToolStripMenuItem
            // 
            this.MarkToolStripMenuItem.Name = "MarkToolStripMenuItem";
            this.MarkToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.MarkToolStripMenuItem.Text = "備註";
            this.MarkToolStripMenuItem.Click += new System.EventHandler(this.MarkToolStripMenuItem_Click);
            // 
            // DonateToolStripMenuItem
            // 
            this.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem";
            this.DonateToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.DonateToolStripMenuItem.Text = "贊助";
            this.DonateToolStripMenuItem.Click += new System.EventHandler(this.DonateToolStripMenuItem_Click);
            // 
            // BlogToolStripMenuItem
            // 
            this.BlogToolStripMenuItem.Name = "BlogToolStripMenuItem";
            this.BlogToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.BlogToolStripMenuItem.Text = "開發者部落格";
            this.BlogToolStripMenuItem.Click += new System.EventHandler(this.BlogToolStripMenuItem_Click);
            // 
            // QueryToolStripMenuItem
            // 
            this.QueryToolStripMenuItem.Name = "QueryToolStripMenuItem";
            this.QueryToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.QueryToolStripMenuItem.Text = "資料庫查詢";
            this.QueryToolStripMenuItem.Click += new System.EventHandler(this.QueryToolStripMenuItem_Click);
            // 
            // analyzeTableToolStripMenuItem
            // 
            this.analyzeTableToolStripMenuItem.Name = "analyzeTableToolStripMenuItem";
            this.analyzeTableToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.analyzeTableToolStripMenuItem.Text = "AnalyzeTable";
            this.analyzeTableToolStripMenuItem.Click += new System.EventHandler(this.analyzeTableToolStripMenuItem_Click);
            // 
            // setIniToolStripMenuItem
            // 
            this.setIniToolStripMenuItem.Name = "setIniToolStripMenuItem";
            this.setIniToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.setIniToolStripMenuItem.Text = "變更初始設置";
            this.setIniToolStripMenuItem.Click += new System.EventHandler(this.setIniToolStripMenuItem_Click);
            // 
            // dgv_result
            // 
            this.dgv_result.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_result.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_result.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_result.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_result.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_result.EnableHeadersVisualStyles = false;
            this.dgv_result.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_result.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_result.Location = new System.Drawing.Point(687, 167);
            this.dgv_result.Name = "dgv_result";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_result.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgv_result.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_result.RowTemplate.Height = 29;
            this.dgv_result.SelectedIndex = -1;
            this.dgv_result.ShowGridLine = true;
            this.dgv_result.Size = new System.Drawing.Size(610, 638);
            this.dgv_result.Style = Sunny.UI.UIStyle.LightBlue;
            this.dgv_result.TabIndex = 1;
            // 
            // tabC_Strategy
            // 
            this.tabC_Strategy.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabC_Strategy.Controls.Add(this.tabPage1);
            this.tabC_Strategy.Controls.Add(this.tabPage2);
            this.tabC_Strategy.Controls.Add(this.tabPage3);
            this.tabC_Strategy.Controls.Add(this.tabPage4);
            this.tabC_Strategy.Controls.Add(this.tabPage6);
            this.tabC_Strategy.Controls.Add(this.tabPage7);
            this.tabC_Strategy.Controls.Add(this.tabPage8);
            this.tabC_Strategy.Controls.Add(this.tabPage9);
            this.tabC_Strategy.Controls.Add(this.tabPage10);
            this.tabC_Strategy.Controls.Add(this.tabPage11);
            this.tabC_Strategy.Controls.Add(this.tabPage12);
            this.tabC_Strategy.Controls.Add(this.tabPage13);
            this.tabC_Strategy.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabC_Strategy.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tabC_Strategy.ItemSize = new System.Drawing.Size(40, 200);
            this.tabC_Strategy.Location = new System.Drawing.Point(0, 164);
            this.tabC_Strategy.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.tabC_Strategy.Multiline = true;
            this.tabC_Strategy.Name = "tabC_Strategy";
            this.tabC_Strategy.SelectedIndex = 0;
            this.tabC_Strategy.Size = new System.Drawing.Size(410, 643);
            this.tabC_Strategy.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabC_Strategy.Style = Sunny.UI.UIStyle.Custom;
            this.tabC_Strategy.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.ckcb_parse);
            this.tabPage1.Controls.Add(this.uiLine12);
            this.tabPage1.Controls.Add(this.txt_c2);
            this.tabPage1.Controls.Add(this.txt_c1);
            this.tabPage1.Controls.Add(this.rdb_between);
            this.tabPage1.Controls.Add(this.ckcb_daytrade);
            this.tabPage1.Controls.Add(this.uiLine6);
            this.tabPage1.Controls.Add(this.ud_testDays);
            this.tabPage1.Controls.Add(this.uiLine4);
            this.tabPage1.Controls.Add(this.uiLabel1);
            this.tabPage1.Controls.Add(this.uiLine3);
            this.tabPage1.Controls.Add(this.uiLine2);
            this.tabPage1.Controls.Add(this.uiLine1);
            this.tabPage1.Controls.Add(this.ud_avgDays);
            this.tabPage1.Controls.Add(this.ud_pickquantity);
            this.tabPage1.Controls.Add(this.UpDown_closePrice);
            this.tabPage1.Controls.Add(this.rdb_bigger);
            this.tabPage1.Controls.Add(this.rdb_smaller);
            this.tabPage1.Controls.Add(this.rdb_ultimate);
            this.tabPage1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(201, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(209, 643);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "公用變數";
            // 
            // txt_c2
            // 
            this.txt_c2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_c2.DoubleValue = 150D;
            this.txt_c2.FillColor = System.Drawing.Color.White;
            this.txt_c2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_c2.IntValue = 150;
            this.txt_c2.Location = new System.Drawing.Point(147, 238);
            this.txt_c2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_c2.Maximum = 2147483647D;
            this.txt_c2.Minimum = -2147483648D;
            this.txt_c2.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_c2.Name = "txt_c2";
            this.txt_c2.Padding = new System.Windows.Forms.Padding(5);
            this.txt_c2.Size = new System.Drawing.Size(46, 29);
            this.txt_c2.Style = Sunny.UI.UIStyle.Custom;
            this.txt_c2.TabIndex = 4;
            this.txt_c2.Text = "150";
            // 
            // txt_c1
            // 
            this.txt_c1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_c1.DoubleValue = 100D;
            this.txt_c1.FillColor = System.Drawing.Color.White;
            this.txt_c1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_c1.IntValue = 100;
            this.txt_c1.Location = new System.Drawing.Point(91, 238);
            this.txt_c1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_c1.Maximum = 2147483647D;
            this.txt_c1.Minimum = -2147483648D;
            this.txt_c1.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_c1.Name = "txt_c1";
            this.txt_c1.Padding = new System.Windows.Forms.Padding(5);
            this.txt_c1.Size = new System.Drawing.Size(46, 29);
            this.txt_c1.Style = Sunny.UI.UIStyle.Custom;
            this.txt_c1.TabIndex = 145;
            this.txt_c1.Text = "100";
            // 
            // rdb_between
            // 
            this.rdb_between.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_between.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdb_between.Location = new System.Drawing.Point(25, 238);
            this.rdb_between.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_between.Name = "rdb_between";
            this.rdb_between.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_between.Size = new System.Drawing.Size(62, 35);
            this.rdb_between.TabIndex = 144;
            this.rdb_between.Text = "介於";
            // 
            // ckcb_daytrade
            // 
            this.ckcb_daytrade.AutoSize = true;
            this.ckcb_daytrade.Checked = true;
            this.ckcb_daytrade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcb_daytrade.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ckcb_daytrade.Location = new System.Drawing.Point(79, 43);
            this.ckcb_daytrade.Name = "ckcb_daytrade";
            this.ckcb_daytrade.Size = new System.Drawing.Size(56, 23);
            this.ckcb_daytrade.TabIndex = 143;
            this.ckcb_daytrade.Text = "Yes";
            this.ckcb_daytrade.UseVisualStyleBackColor = true;
            // 
            // uiLine6
            // 
            this.uiLine6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.uiLine6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine6.ForeColor = System.Drawing.Color.Red;
            this.uiLine6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiLine6.Location = new System.Drawing.Point(36, 427);
            this.uiLine6.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine6.Name = "uiLine6";
            this.uiLine6.Size = new System.Drawing.Size(140, 29);
            this.uiLine6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine6.TabIndex = 142;
            this.uiLine6.Text = "回測天數";
            // 
            // ud_testDays
            // 
            this.ud_testDays.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ud_testDays.Location = new System.Drawing.Point(57, 464);
            this.ud_testDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_testDays.Maximum = 100;
            this.ud_testDays.Minimum = -100;
            this.ud_testDays.MinimumSize = new System.Drawing.Size(100, 0);
            this.ud_testDays.Name = "ud_testDays";
            this.ud_testDays.Size = new System.Drawing.Size(100, 29);
            this.ud_testDays.Step = 10;
            this.ud_testDays.TabIndex = 141;
            this.ud_testDays.Text = "_uiIntegerUpDown1";
            this.ud_testDays.Value = 90;
            // 
            // uiLine4
            // 
            this.uiLine4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.uiLine4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine4.ForeColor = System.Drawing.Color.Red;
            this.uiLine4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiLine4.Location = new System.Drawing.Point(36, 3);
            this.uiLine4.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine4.Name = "uiLine4";
            this.uiLine4.Size = new System.Drawing.Size(140, 29);
            this.uiLine4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine4.TabIndex = 132;
            this.uiLine4.Text = "當沖";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(160, 397);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(39, 23);
            this.uiLabel1.TabIndex = 131;
            this.uiLabel1.Text = "(Day)";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine3
            // 
            this.uiLine3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.uiLine3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine3.ForeColor = System.Drawing.Color.Red;
            this.uiLine3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiLine3.Location = new System.Drawing.Point(36, 354);
            this.uiLine3.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(140, 29);
            this.uiLine3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine3.TabIndex = 130;
            this.uiLine3.Text = "均價(日)";
            // 
            // uiLine2
            // 
            this.uiLine2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.uiLine2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine2.ForeColor = System.Drawing.Color.Red;
            this.uiLine2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiLine2.Location = new System.Drawing.Point(36, 274);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(140, 29);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 129;
            this.uiLine2.Text = "選股數量";
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.ForeColor = System.Drawing.Color.Red;
            this.uiLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiLine1.Location = new System.Drawing.Point(36, 77);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(140, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 128;
            this.uiLine1.Text = "收盤價";
            // 
            // ud_avgDays
            // 
            this.ud_avgDays.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ud_avgDays.Location = new System.Drawing.Point(57, 391);
            this.ud_avgDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_avgDays.Maximum = 100;
            this.ud_avgDays.Minimum = -100;
            this.ud_avgDays.MinimumSize = new System.Drawing.Size(100, 0);
            this.ud_avgDays.Name = "ud_avgDays";
            this.ud_avgDays.Size = new System.Drawing.Size(100, 29);
            this.ud_avgDays.TabIndex = 126;
            this.ud_avgDays.Text = "_uiIntegerUpDown1";
            this.ud_avgDays.Value = 1;
            // 
            // ud_pickquantity
            // 
            this.ud_pickquantity.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ud_pickquantity.Location = new System.Drawing.Point(57, 311);
            this.ud_pickquantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_pickquantity.Maximum = 100;
            this.ud_pickquantity.Minimum = -100;
            this.ud_pickquantity.MinimumSize = new System.Drawing.Size(100, 0);
            this.ud_pickquantity.Name = "ud_pickquantity";
            this.ud_pickquantity.Size = new System.Drawing.Size(100, 29);
            this.ud_pickquantity.TabIndex = 124;
            this.ud_pickquantity.Text = "_uiIntegerUpDown1";
            this.ud_pickquantity.Value = 8;
            // 
            // UpDown_closePrice
            // 
            this.UpDown_closePrice.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UpDown_closePrice.Location = new System.Drawing.Point(59, 188);
            this.UpDown_closePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpDown_closePrice.Maximum = 100;
            this.UpDown_closePrice.Minimum = -100;
            this.UpDown_closePrice.MinimumSize = new System.Drawing.Size(100, 0);
            this.UpDown_closePrice.Name = "UpDown_closePrice";
            this.UpDown_closePrice.Size = new System.Drawing.Size(100, 29);
            this.UpDown_closePrice.Step = 5;
            this.UpDown_closePrice.TabIndex = 123;
            this.UpDown_closePrice.Text = "_uiIntegerUpDown1";
            this.UpDown_closePrice.Value = 80;
            // 
            // rdb_bigger
            // 
            this.rdb_bigger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_bigger.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdb_bigger.Location = new System.Drawing.Point(55, 148);
            this.rdb_bigger.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_bigger.Name = "rdb_bigger";
            this.rdb_bigger.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_bigger.Size = new System.Drawing.Size(51, 35);
            this.rdb_bigger.TabIndex = 122;
            this.rdb_bigger.Text = ">=";
            // 
            // rdb_smaller
            // 
            this.rdb_smaller.Checked = true;
            this.rdb_smaller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_smaller.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdb_smaller.Location = new System.Drawing.Point(121, 148);
            this.rdb_smaller.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_smaller.Name = "rdb_smaller";
            this.rdb_smaller.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_smaller.Size = new System.Drawing.Size(53, 35);
            this.rdb_smaller.TabIndex = 121;
            this.rdb_smaller.Text = "<=";
            // 
            // rdb_ultimate
            // 
            this.rdb_ultimate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_ultimate.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdb_ultimate.Location = new System.Drawing.Point(66, 107);
            this.rdb_ultimate.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_ultimate.Name = "rdb_ultimate";
            this.rdb_ultimate.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_ultimate.Size = new System.Drawing.Size(78, 35);
            this.rdb_ultimate.TabIndex = 119;
            this.rdb_ultimate.Text = "無限制";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.uiRadioButtonGroup13);
            this.tabPage2.Controls.Add(this.uiRadioButtonGroup6);
            this.tabPage2.Controls.Add(this.uiSymbolLabel4);
            this.tabPage2.Controls.Add(this.uiSymbolLabel3);
            this.tabPage2.Controls.Add(this.uiSymbolLabel2);
            this.tabPage2.Controls.Add(this.uiRadioButtonGroup4);
            this.tabPage2.Controls.Add(this.uiRadioButtonGroup3);
            this.tabPage2.Controls.Add(this.uiRadioButtonGroup1);
            this.tabPage2.Controls.Add(this.uiSymbolLabel1);
            this.tabPage2.Controls.Add(this.uiCheckBoxGroup1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(201, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(209, 643);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "策略一";
            // 
            // uiRadioButtonGroup13
            // 
            this.uiRadioButtonGroup13.Controls.Add(this.rdb_TClose);
            this.uiRadioButtonGroup13.Controls.Add(this.rdb_THigh);
            this.uiRadioButtonGroup13.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiRadioButtonGroup13.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButtonGroup13.ForeColor = System.Drawing.Color.Red;
            this.uiRadioButtonGroup13.Location = new System.Drawing.Point(4, 395);
            this.uiRadioButtonGroup13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup13.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup13.Name = "uiRadioButtonGroup13";
            this.uiRadioButtonGroup13.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup13.RectColor = System.Drawing.Color.Black;
            this.uiRadioButtonGroup13.Size = new System.Drawing.Size(201, 61);
            this.uiRadioButtonGroup13.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButtonGroup13.TabIndex = 131;
            this.uiRadioButtonGroup13.Text = "今價位對比前高";
            // 
            // rdb_TClose
            // 
            this.rdb_TClose.BackColor = System.Drawing.Color.Transparent;
            this.rdb_TClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_TClose.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_TClose.Location = new System.Drawing.Point(103, 28);
            this.rdb_TClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_TClose.Name = "rdb_TClose";
            this.rdb_TClose.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_TClose.Size = new System.Drawing.Size(83, 29);
            this.rdb_TClose.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_TClose.TabIndex = 2;
            this.rdb_TClose.Text = "收盤價";
            // 
            // rdb_THigh
            // 
            this.rdb_THigh.BackColor = System.Drawing.Color.Transparent;
            this.rdb_THigh.Checked = true;
            this.rdb_THigh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_THigh.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_THigh.Location = new System.Drawing.Point(14, 28);
            this.rdb_THigh.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_THigh.Name = "rdb_THigh";
            this.rdb_THigh.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_THigh.Size = new System.Drawing.Size(83, 29);
            this.rdb_THigh.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_THigh.TabIndex = 1;
            this.rdb_THigh.Text = "最高價";
            // 
            // uiRadioButtonGroup6
            // 
            this.uiRadioButtonGroup6.Controls.Add(this.rdb_highReal);
            this.uiRadioButtonGroup6.Controls.Add(this.rdb_highVirtual);
            this.uiRadioButtonGroup6.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiRadioButtonGroup6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButtonGroup6.ForeColor = System.Drawing.Color.Red;
            this.uiRadioButtonGroup6.Location = new System.Drawing.Point(4, 569);
            this.uiRadioButtonGroup6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup6.Name = "uiRadioButtonGroup6";
            this.uiRadioButtonGroup6.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup6.RectColor = System.Drawing.Color.Black;
            this.uiRadioButtonGroup6.Size = new System.Drawing.Size(201, 60);
            this.uiRadioButtonGroup6.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButtonGroup6.TabIndex = 128;
            this.uiRadioButtonGroup6.Text = "新高類別";
            // 
            // rdb_highReal
            // 
            this.rdb_highReal.BackColor = System.Drawing.Color.Transparent;
            this.rdb_highReal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_highReal.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_highReal.Location = new System.Drawing.Point(107, 25);
            this.rdb_highReal.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_highReal.Name = "rdb_highReal";
            this.rdb_highReal.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_highReal.Size = new System.Drawing.Size(71, 29);
            this.rdb_highReal.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_highReal.TabIndex = 1;
            this.rdb_highReal.Text = "Close";
            // 
            // rdb_highVirtual
            // 
            this.rdb_highVirtual.BackColor = System.Drawing.Color.Transparent;
            this.rdb_highVirtual.Checked = true;
            this.rdb_highVirtual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_highVirtual.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_highVirtual.Location = new System.Drawing.Point(14, 25);
            this.rdb_highVirtual.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_highVirtual.Name = "rdb_highVirtual";
            this.rdb_highVirtual.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_highVirtual.Size = new System.Drawing.Size(63, 29);
            this.rdb_highVirtual.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_highVirtual.TabIndex = 0;
            this.rdb_highVirtual.Text = "High";
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(63, 360);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(78, 27);
            this.uiSymbolLabel4.Symbol = 61560;
            this.uiSymbolLabel4.TabIndex = 134;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(63, 534);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(78, 27);
            this.uiSymbolLabel3.Symbol = 61560;
            this.uiSymbolLabel3.TabIndex = 133;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(63, 256);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(78, 27);
            this.uiSymbolLabel2.Symbol = 61560;
            this.uiSymbolLabel2.TabIndex = 132;
            // 
            // uiRadioButtonGroup4
            // 
            this.uiRadioButtonGroup4.Controls.Add(this.rdb_s1HighNone);
            this.uiRadioButtonGroup4.Controls.Add(this.rdb_s1HighYes);
            this.uiRadioButtonGroup4.Controls.Add(this.rdb_s1HighNo);
            this.uiRadioButtonGroup4.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiRadioButtonGroup4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButtonGroup4.ForeColor = System.Drawing.Color.Red;
            this.uiRadioButtonGroup4.Location = new System.Drawing.Point(4, 457);
            this.uiRadioButtonGroup4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup4.Name = "uiRadioButtonGroup4";
            this.uiRadioButtonGroup4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup4.RectColor = System.Drawing.Color.Black;
            this.uiRadioButtonGroup4.Size = new System.Drawing.Size(201, 61);
            this.uiRadioButtonGroup4.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButtonGroup4.TabIndex = 130;
            this.uiRadioButtonGroup4.Text = "盤中價位為時間內新高";
            // 
            // rdb_s1HighNone
            // 
            this.rdb_s1HighNone.BackColor = System.Drawing.Color.Transparent;
            this.rdb_s1HighNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_s1HighNone.Enabled = false;
            this.rdb_s1HighNone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_s1HighNone.Location = new System.Drawing.Point(132, 28);
            this.rdb_s1HighNone.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_s1HighNone.Name = "rdb_s1HighNone";
            this.rdb_s1HighNone.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_s1HighNone.Size = new System.Drawing.Size(54, 29);
            this.rdb_s1HighNone.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_s1HighNone.TabIndex = 2;
            this.rdb_s1HighNone.Text = "無";
            // 
            // rdb_s1HighYes
            // 
            this.rdb_s1HighYes.BackColor = System.Drawing.Color.Transparent;
            this.rdb_s1HighYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_s1HighYes.Enabled = false;
            this.rdb_s1HighYes.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_s1HighYes.Location = new System.Drawing.Point(14, 28);
            this.rdb_s1HighYes.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_s1HighYes.Name = "rdb_s1HighYes";
            this.rdb_s1HighYes.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_s1HighYes.Size = new System.Drawing.Size(52, 29);
            this.rdb_s1HighYes.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_s1HighYes.TabIndex = 1;
            this.rdb_s1HighYes.Text = "是";
            // 
            // rdb_s1HighNo
            // 
            this.rdb_s1HighNo.BackColor = System.Drawing.Color.Transparent;
            this.rdb_s1HighNo.Checked = true;
            this.rdb_s1HighNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_s1HighNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_s1HighNo.Location = new System.Drawing.Point(73, 28);
            this.rdb_s1HighNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_s1HighNo.Name = "rdb_s1HighNo";
            this.rdb_s1HighNo.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_s1HighNo.Size = new System.Drawing.Size(58, 29);
            this.rdb_s1HighNo.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_s1HighNo.TabIndex = 0;
            this.rdb_s1HighNo.Text = "否";
            // 
            // uiRadioButtonGroup3
            // 
            this.uiRadioButtonGroup3.Controls.Add(this.rdb_s1MajorNone);
            this.uiRadioButtonGroup3.Controls.Add(this.rdb_s1MajorBuy);
            this.uiRadioButtonGroup3.Controls.Add(this.rdb_s1MajorSell);
            this.uiRadioButtonGroup3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiRadioButtonGroup3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButtonGroup3.ForeColor = System.Drawing.Color.Red;
            this.uiRadioButtonGroup3.Location = new System.Drawing.Point(4, 291);
            this.uiRadioButtonGroup3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup3.Name = "uiRadioButtonGroup3";
            this.uiRadioButtonGroup3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup3.RectColor = System.Drawing.Color.Black;
            this.uiRadioButtonGroup3.Size = new System.Drawing.Size(201, 61);
            this.uiRadioButtonGroup3.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButtonGroup3.TabIndex = 129;
            this.uiRadioButtonGroup3.Text = "三大法人買賣超";
            // 
            // rdb_s1MajorNone
            // 
            this.rdb_s1MajorNone.BackColor = System.Drawing.Color.Transparent;
            this.rdb_s1MajorNone.Checked = true;
            this.rdb_s1MajorNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_s1MajorNone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_s1MajorNone.Location = new System.Drawing.Point(149, 27);
            this.rdb_s1MajorNone.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_s1MajorNone.Name = "rdb_s1MajorNone";
            this.rdb_s1MajorNone.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_s1MajorNone.Size = new System.Drawing.Size(49, 29);
            this.rdb_s1MajorNone.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_s1MajorNone.TabIndex = 2;
            this.rdb_s1MajorNone.Text = "無";
            // 
            // rdb_s1MajorBuy
            // 
            this.rdb_s1MajorBuy.BackColor = System.Drawing.Color.Transparent;
            this.rdb_s1MajorBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_s1MajorBuy.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_s1MajorBuy.Location = new System.Drawing.Point(14, 27);
            this.rdb_s1MajorBuy.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_s1MajorBuy.Name = "rdb_s1MajorBuy";
            this.rdb_s1MajorBuy.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_s1MajorBuy.Size = new System.Drawing.Size(61, 29);
            this.rdb_s1MajorBuy.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_s1MajorBuy.TabIndex = 1;
            this.rdb_s1MajorBuy.Text = "買超";
            // 
            // rdb_s1MajorSell
            // 
            this.rdb_s1MajorSell.BackColor = System.Drawing.Color.Transparent;
            this.rdb_s1MajorSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_s1MajorSell.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_s1MajorSell.Location = new System.Drawing.Point(79, 27);
            this.rdb_s1MajorSell.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_s1MajorSell.Name = "rdb_s1MajorSell";
            this.rdb_s1MajorSell.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_s1MajorSell.Size = new System.Drawing.Size(58, 29);
            this.rdb_s1MajorSell.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_s1MajorSell.TabIndex = 0;
            this.rdb_s1MajorSell.Text = "賣超";
            // 
            // uiRadioButtonGroup1
            // 
            this.uiRadioButtonGroup1.Controls.Add(this.ckcb_s1FlDown);
            this.uiRadioButtonGroup1.Controls.Add(this.ckcb_redK);
            this.uiRadioButtonGroup1.Controls.Add(this.ckcb_s1FlUp);
            this.uiRadioButtonGroup1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiRadioButtonGroup1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButtonGroup1.ForeColor = System.Drawing.Color.Red;
            this.uiRadioButtonGroup1.Location = new System.Drawing.Point(4, 188);
            this.uiRadioButtonGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup1.Name = "uiRadioButtonGroup1";
            this.uiRadioButtonGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup1.RectColor = System.Drawing.Color.Black;
            this.uiRadioButtonGroup1.Size = new System.Drawing.Size(201, 60);
            this.uiRadioButtonGroup1.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButtonGroup1.TabIndex = 127;
            this.uiRadioButtonGroup1.Text = "漲跌";
            // 
            // ckcb_s1FlDown
            // 
            this.ckcb_s1FlDown.BackColor = System.Drawing.Color.Transparent;
            this.ckcb_s1FlDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckcb_s1FlDown.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ckcb_s1FlDown.Location = new System.Drawing.Point(71, 25);
            this.ckcb_s1FlDown.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckcb_s1FlDown.Name = "ckcb_s1FlDown";
            this.ckcb_s1FlDown.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ckcb_s1FlDown.Size = new System.Drawing.Size(55, 29);
            this.ckcb_s1FlDown.Style = Sunny.UI.UIStyle.Custom;
            this.ckcb_s1FlDown.TabIndex = 128;
            this.ckcb_s1FlDown.Text = "跌";
            this.ckcb_s1FlDown.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.ckcb_s1FlDown_ValueChanged);
            // 
            // ckcb_redK
            // 
            this.ckcb_redK.BackColor = System.Drawing.Color.Transparent;
            this.ckcb_redK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckcb_redK.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ckcb_redK.Location = new System.Drawing.Point(132, 25);
            this.ckcb_redK.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckcb_redK.Name = "ckcb_redK";
            this.ckcb_redK.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ckcb_redK.Size = new System.Drawing.Size(63, 29);
            this.ckcb_redK.Style = Sunny.UI.UIStyle.Custom;
            this.ckcb_redK.TabIndex = 127;
            this.ckcb_redK.Text = "紅K";
            // 
            // ckcb_s1FlUp
            // 
            this.ckcb_s1FlUp.BackColor = System.Drawing.Color.Transparent;
            this.ckcb_s1FlUp.Checked = true;
            this.ckcb_s1FlUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckcb_s1FlUp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ckcb_s1FlUp.Location = new System.Drawing.Point(11, 25);
            this.ckcb_s1FlUp.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckcb_s1FlUp.Name = "ckcb_s1FlUp";
            this.ckcb_s1FlUp.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ckcb_s1FlUp.Size = new System.Drawing.Size(55, 29);
            this.ckcb_s1FlUp.Style = Sunny.UI.UIStyle.Custom;
            this.ckcb_s1FlUp.TabIndex = 129;
            this.ckcb_s1FlUp.Text = "漲";
            this.ckcb_s1FlUp.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.ckcb_s1FlUp_ValueChanged);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(63, 155);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(78, 27);
            this.uiSymbolLabel1.Symbol = 61560;
            this.uiSymbolLabel1.TabIndex = 127;
            // 
            // uiCheckBoxGroup1
            // 
            this.uiCheckBoxGroup1.Controls.Add(this.ud_s1TurnoverSmaller);
            this.uiCheckBoxGroup1.Controls.Add(this.ckcb_s1TurnoverSmaller);
            this.uiCheckBoxGroup1.Controls.Add(this.ud_s1TurnoverBigger);
            this.uiCheckBoxGroup1.Controls.Add(this.ckcb_s1TurnoverBigger);
            this.uiCheckBoxGroup1.Controls.Add(this.ud_s1TurnoverTop);
            this.uiCheckBoxGroup1.Controls.Add(this.ckcb_s1TurnoverTop);
            this.uiCheckBoxGroup1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiCheckBoxGroup1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup1.ForeColor = System.Drawing.Color.Red;
            this.uiCheckBoxGroup1.Location = new System.Drawing.Point(4, 5);
            this.uiCheckBoxGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            this.uiCheckBoxGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup1.RectColor = System.Drawing.Color.Black;
            this.uiCheckBoxGroup1.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup1.SelectedIndexes")));
            this.uiCheckBoxGroup1.Size = new System.Drawing.Size(201, 142);
            this.uiCheckBoxGroup1.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBoxGroup1.TabIndex = 3;
            this.uiCheckBoxGroup1.Text = "周轉率";
            // 
            // ud_s1TurnoverSmaller
            // 
            this.ud_s1TurnoverSmaller.Enabled = false;
            this.ud_s1TurnoverSmaller.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ud_s1TurnoverSmaller.Location = new System.Drawing.Point(77, 101);
            this.ud_s1TurnoverSmaller.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_s1TurnoverSmaller.Maximum = 100;
            this.ud_s1TurnoverSmaller.Minimum = -100;
            this.ud_s1TurnoverSmaller.MinimumSize = new System.Drawing.Size(100, 0);
            this.ud_s1TurnoverSmaller.Name = "ud_s1TurnoverSmaller";
            this.ud_s1TurnoverSmaller.Size = new System.Drawing.Size(100, 29);
            this.ud_s1TurnoverSmaller.Style = Sunny.UI.UIStyle.Custom;
            this.ud_s1TurnoverSmaller.TabIndex = 126;
            this.ud_s1TurnoverSmaller.Text = "_uiIntegerUpDown1";
            this.ud_s1TurnoverSmaller.Value = 5;
            // 
            // ckcb_s1TurnoverSmaller
            // 
            this.ckcb_s1TurnoverSmaller.BackColor = System.Drawing.Color.Transparent;
            this.ckcb_s1TurnoverSmaller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckcb_s1TurnoverSmaller.Enabled = false;
            this.ckcb_s1TurnoverSmaller.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ckcb_s1TurnoverSmaller.Location = new System.Drawing.Point(12, 99);
            this.ckcb_s1TurnoverSmaller.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckcb_s1TurnoverSmaller.Name = "ckcb_s1TurnoverSmaller";
            this.ckcb_s1TurnoverSmaller.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ckcb_s1TurnoverSmaller.Size = new System.Drawing.Size(63, 29);
            this.ckcb_s1TurnoverSmaller.Style = Sunny.UI.UIStyle.Custom;
            this.ckcb_s1TurnoverSmaller.TabIndex = 125;
            this.ckcb_s1TurnoverSmaller.Text = "<=";
            // 
            // ud_s1TurnoverBigger
            // 
            this.ud_s1TurnoverBigger.Enabled = false;
            this.ud_s1TurnoverBigger.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ud_s1TurnoverBigger.Location = new System.Drawing.Point(77, 66);
            this.ud_s1TurnoverBigger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_s1TurnoverBigger.Maximum = 100;
            this.ud_s1TurnoverBigger.Minimum = -100;
            this.ud_s1TurnoverBigger.MinimumSize = new System.Drawing.Size(100, 0);
            this.ud_s1TurnoverBigger.Name = "ud_s1TurnoverBigger";
            this.ud_s1TurnoverBigger.Size = new System.Drawing.Size(100, 29);
            this.ud_s1TurnoverBigger.Style = Sunny.UI.UIStyle.Custom;
            this.ud_s1TurnoverBigger.TabIndex = 126;
            this.ud_s1TurnoverBigger.Text = "_uiIntegerUpDown1";
            this.ud_s1TurnoverBigger.Value = 10;
            // 
            // ckcb_s1TurnoverBigger
            // 
            this.ckcb_s1TurnoverBigger.BackColor = System.Drawing.Color.Transparent;
            this.ckcb_s1TurnoverBigger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckcb_s1TurnoverBigger.Enabled = false;
            this.ckcb_s1TurnoverBigger.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ckcb_s1TurnoverBigger.Location = new System.Drawing.Point(12, 64);
            this.ckcb_s1TurnoverBigger.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckcb_s1TurnoverBigger.Name = "ckcb_s1TurnoverBigger";
            this.ckcb_s1TurnoverBigger.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ckcb_s1TurnoverBigger.Size = new System.Drawing.Size(63, 29);
            this.ckcb_s1TurnoverBigger.Style = Sunny.UI.UIStyle.Custom;
            this.ckcb_s1TurnoverBigger.TabIndex = 125;
            this.ckcb_s1TurnoverBigger.Text = ">=";
            // 
            // ud_s1TurnoverTop
            // 
            this.ud_s1TurnoverTop.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ud_s1TurnoverTop.Location = new System.Drawing.Point(77, 31);
            this.ud_s1TurnoverTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_s1TurnoverTop.Maximum = 100;
            this.ud_s1TurnoverTop.Minimum = -100;
            this.ud_s1TurnoverTop.MinimumSize = new System.Drawing.Size(100, 0);
            this.ud_s1TurnoverTop.Name = "ud_s1TurnoverTop";
            this.ud_s1TurnoverTop.Size = new System.Drawing.Size(100, 29);
            this.ud_s1TurnoverTop.Step = 10;
            this.ud_s1TurnoverTop.Style = Sunny.UI.UIStyle.Custom;
            this.ud_s1TurnoverTop.TabIndex = 124;
            this.ud_s1TurnoverTop.Text = "_uiIntegerUpDown1";
            this.ud_s1TurnoverTop.Value = 100;
            // 
            // ckcb_s1TurnoverTop
            // 
            this.ckcb_s1TurnoverTop.BackColor = System.Drawing.Color.Transparent;
            this.ckcb_s1TurnoverTop.Checked = true;
            this.ckcb_s1TurnoverTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckcb_s1TurnoverTop.Enabled = false;
            this.ckcb_s1TurnoverTop.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ckcb_s1TurnoverTop.Location = new System.Drawing.Point(12, 29);
            this.ckcb_s1TurnoverTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckcb_s1TurnoverTop.Name = "ckcb_s1TurnoverTop";
            this.ckcb_s1TurnoverTop.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ckcb_s1TurnoverTop.Size = new System.Drawing.Size(63, 29);
            this.ckcb_s1TurnoverTop.Style = Sunny.UI.UIStyle.Custom;
            this.ckcb_s1TurnoverTop.TabIndex = 0;
            this.ckcb_s1TurnoverTop.Text = "前";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.uiCheckBoxGroup2);
            this.tabPage3.Location = new System.Drawing.Point(201, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(209, 643);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "策略一 (擴充條件)";
            // 
            // uiCheckBoxGroup2
            // 
            this.uiCheckBoxGroup2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uiCheckBoxGroup2.Controls.Add(this.ckcb_displayDealpriceAvg);
            this.uiCheckBoxGroup2.Controls.Add(this.ckcb_dealpriceOrder);
            this.uiCheckBoxGroup2.Controls.Add(this.uiLabel11);
            this.uiCheckBoxGroup2.Controls.Add(this.uiRadioButtonGroup12);
            this.uiCheckBoxGroup2.Controls.Add(this.ckcb_notHighDis);
            this.uiCheckBoxGroup2.Controls.Add(this.ckcb_highVolume);
            this.uiCheckBoxGroup2.Controls.Add(this.txt_notHighDisValue);
            this.uiCheckBoxGroup2.Controls.Add(this.ud_highVolume);
            this.uiCheckBoxGroup2.Controls.Add(this.ckcb_highStopLoss);
            this.uiCheckBoxGroup2.Controls.Add(this.uiRadioButtonGroup7);
            this.uiCheckBoxGroup2.Controls.Add(this.ckcb_tPrice);
            this.uiCheckBoxGroup2.Controls.Add(this.ud_tPrice);
            this.uiCheckBoxGroup2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiCheckBoxGroup2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup2.ForeColor = System.Drawing.Color.Red;
            this.uiCheckBoxGroup2.Location = new System.Drawing.Point(4, 5);
            this.uiCheckBoxGroup2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup2.Name = "uiCheckBoxGroup2";
            this.uiCheckBoxGroup2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup2.RectColor = System.Drawing.Color.Black;
            this.uiCheckBoxGroup2.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup2.SelectedIndexes")));
            this.uiCheckBoxGroup2.Size = new System.Drawing.Size(201, 624);
            this.uiCheckBoxGroup2.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBoxGroup2.TabIndex = 4;
            this.uiCheckBoxGroup2.Text = "Extend Condition";
            // 
            // ckcb_displayDealpriceAvg
            // 
            this.ckcb_displayDealpriceAvg.BackColor = System.Drawing.Color.Transparent;
            this.ckcb_displayDealpriceAvg.Checked = true;
            this.ckcb_displayDealpriceAvg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckcb_displayDealpriceAvg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ckcb_displayDealpriceAvg.Location = new System.Drawing.Point(9, 322);
            this.ckcb_displayDealpriceAvg.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckcb_displayDealpriceAvg.Name = "ckcb_displayDealpriceAvg";
            this.ckcb_displayDealpriceAvg.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ckcb_displayDealpriceAvg.Size = new System.Drawing.Size(137, 29);
            this.ckcb_displayDealpriceAvg.Style = Sunny.UI.UIStyle.Custom;
            this.ckcb_displayDealpriceAvg.TabIndex = 156;
            this.ckcb_displayDealpriceAvg.Text = "顯示成交均值";
            // 
            // ckcb_dealpriceOrder
            // 
            this.ckcb_dealpriceOrder.BackColor = System.Drawing.Color.Transparent;
            this.ckcb_dealpriceOrder.Checked = true;
            this.ckcb_dealpriceOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckcb_dealpriceOrder.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ckcb_dealpriceOrder.Location = new System.Drawing.Point(9, 287);
            this.ckcb_dealpriceOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckcb_dealpriceOrder.Name = "ckcb_dealpriceOrder";
            this.ckcb_dealpriceOrder.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ckcb_dealpriceOrder.Size = new System.Drawing.Size(192, 29);
            this.ckcb_dealpriceOrder.Style = Sunny.UI.UIStyle.Custom;
            this.ckcb_dealpriceOrder.TabIndex = 155;
            this.ckcb_dealpriceOrder.Text = "成交值排行(前x成交值)";
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel11.Location = new System.Drawing.Point(171, 238);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(26, 23);
            this.uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel11.TabIndex = 154;
            this.uiLabel11.Text = "%";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiRadioButtonGroup12
            // 
            this.uiRadioButtonGroup12.BackColor = System.Drawing.Color.Transparent;
            this.uiRadioButtonGroup12.Controls.Add(this.rdb_noneMax);
            this.uiRadioButtonGroup12.Controls.Add(this.rdb_notMax);
            this.uiRadioButtonGroup12.Controls.Add(this.rdb_max);
            this.uiRadioButtonGroup12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButtonGroup12.Location = new System.Drawing.Point(6, 363);
            this.uiRadioButtonGroup12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup12.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup12.Name = "uiRadioButtonGroup12";
            this.uiRadioButtonGroup12.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup12.Size = new System.Drawing.Size(188, 102);
            this.uiRadioButtonGroup12.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButtonGroup12.TabIndex = 6;
            this.uiRadioButtonGroup12.Text = "收盤 漲停 || 非漲停";
            // 
            // rdb_noneMax
            // 
            this.rdb_noneMax.BackColor = System.Drawing.Color.Transparent;
            this.rdb_noneMax.Checked = true;
            this.rdb_noneMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_noneMax.Enabled = false;
            this.rdb_noneMax.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_noneMax.Location = new System.Drawing.Point(54, 67);
            this.rdb_noneMax.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_noneMax.Name = "rdb_noneMax";
            this.rdb_noneMax.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_noneMax.Size = new System.Drawing.Size(66, 29);
            this.rdb_noneMax.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_noneMax.TabIndex = 6;
            this.rdb_noneMax.Text = "none";
            // 
            // rdb_notMax
            // 
            this.rdb_notMax.BackColor = System.Drawing.Color.Transparent;
            this.rdb_notMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_notMax.Enabled = false;
            this.rdb_notMax.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_notMax.Location = new System.Drawing.Point(88, 36);
            this.rdb_notMax.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_notMax.Name = "rdb_notMax";
            this.rdb_notMax.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_notMax.Size = new System.Drawing.Size(79, 29);
            this.rdb_notMax.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_notMax.TabIndex = 6;
            this.rdb_notMax.Text = "非漲停";
            // 
            // rdb_max
            // 
            this.rdb_max.BackColor = System.Drawing.Color.Transparent;
            this.rdb_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_max.Enabled = false;
            this.rdb_max.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_max.Location = new System.Drawing.Point(22, 36);
            this.rdb_max.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_max.Name = "rdb_max";
            this.rdb_max.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_max.Size = new System.Drawing.Size(60, 29);
            this.rdb_max.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_max.TabIndex = 5;
            this.rdb_max.Text = "漲停";
            // 
            // ckcb_notHighDis
            // 
            this.ckcb_notHighDis.BackColor = System.Drawing.Color.Transparent;
            this.ckcb_notHighDis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckcb_notHighDis.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ckcb_notHighDis.Location = new System.Drawing.Point(9, 235);
            this.ckcb_notHighDis.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckcb_notHighDis.Name = "ckcb_notHighDis";
            this.ckcb_notHighDis.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ckcb_notHighDis.Size = new System.Drawing.Size(124, 29);
            this.ckcb_notHighDis.Style = Sunny.UI.UIStyle.Custom;
            this.ckcb_notHighDis.TabIndex = 154;
            this.ckcb_notHighDis.Text = "前高距離>=";
            // 
            // ckcb_highVolume
            // 
            this.ckcb_highVolume.BackColor = System.Drawing.Color.Transparent;
            this.ckcb_highVolume.Checked = true;
            this.ckcb_highVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckcb_highVolume.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ckcb_highVolume.Location = new System.Drawing.Point(9, 149);
            this.ckcb_highVolume.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckcb_highVolume.Name = "ckcb_highVolume";
            this.ckcb_highVolume.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ckcb_highVolume.Size = new System.Drawing.Size(124, 29);
            this.ckcb_highVolume.Style = Sunny.UI.UIStyle.Custom;
            this.ckcb_highVolume.TabIndex = 153;
            this.ckcb_highVolume.Text = "前高數量 >=";
            // 
            // txt_notHighDisValue
            // 
            this.txt_notHighDisValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_notHighDisValue.DoubleValue = 4D;
            this.txt_notHighDisValue.FillColor = System.Drawing.Color.White;
            this.txt_notHighDisValue.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_notHighDisValue.IntValue = 4;
            this.txt_notHighDisValue.Location = new System.Drawing.Point(136, 235);
            this.txt_notHighDisValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_notHighDisValue.Maximum = 2147483647D;
            this.txt_notHighDisValue.Minimum = -2147483648D;
            this.txt_notHighDisValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_notHighDisValue.Name = "txt_notHighDisValue";
            this.txt_notHighDisValue.Padding = new System.Windows.Forms.Padding(5);
            this.txt_notHighDisValue.Size = new System.Drawing.Size(32, 29);
            this.txt_notHighDisValue.Style = Sunny.UI.UIStyle.Custom;
            this.txt_notHighDisValue.TabIndex = 3;
            this.txt_notHighDisValue.Text = "4";
            // 
            // ud_highVolume
            // 
            this.ud_highVolume.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ud_highVolume.Location = new System.Drawing.Point(82, 186);
            this.ud_highVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_highVolume.Maximum = 100;
            this.ud_highVolume.Minimum = -100;
            this.ud_highVolume.MinimumSize = new System.Drawing.Size(100, 0);
            this.ud_highVolume.Name = "ud_highVolume";
            this.ud_highVolume.Size = new System.Drawing.Size(100, 29);
            this.ud_highVolume.Style = Sunny.UI.UIStyle.Custom;
            this.ud_highVolume.TabIndex = 152;
            this.ud_highVolume.Text = "_uiIntegerUpDown1";
            this.ud_highVolume.Value = 2;
            // 
            // ckcb_highStopLoss
            // 
            this.ckcb_highStopLoss.BackColor = System.Drawing.Color.Transparent;
            this.ckcb_highStopLoss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckcb_highStopLoss.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ckcb_highStopLoss.Location = new System.Drawing.Point(9, 35);
            this.ckcb_highStopLoss.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckcb_highStopLoss.Name = "ckcb_highStopLoss";
            this.ckcb_highStopLoss.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ckcb_highStopLoss.Size = new System.Drawing.Size(188, 29);
            this.ckcb_highStopLoss.Style = Sunny.UI.UIStyle.Custom;
            this.ckcb_highStopLoss.TabIndex = 151;
            this.ckcb_highStopLoss.Text = "前高停損(僅支持做空)";
            // 
            // uiRadioButtonGroup7
            // 
            this.uiRadioButtonGroup7.BackColor = System.Drawing.Color.Transparent;
            this.uiRadioButtonGroup7.Controls.Add(this.rdb_vidNone);
            this.uiRadioButtonGroup7.Controls.Add(this.txt_vibValue);
            this.uiRadioButtonGroup7.Controls.Add(this.rdb_vibSmall);
            this.uiRadioButtonGroup7.Controls.Add(this.rdb_vibBig);
            this.uiRadioButtonGroup7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButtonGroup7.Location = new System.Drawing.Point(6, 480);
            this.uiRadioButtonGroup7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup7.Name = "uiRadioButtonGroup7";
            this.uiRadioButtonGroup7.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup7.Size = new System.Drawing.Size(188, 109);
            this.uiRadioButtonGroup7.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButtonGroup7.TabIndex = 3;
            this.uiRadioButtonGroup7.Text = "漲跌幅波動";
            // 
            // rdb_vidNone
            // 
            this.rdb_vidNone.BackColor = System.Drawing.Color.Transparent;
            this.rdb_vidNone.Checked = true;
            this.rdb_vidNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_vidNone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_vidNone.Location = new System.Drawing.Point(13, 70);
            this.rdb_vidNone.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_vidNone.Name = "rdb_vidNone";
            this.rdb_vidNone.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_vidNone.Size = new System.Drawing.Size(66, 29);
            this.rdb_vidNone.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_vidNone.TabIndex = 5;
            this.rdb_vidNone.Text = "none";
            // 
            // txt_vibValue
            // 
            this.txt_vibValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_vibValue.DoubleValue = 3.6D;
            this.txt_vibValue.FillColor = System.Drawing.Color.White;
            this.txt_vibValue.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_vibValue.Location = new System.Drawing.Point(128, 35);
            this.txt_vibValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_vibValue.Maximum = 2147483647D;
            this.txt_vibValue.Minimum = -2147483648D;
            this.txt_vibValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_vibValue.Name = "txt_vibValue";
            this.txt_vibValue.Padding = new System.Windows.Forms.Padding(5);
            this.txt_vibValue.Size = new System.Drawing.Size(46, 29);
            this.txt_vibValue.Style = Sunny.UI.UIStyle.Custom;
            this.txt_vibValue.TabIndex = 3;
            this.txt_vibValue.Text = "3.6";
            // 
            // rdb_vibSmall
            // 
            this.rdb_vibSmall.BackColor = System.Drawing.Color.Transparent;
            this.rdb_vibSmall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_vibSmall.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_vibSmall.Location = new System.Drawing.Point(71, 35);
            this.rdb_vibSmall.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_vibSmall.Name = "rdb_vibSmall";
            this.rdb_vibSmall.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_vibSmall.Size = new System.Drawing.Size(52, 29);
            this.rdb_vibSmall.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_vibSmall.TabIndex = 4;
            this.rdb_vibSmall.Text = "<=";
            // 
            // rdb_vibBig
            // 
            this.rdb_vibBig.BackColor = System.Drawing.Color.Transparent;
            this.rdb_vibBig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_vibBig.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_vibBig.Location = new System.Drawing.Point(13, 35);
            this.rdb_vibBig.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_vibBig.Name = "rdb_vibBig";
            this.rdb_vibBig.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_vibBig.Size = new System.Drawing.Size(52, 29);
            this.rdb_vibBig.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_vibBig.TabIndex = 3;
            this.rdb_vibBig.Text = ">=";
            // 
            // ckcb_tPrice
            // 
            this.ckcb_tPrice.BackColor = System.Drawing.Color.Transparent;
            this.ckcb_tPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckcb_tPrice.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ckcb_tPrice.Location = new System.Drawing.Point(9, 72);
            this.ckcb_tPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckcb_tPrice.Name = "ckcb_tPrice";
            this.ckcb_tPrice.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ckcb_tPrice.Size = new System.Drawing.Size(155, 29);
            this.ckcb_tPrice.Style = Sunny.UI.UIStyle.Custom;
            this.ckcb_tPrice.TabIndex = 150;
            this.ckcb_tPrice.Text = "成交值大於(億)";
            // 
            // ud_tPrice
            // 
            this.ud_tPrice.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ud_tPrice.Location = new System.Drawing.Point(82, 109);
            this.ud_tPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_tPrice.Maximum = 100;
            this.ud_tPrice.Minimum = -100;
            this.ud_tPrice.MinimumSize = new System.Drawing.Size(100, 0);
            this.ud_tPrice.Name = "ud_tPrice";
            this.ud_tPrice.Size = new System.Drawing.Size(100, 29);
            this.ud_tPrice.Style = Sunny.UI.UIStyle.Custom;
            this.ud_tPrice.TabIndex = 147;
            this.ud_tPrice.Text = "_uiIntegerUpDown1";
            this.ud_tPrice.Value = 5;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.uiRadioButtonGroup15);
            this.tabPage4.Controls.Add(this.uiCheckBoxGroup3);
            this.tabPage4.Controls.Add(this.uiSymbolLabel8);
            this.tabPage4.Location = new System.Drawing.Point(201, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(209, 643);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "策略二";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // uiRadioButtonGroup15
            // 
            this.uiRadioButtonGroup15.Controls.Add(this.rdb_S2topLineFalse);
            this.uiRadioButtonGroup15.Controls.Add(this.rdb_S2topLineTrue);
            this.uiRadioButtonGroup15.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiRadioButtonGroup15.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButtonGroup15.ForeColor = System.Drawing.Color.Red;
            this.uiRadioButtonGroup15.Location = new System.Drawing.Point(3, 166);
            this.uiRadioButtonGroup15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup15.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup15.Name = "uiRadioButtonGroup15";
            this.uiRadioButtonGroup15.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup15.RectColor = System.Drawing.Color.Black;
            this.uiRadioButtonGroup15.Size = new System.Drawing.Size(201, 60);
            this.uiRadioButtonGroup15.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButtonGroup15.TabIndex = 137;
            this.uiRadioButtonGroup15.Text = "是否有上影線";
            // 
            // rdb_S2topLineFalse
            // 
            this.rdb_S2topLineFalse.BackColor = System.Drawing.Color.Transparent;
            this.rdb_S2topLineFalse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_S2topLineFalse.Enabled = false;
            this.rdb_S2topLineFalse.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_S2topLineFalse.Location = new System.Drawing.Point(113, 28);
            this.rdb_S2topLineFalse.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_S2topLineFalse.Name = "rdb_S2topLineFalse";
            this.rdb_S2topLineFalse.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_S2topLineFalse.Size = new System.Drawing.Size(54, 29);
            this.rdb_S2topLineFalse.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_S2topLineFalse.TabIndex = 3;
            this.rdb_S2topLineFalse.Text = "否";
            // 
            // rdb_S2topLineTrue
            // 
            this.rdb_S2topLineTrue.BackColor = System.Drawing.Color.Transparent;
            this.rdb_S2topLineTrue.Checked = true;
            this.rdb_S2topLineTrue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_S2topLineTrue.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_S2topLineTrue.Location = new System.Drawing.Point(32, 28);
            this.rdb_S2topLineTrue.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_S2topLineTrue.Name = "rdb_S2topLineTrue";
            this.rdb_S2topLineTrue.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_S2topLineTrue.Size = new System.Drawing.Size(52, 29);
            this.rdb_S2topLineTrue.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_S2topLineTrue.TabIndex = 2;
            this.rdb_S2topLineTrue.Text = "是";
            // 
            // uiCheckBoxGroup3
            // 
            this.uiCheckBoxGroup3.Controls.Add(this.rdb_S2Turnoverrate);
            this.uiCheckBoxGroup3.Controls.Add(this.ud_S2Turnoverrate);
            this.uiCheckBoxGroup3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiCheckBoxGroup3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup3.ForeColor = System.Drawing.Color.Red;
            this.uiCheckBoxGroup3.Location = new System.Drawing.Point(4, 44);
            this.uiCheckBoxGroup3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup3.Name = "uiCheckBoxGroup3";
            this.uiCheckBoxGroup3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup3.RectColor = System.Drawing.Color.Black;
            this.uiCheckBoxGroup3.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup3.SelectedIndexes")));
            this.uiCheckBoxGroup3.Size = new System.Drawing.Size(201, 79);
            this.uiCheckBoxGroup3.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBoxGroup3.TabIndex = 135;
            this.uiCheckBoxGroup3.Text = "周轉率";
            // 
            // rdb_S2Turnoverrate
            // 
            this.rdb_S2Turnoverrate.BackColor = System.Drawing.Color.Transparent;
            this.rdb_S2Turnoverrate.Checked = true;
            this.rdb_S2Turnoverrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_S2Turnoverrate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_S2Turnoverrate.Location = new System.Drawing.Point(18, 33);
            this.rdb_S2Turnoverrate.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_S2Turnoverrate.Name = "rdb_S2Turnoverrate";
            this.rdb_S2Turnoverrate.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_S2Turnoverrate.Size = new System.Drawing.Size(52, 29);
            this.rdb_S2Turnoverrate.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_S2Turnoverrate.TabIndex = 4;
            this.rdb_S2Turnoverrate.Text = "前";
            // 
            // ud_S2Turnoverrate
            // 
            this.ud_S2Turnoverrate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ud_S2Turnoverrate.Location = new System.Drawing.Point(77, 31);
            this.ud_S2Turnoverrate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_S2Turnoverrate.Maximum = 100;
            this.ud_S2Turnoverrate.Minimum = -100;
            this.ud_S2Turnoverrate.MinimumSize = new System.Drawing.Size(100, 0);
            this.ud_S2Turnoverrate.Name = "ud_S2Turnoverrate";
            this.ud_S2Turnoverrate.Size = new System.Drawing.Size(100, 29);
            this.ud_S2Turnoverrate.Step = 10;
            this.ud_S2Turnoverrate.Style = Sunny.UI.UIStyle.Custom;
            this.ud_S2Turnoverrate.TabIndex = 124;
            this.ud_S2Turnoverrate.Text = "_uiIntegerUpDown1";
            this.ud_S2Turnoverrate.Value = 100;
            // 
            // uiSymbolLabel8
            // 
            this.uiSymbolLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel8.Location = new System.Drawing.Point(62, 131);
            this.uiSymbolLabel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel8.Name = "uiSymbolLabel8";
            this.uiSymbolLabel8.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel8.Size = new System.Drawing.Size(78, 27);
            this.uiSymbolLabel8.Symbol = 61560;
            this.uiSymbolLabel8.TabIndex = 137;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.uiLabel10);
            this.tabPage6.Controls.Add(this.uiCheckBoxGroup4);
            this.tabPage6.Controls.Add(this.uiSymbolLabel5);
            this.tabPage6.Location = new System.Drawing.Point(201, 0);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(209, 643);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "策略三 ";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.Location = new System.Drawing.Point(81, 148);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(43, 23);
            this.uiLabel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel10.TabIndex = 125;
            this.uiLabel10.Text = "新高";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiCheckBoxGroup4
            // 
            this.uiCheckBoxGroup4.Controls.Add(this.rdb_S3Turnoverrate);
            this.uiCheckBoxGroup4.Controls.Add(this.ud_S3Turnoverrate);
            this.uiCheckBoxGroup4.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiCheckBoxGroup4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup4.ForeColor = System.Drawing.Color.Red;
            this.uiCheckBoxGroup4.Location = new System.Drawing.Point(4, 18);
            this.uiCheckBoxGroup4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup4.Name = "uiCheckBoxGroup4";
            this.uiCheckBoxGroup4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup4.RectColor = System.Drawing.Color.Black;
            this.uiCheckBoxGroup4.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup4.SelectedIndexes")));
            this.uiCheckBoxGroup4.Size = new System.Drawing.Size(201, 79);
            this.uiCheckBoxGroup4.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBoxGroup4.TabIndex = 138;
            this.uiCheckBoxGroup4.Text = "周轉率";
            // 
            // rdb_S3Turnoverrate
            // 
            this.rdb_S3Turnoverrate.BackColor = System.Drawing.Color.Transparent;
            this.rdb_S3Turnoverrate.Checked = true;
            this.rdb_S3Turnoverrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_S3Turnoverrate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_S3Turnoverrate.Location = new System.Drawing.Point(18, 33);
            this.rdb_S3Turnoverrate.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_S3Turnoverrate.Name = "rdb_S3Turnoverrate";
            this.rdb_S3Turnoverrate.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_S3Turnoverrate.Size = new System.Drawing.Size(52, 29);
            this.rdb_S3Turnoverrate.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_S3Turnoverrate.TabIndex = 4;
            this.rdb_S3Turnoverrate.Text = "前";
            // 
            // ud_S3Turnoverrate
            // 
            this.ud_S3Turnoverrate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ud_S3Turnoverrate.Location = new System.Drawing.Point(77, 31);
            this.ud_S3Turnoverrate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_S3Turnoverrate.Maximum = 100;
            this.ud_S3Turnoverrate.Minimum = -100;
            this.ud_S3Turnoverrate.MinimumSize = new System.Drawing.Size(100, 0);
            this.ud_S3Turnoverrate.Name = "ud_S3Turnoverrate";
            this.ud_S3Turnoverrate.Size = new System.Drawing.Size(100, 29);
            this.ud_S3Turnoverrate.Step = 10;
            this.ud_S3Turnoverrate.Style = Sunny.UI.UIStyle.Custom;
            this.ud_S3Turnoverrate.TabIndex = 124;
            this.ud_S3Turnoverrate.Text = "_uiIntegerUpDown1";
            this.ud_S3Turnoverrate.Value = 100;
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel5.Location = new System.Drawing.Point(62, 105);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(78, 27);
            this.uiSymbolLabel5.Symbol = 61560;
            this.uiSymbolLabel5.TabIndex = 140;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(201, 0);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(209, 643);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "策略三 (擴充條件)";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(201, 0);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(209, 643);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "策略四";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(201, 0);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(209, 643);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "策略四 (擴充條件)";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(201, 0);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(209, 643);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "策略五";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(201, 0);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(209, 643);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "策略五 (擴充條件)";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(201, 0);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(209, 643);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "策略六";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.txt_aprofit);
            this.tabPage13.Controls.Add(this.txt_bprofit);
            this.tabPage13.Controls.Add(this.txt_aloss);
            this.tabPage13.Controls.Add(this.txt_bloss);
            this.tabPage13.Controls.Add(this.uiLabel4);
            this.tabPage13.Controls.Add(this.uiLabel3);
            this.tabPage13.Controls.Add(this.uiLabel2);
            this.tabPage13.Controls.Add(this.uiCheckBox8);
            this.tabPage13.Controls.Add(this.uiCheckBox7);
            this.tabPage13.Controls.Add(this.uiIntegerUpDown5);
            this.tabPage13.Controls.Add(this.uiCheckBox4);
            this.tabPage13.Controls.Add(this.uiIntegerUpDown6);
            this.tabPage13.Controls.Add(this.uiCheckBox5);
            this.tabPage13.Controls.Add(this.uiIntegerUpDown7);
            this.tabPage13.Controls.Add(this.uiCheckBox6);
            this.tabPage13.Location = new System.Drawing.Point(201, 0);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Size = new System.Drawing.Size(209, 643);
            this.tabPage13.TabIndex = 12;
            this.tabPage13.Text = "策略六 (擴充條件)";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // txt_aprofit
            // 
            this.txt_aprofit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_aprofit.DoubleValue = 0.9D;
            this.txt_aprofit.FillColor = System.Drawing.Color.White;
            this.txt_aprofit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_aprofit.Location = new System.Drawing.Point(118, 602);
            this.txt_aprofit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_aprofit.Maximum = 2147483647D;
            this.txt_aprofit.Minimum = -2147483648D;
            this.txt_aprofit.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_aprofit.Name = "txt_aprofit";
            this.txt_aprofit.Padding = new System.Windows.Forms.Padding(5);
            this.txt_aprofit.Size = new System.Drawing.Size(44, 29);
            this.txt_aprofit.TabIndex = 164;
            this.txt_aprofit.Text = "0.90";
            // 
            // txt_bprofit
            // 
            this.txt_bprofit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bprofit.DoubleValue = 0.6D;
            this.txt_bprofit.FillColor = System.Drawing.Color.White;
            this.txt_bprofit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_bprofit.Location = new System.Drawing.Point(36, 602);
            this.txt_bprofit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_bprofit.Maximum = 2147483647D;
            this.txt_bprofit.Minimum = -2147483648D;
            this.txt_bprofit.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_bprofit.Name = "txt_bprofit";
            this.txt_bprofit.Padding = new System.Windows.Forms.Padding(5);
            this.txt_bprofit.Size = new System.Drawing.Size(44, 29);
            this.txt_bprofit.TabIndex = 163;
            this.txt_bprofit.Text = "0.60";
            // 
            // txt_aloss
            // 
            this.txt_aloss.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_aloss.DoubleValue = 1.09D;
            this.txt_aloss.FillColor = System.Drawing.Color.White;
            this.txt_aloss.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_aloss.Location = new System.Drawing.Point(118, 563);
            this.txt_aloss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_aloss.Maximum = 2147483647D;
            this.txt_aloss.Minimum = -2147483648D;
            this.txt_aloss.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_aloss.Name = "txt_aloss";
            this.txt_aloss.Padding = new System.Windows.Forms.Padding(5);
            this.txt_aloss.Size = new System.Drawing.Size(44, 29);
            this.txt_aloss.TabIndex = 162;
            this.txt_aloss.Text = "1.09";
            // 
            // txt_bloss
            // 
            this.txt_bloss.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bloss.DoubleValue = 1.06D;
            this.txt_bloss.FillColor = System.Drawing.Color.White;
            this.txt_bloss.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_bloss.Location = new System.Drawing.Point(36, 563);
            this.txt_bloss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_bloss.Maximum = 2147483647D;
            this.txt_bloss.Minimum = -2147483648D;
            this.txt_bloss.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_bloss.Name = "txt_bloss";
            this.txt_bloss.Padding = new System.Windows.Forms.Padding(5);
            this.txt_bloss.Size = new System.Drawing.Size(44, 29);
            this.txt_bloss.TabIndex = 161;
            this.txt_bloss.Text = "1.06";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.uiLabel4.Location = new System.Drawing.Point(66, 515);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(75, 23);
            this.uiLabel4.TabIndex = 160;
            this.uiLabel4.Text = "(104/06)";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(118, 535);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(33, 23);
            this.uiLabel3.TabIndex = 159;
            this.uiLabel3.Text = "後";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(32, 535);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(32, 23);
            this.uiLabel2.TabIndex = 158;
            this.uiLabel2.Text = "前";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiCheckBox8
            // 
            this.uiCheckBox8.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox8.Enabled = false;
            this.uiCheckBox8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox8.Location = new System.Drawing.Point(18, 201);
            this.uiCheckBox8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox8.Name = "uiCheckBox8";
            this.uiCheckBox8.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox8.Size = new System.Drawing.Size(123, 29);
            this.uiCheckBox8.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox8.TabIndex = 136;
            this.uiCheckBox8.Text = "日值排序";
            // 
            // uiCheckBox7
            // 
            this.uiCheckBox7.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox7.Enabled = false;
            this.uiCheckBox7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox7.Location = new System.Drawing.Point(18, 155);
            this.uiCheckBox7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox7.Name = "uiCheckBox7";
            this.uiCheckBox7.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox7.Size = new System.Drawing.Size(123, 29);
            this.uiCheckBox7.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox7.TabIndex = 135;
            this.uiCheckBox7.Text = "均值排序";
            // 
            // uiIntegerUpDown5
            // 
            this.uiIntegerUpDown5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiIntegerUpDown5.Location = new System.Drawing.Point(91, 458);
            this.uiIntegerUpDown5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiIntegerUpDown5.Maximum = 100;
            this.uiIntegerUpDown5.Minimum = -100;
            this.uiIntegerUpDown5.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiIntegerUpDown5.Name = "uiIntegerUpDown5";
            this.uiIntegerUpDown5.Size = new System.Drawing.Size(100, 29);
            this.uiIntegerUpDown5.Style = Sunny.UI.UIStyle.Custom;
            this.uiIntegerUpDown5.TabIndex = 133;
            this.uiIntegerUpDown5.Text = "_uiIntegerUpDown1";
            this.uiIntegerUpDown5.Value = 5;
            // 
            // uiCheckBox4
            // 
            this.uiCheckBox4.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox4.Enabled = false;
            this.uiCheckBox4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox4.Location = new System.Drawing.Point(18, 421);
            this.uiCheckBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox4.Name = "uiCheckBox4";
            this.uiCheckBox4.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox4.Size = new System.Drawing.Size(93, 29);
            this.uiCheckBox4.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox4.TabIndex = 131;
            this.uiCheckBox4.Text = "今 / 昨 >";
            // 
            // uiIntegerUpDown6
            // 
            this.uiIntegerUpDown6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiIntegerUpDown6.Location = new System.Drawing.Point(91, 369);
            this.uiIntegerUpDown6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiIntegerUpDown6.Maximum = 100;
            this.uiIntegerUpDown6.Minimum = -100;
            this.uiIntegerUpDown6.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiIntegerUpDown6.Name = "uiIntegerUpDown6";
            this.uiIntegerUpDown6.Size = new System.Drawing.Size(100, 29);
            this.uiIntegerUpDown6.Style = Sunny.UI.UIStyle.Custom;
            this.uiIntegerUpDown6.TabIndex = 134;
            this.uiIntegerUpDown6.Text = "_uiIntegerUpDown1";
            this.uiIntegerUpDown6.Value = 10;
            // 
            // uiCheckBox5
            // 
            this.uiCheckBox5.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox5.Enabled = false;
            this.uiCheckBox5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox5.Location = new System.Drawing.Point(18, 332);
            this.uiCheckBox5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox5.Name = "uiCheckBox5";
            this.uiCheckBox5.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox5.Size = new System.Drawing.Size(123, 29);
            this.uiCheckBox5.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox5.TabIndex = 132;
            this.uiCheckBox5.Text = "均值 / 日 >";
            // 
            // uiIntegerUpDown7
            // 
            this.uiIntegerUpDown7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiIntegerUpDown7.Location = new System.Drawing.Point(91, 284);
            this.uiIntegerUpDown7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiIntegerUpDown7.Maximum = 100;
            this.uiIntegerUpDown7.Minimum = -100;
            this.uiIntegerUpDown7.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiIntegerUpDown7.Name = "uiIntegerUpDown7";
            this.uiIntegerUpDown7.Size = new System.Drawing.Size(100, 29);
            this.uiIntegerUpDown7.Step = 10;
            this.uiIntegerUpDown7.Style = Sunny.UI.UIStyle.Custom;
            this.uiIntegerUpDown7.TabIndex = 130;
            this.uiIntegerUpDown7.Text = "_uiIntegerUpDown1";
            this.uiIntegerUpDown7.Value = 3;
            // 
            // uiCheckBox6
            // 
            this.uiCheckBox6.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox6.Enabled = false;
            this.uiCheckBox6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox6.Location = new System.Drawing.Point(18, 247);
            this.uiCheckBox6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox6.Name = "uiCheckBox6";
            this.uiCheckBox6.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox6.Size = new System.Drawing.Size(123, 29);
            this.uiCheckBox6.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox6.TabIndex = 129;
            this.uiCheckBox6.Text = "均值 >=";
            // 
            // uiRadioButtonGroup2
            // 
            this.uiRadioButtonGroup2.Controls.Add(this.rdb_s1ProfitLong);
            this.uiRadioButtonGroup2.Controls.Add(this.rdb_s1ProfitShort);
            this.uiRadioButtonGroup2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiRadioButtonGroup2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButtonGroup2.ForeColor = System.Drawing.Color.Red;
            this.uiRadioButtonGroup2.Location = new System.Drawing.Point(438, 284);
            this.uiRadioButtonGroup2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup2.Name = "uiRadioButtonGroup2";
            this.uiRadioButtonGroup2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup2.RectColor = System.Drawing.Color.Black;
            this.uiRadioButtonGroup2.Size = new System.Drawing.Size(201, 63);
            this.uiRadioButtonGroup2.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButtonGroup2.TabIndex = 128;
            this.uiRadioButtonGroup2.Text = "操作方向";
            // 
            // rdb_s1ProfitLong
            // 
            this.rdb_s1ProfitLong.BackColor = System.Drawing.Color.Transparent;
            this.rdb_s1ProfitLong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_s1ProfitLong.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_s1ProfitLong.Location = new System.Drawing.Point(129, 28);
            this.rdb_s1ProfitLong.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_s1ProfitLong.Name = "rdb_s1ProfitLong";
            this.rdb_s1ProfitLong.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_s1ProfitLong.Size = new System.Drawing.Size(57, 29);
            this.rdb_s1ProfitLong.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_s1ProfitLong.TabIndex = 1;
            this.rdb_s1ProfitLong.Text = "多";
            // 
            // rdb_s1ProfitShort
            // 
            this.rdb_s1ProfitShort.BackColor = System.Drawing.Color.Transparent;
            this.rdb_s1ProfitShort.Checked = true;
            this.rdb_s1ProfitShort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_s1ProfitShort.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_s1ProfitShort.Location = new System.Drawing.Point(30, 28);
            this.rdb_s1ProfitShort.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_s1ProfitShort.Name = "rdb_s1ProfitShort";
            this.rdb_s1ProfitShort.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_s1ProfitShort.Size = new System.Drawing.Size(82, 29);
            this.rdb_s1ProfitShort.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_s1ProfitShort.TabIndex = 0;
            this.rdb_s1ProfitShort.Text = "空";
            // 
            // dp_start
            // 
            this.dp_start.FillColor = System.Drawing.Color.White;
            this.dp_start.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dp_start.Location = new System.Drawing.Point(98, 35);
            this.dp_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dp_start.MaxLength = 10;
            this.dp_start.MinimumSize = new System.Drawing.Size(63, 0);
            this.dp_start.Name = "dp_start";
            this.dp_start.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dp_start.Size = new System.Drawing.Size(137, 29);
            this.dp_start.Style = Sunny.UI.UIStyle.Custom;
            this.dp_start.SymbolDropDown = 61555;
            this.dp_start.SymbolNormal = 61555;
            this.dp_start.TabIndex = 143;
            this.dp_start.Text = "2021-04-07";
            this.dp_start.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dp_start.Value = new System.DateTime(2021, 4, 7, 0, 0, 0, 0);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.dp_end);
            this.uiGroupBox1.Controls.Add(this.uiLine8);
            this.uiGroupBox1.Controls.Add(this.uiLine7);
            this.uiGroupBox1.Controls.Add(this.dp_start);
            this.uiGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(2, 29);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.uiGroupBox1.Size = new System.Drawing.Size(249, 130);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "回測日期";
            // 
            // dp_end
            // 
            this.dp_end.FillColor = System.Drawing.Color.White;
            this.dp_end.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dp_end.Location = new System.Drawing.Point(98, 83);
            this.dp_end.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dp_end.MaxLength = 10;
            this.dp_end.MinimumSize = new System.Drawing.Size(63, 0);
            this.dp_end.Name = "dp_end";
            this.dp_end.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dp_end.Size = new System.Drawing.Size(137, 29);
            this.dp_end.Style = Sunny.UI.UIStyle.Custom;
            this.dp_end.SymbolDropDown = 61555;
            this.dp_end.SymbolNormal = 61555;
            this.dp_end.TabIndex = 1;
            this.dp_end.Text = "2021-04-07";
            this.dp_end.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dp_end.Value = new System.DateTime(2021, 4, 7, 0, 0, 0, 0);
            // 
            // uiLine8
            // 
            this.uiLine8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine8.Location = new System.Drawing.Point(17, 83);
            this.uiLine8.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine8.Name = "uiLine8";
            this.uiLine8.Size = new System.Drawing.Size(74, 29);
            this.uiLine8.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine8.TabIndex = 144;
            this.uiLine8.Text = "結束";
            // 
            // uiLine7
            // 
            this.uiLine7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine7.Location = new System.Drawing.Point(17, 35);
            this.uiLine7.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine7.Name = "uiLine7";
            this.uiLine7.Size = new System.Drawing.Size(74, 29);
            this.uiLine7.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine7.TabIndex = 143;
            this.uiLine7.Text = "開始";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.btn_excelOutput);
            this.uiGroupBox2.Controls.Add(this.txt_fileName);
            this.uiGroupBox2.Controls.Add(this.uiLine9);
            this.uiGroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(258, 29);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.uiGroupBox2.Size = new System.Drawing.Size(152, 130);
            this.uiGroupBox2.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox2.TabIndex = 145;
            this.uiGroupBox2.Text = "Excel";
            // 
            // btn_excelOutput
            // 
            this.btn_excelOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excelOutput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.btn_excelOutput.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_excelOutput.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btn_excelOutput.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btn_excelOutput.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_excelOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_excelOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excelOutput.Location = new System.Drawing.Point(21, 95);
            this.btn_excelOutput.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_excelOutput.Name = "btn_excelOutput";
            this.btn_excelOutput.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btn_excelOutput.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_excelOutput.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_excelOutput.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btn_excelOutput.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btn_excelOutput.Size = new System.Drawing.Size(112, 29);
            this.btn_excelOutput.Style = Sunny.UI.UIStyle.LightOrange;
            this.btn_excelOutput.StyleCustomMode = true;
            this.btn_excelOutput.Symbol = 61508;
            this.btn_excelOutput.TabIndex = 147;
            this.btn_excelOutput.Text = "匯出";
            this.btn_excelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_excelOutput.Click += new System.EventHandler(this.btn_excelOutput_Click);
            // 
            // txt_fileName
            // 
            this.txt_fileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_fileName.FillColor = System.Drawing.Color.White;
            this.txt_fileName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_fileName.Location = new System.Drawing.Point(21, 60);
            this.txt_fileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_fileName.Maximum = 2147483647D;
            this.txt_fileName.Minimum = -2147483648D;
            this.txt_fileName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_fileName.Name = "txt_fileName";
            this.txt_fileName.Padding = new System.Windows.Forms.Padding(5);
            this.txt_fileName.Size = new System.Drawing.Size(112, 29);
            this.txt_fileName.Style = Sunny.UI.UIStyle.Custom;
            this.txt_fileName.TabIndex = 146;
            // 
            // uiLine9
            // 
            this.uiLine9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine9.Location = new System.Drawing.Point(21, 28);
            this.uiLine9.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine9.Name = "uiLine9";
            this.uiLine9.Size = new System.Drawing.Size(109, 29);
            this.uiLine9.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine9.TabIndex = 144;
            this.uiLine9.Text = "檔案名稱";
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.lb_status);
            this.uiGroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.uiGroupBox3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox3.Location = new System.Drawing.Point(418, 103);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.uiGroupBox3.Size = new System.Drawing.Size(169, 56);
            this.uiGroupBox3.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox3.TabIndex = 145;
            this.uiGroupBox3.Text = "執行狀態";
            // 
            // lb_status
            // 
            this.lb_status.BackColor = System.Drawing.Color.Transparent;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(3, 24);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(163, 27);
            this.lb_status.Style = Sunny.UI.UIStyle.Custom;
            this.lb_status.TabIndex = 132;
            this.lb_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.cb_Strategy);
            this.uiGroupBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.uiGroupBox4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox4.Location = new System.Drawing.Point(418, 29);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.uiGroupBox4.Size = new System.Drawing.Size(169, 64);
            this.uiGroupBox4.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox4.TabIndex = 146;
            this.uiGroupBox4.Text = "選擇策略";
            // 
            // cb_Strategy
            // 
            this.cb_Strategy.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cb_Strategy.FillColor = System.Drawing.Color.White;
            this.cb_Strategy.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cb_Strategy.Items.AddRange(new object[] {
            "策略一",
            "策略二",
            "策略三"});
            this.cb_Strategy.Location = new System.Drawing.Point(8, 27);
            this.cb_Strategy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Strategy.MinimumSize = new System.Drawing.Size(63, 0);
            this.cb_Strategy.Name = "cb_Strategy";
            this.cb_Strategy.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cb_Strategy.Size = new System.Drawing.Size(150, 29);
            this.cb_Strategy.Style = Sunny.UI.UIStyle.Custom;
            this.cb_Strategy.TabIndex = 133;
            this.cb_Strategy.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_run
            // 
            this.btn_run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_run.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_run.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_run.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_run.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_run.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_run.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_run.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_run.Location = new System.Drawing.Point(594, 46);
            this.btn_run.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_run.Name = "btn_run";
            this.btn_run.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btn_run.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_run.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_run.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_run.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_run.Size = new System.Drawing.Size(82, 47);
            this.btn_run.Style = Sunny.UI.UIStyle.LightRed;
            this.btn_run.StyleCustomMode = true;
            this.btn_run.Symbol = 61515;
            this.btn_run.SymbolSize = 28;
            this.btn_run.TabIndex = 148;
            this.btn_run.Text = "執行";
            this.btn_run.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pause.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_pause.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_pause.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_pause.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_pause.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_pause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pause.Location = new System.Drawing.Point(594, 112);
            this.btn_pause.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btn_pause.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_pause.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_pause.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_pause.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_pause.Size = new System.Drawing.Size(82, 47);
            this.btn_pause.Style = Sunny.UI.UIStyle.LightRed;
            this.btn_pause.StyleCustomMode = true;
            this.btn_pause.Symbol = 96;
            this.btn_pause.SymbolSize = 36;
            this.btn_pause.TabIndex = 149;
            this.btn_pause.Text = "暫停";
            this.btn_pause.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // uiGroupBox5
            // 
            this.uiGroupBox5.Controls.Add(this.label2);
            this.uiGroupBox5.Controls.Add(this.label1);
            this.uiGroupBox5.Controls.Add(this.ud_smLoss);
            this.uiGroupBox5.Controls.Add(this.ud_smProfit);
            this.uiGroupBox5.Controls.Add(this.uiLabel6);
            this.uiGroupBox5.Controls.Add(this.uiLabel5);
            this.uiGroupBox5.Controls.Add(this.uiLine11);
            this.uiGroupBox5.Controls.Add(this.btn_smartExcel);
            this.uiGroupBox5.Controls.Add(this.uiLine10);
            this.uiGroupBox5.Controls.Add(this.btn_pick);
            this.uiGroupBox5.Controls.Add(this.dp_pickDate);
            this.uiGroupBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.uiGroupBox5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox5.Location = new System.Drawing.Point(792, 29);
            this.uiGroupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox5.Name = "uiGroupBox5";
            this.uiGroupBox5.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiGroupBox5.Size = new System.Drawing.Size(505, 129);
            this.uiGroupBox5.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox5.TabIndex = 145;
            this.uiGroupBox5.Text = "選股";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label2.Location = new System.Drawing.Point(462, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 159;
            this.label2.Text = "tick";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.Location = new System.Drawing.Point(317, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 158;
            this.label1.Text = "tick";
            // 
            // ud_smLoss
            // 
            this.ud_smLoss.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ud_smLoss.Location = new System.Drawing.Point(357, 87);
            this.ud_smLoss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_smLoss.Maximum = 100;
            this.ud_smLoss.Minimum = -100;
            this.ud_smLoss.MinimumSize = new System.Drawing.Size(100, 0);
            this.ud_smLoss.Name = "ud_smLoss";
            this.ud_smLoss.Size = new System.Drawing.Size(100, 29);
            this.ud_smLoss.Style = Sunny.UI.UIStyle.Custom;
            this.ud_smLoss.TabIndex = 155;
            this.ud_smLoss.Text = "_uiIntegerUpDown1";
            this.ud_smLoss.Value = 5;
            // 
            // ud_smProfit
            // 
            this.ud_smProfit.Enabled = false;
            this.ud_smProfit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ud_smProfit.Location = new System.Drawing.Point(213, 87);
            this.ud_smProfit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_smProfit.Maximum = 100;
            this.ud_smProfit.Minimum = -100;
            this.ud_smProfit.MinimumSize = new System.Drawing.Size(100, 0);
            this.ud_smProfit.Name = "ud_smProfit";
            this.ud_smProfit.Size = new System.Drawing.Size(100, 29);
            this.ud_smProfit.Style = Sunny.UI.UIStyle.Custom;
            this.ud_smProfit.TabIndex = 125;
            this.ud_smProfit.Text = "_uiIntegerUpDown1";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(386, 59);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(44, 23);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 156;
            this.uiLabel6.Text = "停損";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(242, 59);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(44, 23);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 154;
            this.uiLabel5.Text = "停利";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine11
            // 
            this.uiLine11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine11.Location = new System.Drawing.Point(201, 27);
            this.uiLine11.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine11.Name = "uiLine11";
            this.uiLine11.Size = new System.Drawing.Size(297, 29);
            this.uiLine11.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine11.TabIndex = 144;
            this.uiLine11.Text = "當前智能輸出僅支持做空";
            // 
            // btn_smartExcel
            // 
            this.btn_smartExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_smartExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.btn_smartExcel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_smartExcel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btn_smartExcel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btn_smartExcel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_smartExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_smartExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_smartExcel.Location = new System.Drawing.Point(8, 83);
            this.btn_smartExcel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_smartExcel.Name = "btn_smartExcel";
            this.btn_smartExcel.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btn_smartExcel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_smartExcel.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_smartExcel.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btn_smartExcel.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.btn_smartExcel.Size = new System.Drawing.Size(129, 29);
            this.btn_smartExcel.Style = Sunny.UI.UIStyle.LightOrange;
            this.btn_smartExcel.StyleCustomMode = true;
            this.btn_smartExcel.Symbol = 61508;
            this.btn_smartExcel.TabIndex = 148;
            this.btn_smartExcel.Text = "智能匯出";
            this.btn_smartExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_smartExcel.Click += new System.EventHandler(this.btn_smartExcel_Click);
            // 
            // uiLine10
            // 
            this.uiLine10.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine10.Location = new System.Drawing.Point(183, 17);
            this.uiLine10.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine10.Name = "uiLine10";
            this.uiLine10.Size = new System.Drawing.Size(21, 110);
            this.uiLine10.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine10.TabIndex = 151;
            // 
            // btn_pick
            // 
            this.btn_pick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pick.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_pick.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btn_pick.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_pick.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_pick.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_pick.Location = new System.Drawing.Point(144, 40);
            this.btn_pick.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_pick.Name = "btn_pick";
            this.btn_pick.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_pick.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btn_pick.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_pick.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btn_pick.Size = new System.Drawing.Size(40, 72);
            this.btn_pick.Style = Sunny.UI.UIStyle.Red;
            this.btn_pick.StyleCustomMode = true;
            this.btn_pick.TabIndex = 150;
            this.btn_pick.Text = "選股";
            this.btn_pick.TipsColor = System.Drawing.Color.Gainsboro;
            this.btn_pick.Click += new System.EventHandler(this.btn_pick_Click);
            // 
            // dp_pickDate
            // 
            this.dp_pickDate.FillColor = System.Drawing.Color.White;
            this.dp_pickDate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dp_pickDate.Location = new System.Drawing.Point(8, 40);
            this.dp_pickDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dp_pickDate.MaxLength = 10;
            this.dp_pickDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dp_pickDate.Name = "dp_pickDate";
            this.dp_pickDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dp_pickDate.Size = new System.Drawing.Size(129, 29);
            this.dp_pickDate.Style = Sunny.UI.UIStyle.Custom;
            this.dp_pickDate.SymbolDropDown = 61555;
            this.dp_pickDate.SymbolNormal = 61555;
            this.dp_pickDate.TabIndex = 0;
            this.dp_pickDate.Text = "2021-03-27";
            this.dp_pickDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dp_pickDate.Value = new System.DateTime(2021, 3, 27, 1, 46, 14, 604);
            // 
            // uiRadioButtonGroup5
            // 
            this.uiRadioButtonGroup5.Controls.Add(this.rdb_notsave);
            this.uiRadioButtonGroup5.Controls.Add(this.rdb_save);
            this.uiRadioButtonGroup5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.uiRadioButtonGroup5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButtonGroup5.Location = new System.Drawing.Point(691, 29);
            this.uiRadioButtonGroup5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup5.Name = "uiRadioButtonGroup5";
            this.uiRadioButtonGroup5.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.uiRadioButtonGroup5.Size = new System.Drawing.Size(88, 129);
            this.uiRadioButtonGroup5.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButtonGroup5.TabIndex = 128;
            this.uiRadioButtonGroup5.Text = "資料保留";
            // 
            // rdb_notsave
            // 
            this.rdb_notsave.BackColor = System.Drawing.Color.Transparent;
            this.rdb_notsave.Checked = true;
            this.rdb_notsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_notsave.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_notsave.Location = new System.Drawing.Point(19, 83);
            this.rdb_notsave.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_notsave.Name = "rdb_notsave";
            this.rdb_notsave.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_notsave.Size = new System.Drawing.Size(54, 29);
            this.rdb_notsave.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_notsave.TabIndex = 1;
            this.rdb_notsave.Text = "否";
            // 
            // rdb_save
            // 
            this.rdb_save.BackColor = System.Drawing.Color.Transparent;
            this.rdb_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_save.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_save.Location = new System.Drawing.Point(19, 33);
            this.rdb_save.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_save.Name = "rdb_save";
            this.rdb_save.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_save.Size = new System.Drawing.Size(55, 29);
            this.rdb_save.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_save.TabIndex = 0;
            this.rdb_save.Text = "是";
            // 
            // uiLine5
            // 
            this.uiLine5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.uiLine5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine5.ForeColor = System.Drawing.Color.Red;
            this.uiLine5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiLine5.Location = new System.Drawing.Point(438, 167);
            this.uiLine5.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine5.Name = "uiLine5";
            this.uiLine5.Size = new System.Drawing.Size(201, 29);
            this.uiLine5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine5.TabIndex = 150;
            this.uiLine5.Text = "獲利計算模組";
            // 
            // uiRadioButtonGroup8
            // 
            this.uiRadioButtonGroup8.Controls.Add(this.uiLabel8);
            this.uiRadioButtonGroup8.Controls.Add(this.ud_earn);
            this.uiRadioButtonGroup8.Controls.Add(this.uiLabel7);
            this.uiRadioButtonGroup8.Controls.Add(this.ud_loss);
            this.uiRadioButtonGroup8.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiRadioButtonGroup8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButtonGroup8.ForeColor = System.Drawing.Color.Red;
            this.uiRadioButtonGroup8.Location = new System.Drawing.Point(438, 553);
            this.uiRadioButtonGroup8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup8.Name = "uiRadioButtonGroup8";
            this.uiRadioButtonGroup8.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup8.RectColor = System.Drawing.Color.Black;
            this.uiRadioButtonGroup8.Size = new System.Drawing.Size(201, 123);
            this.uiRadioButtonGroup8.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButtonGroup8.TabIndex = 129;
            this.uiRadioButtonGroup8.Text = "出場停損停利 tick";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(23, 82);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(45, 23);
            this.uiLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel8.TabIndex = 148;
            this.uiLabel8.Text = "停利";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ud_earn
            // 
            this.ud_earn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ud_earn.Location = new System.Drawing.Point(83, 76);
            this.ud_earn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_earn.Maximum = 100;
            this.ud_earn.Minimum = -100;
            this.ud_earn.MinimumSize = new System.Drawing.Size(100, 0);
            this.ud_earn.Name = "ud_earn";
            this.ud_earn.Size = new System.Drawing.Size(100, 29);
            this.ud_earn.Style = Sunny.UI.UIStyle.Custom;
            this.ud_earn.TabIndex = 147;
            this.ud_earn.Text = "_uiIntegerUpDown1";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(23, 43);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(45, 23);
            this.uiLabel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel7.TabIndex = 146;
            this.uiLabel7.Text = "停損";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ud_loss
            // 
            this.ud_loss.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ud_loss.Location = new System.Drawing.Point(83, 37);
            this.ud_loss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_loss.Maximum = 100;
            this.ud_loss.Minimum = -100;
            this.ud_loss.MinimumSize = new System.Drawing.Size(100, 0);
            this.ud_loss.Name = "ud_loss";
            this.ud_loss.Size = new System.Drawing.Size(100, 29);
            this.ud_loss.Style = Sunny.UI.UIStyle.Custom;
            this.ud_loss.TabIndex = 127;
            this.ud_loss.Text = "_uiIntegerUpDown1";
            this.ud_loss.Value = 5;
            // 
            // uiRadioButtonGroup9
            // 
            this.uiRadioButtonGroup9.Controls.Add(this.txt_discount);
            this.uiRadioButtonGroup9.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiRadioButtonGroup9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButtonGroup9.ForeColor = System.Drawing.Color.Red;
            this.uiRadioButtonGroup9.Location = new System.Drawing.Point(438, 698);
            this.uiRadioButtonGroup9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup9.Name = "uiRadioButtonGroup9";
            this.uiRadioButtonGroup9.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup9.RectColor = System.Drawing.Color.Black;
            this.uiRadioButtonGroup9.Size = new System.Drawing.Size(201, 69);
            this.uiRadioButtonGroup9.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButtonGroup9.TabIndex = 149;
            this.uiRadioButtonGroup9.Text = "手續費折數";
            // 
            // txt_discount
            // 
            this.txt_discount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_discount.DoubleValue = 2.8D;
            this.txt_discount.FillColor = System.Drawing.Color.White;
            this.txt_discount.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_discount.Location = new System.Drawing.Point(78, 32);
            this.txt_discount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_discount.Maximum = 2147483647D;
            this.txt_discount.Minimum = -2147483648D;
            this.txt_discount.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Padding = new System.Windows.Forms.Padding(5);
            this.txt_discount.Size = new System.Drawing.Size(44, 29);
            this.txt_discount.Style = Sunny.UI.UIStyle.Custom;
            this.txt_discount.TabIndex = 156;
            this.txt_discount.Text = "2.8";
            // 
            // uiRadioButtonGroup10
            // 
            this.uiRadioButtonGroup10.Controls.Add(this.rdb_proDaytradeNo);
            this.uiRadioButtonGroup10.Controls.Add(this.rdb_proDaytradeYes);
            this.uiRadioButtonGroup10.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiRadioButtonGroup10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButtonGroup10.ForeColor = System.Drawing.Color.Red;
            this.uiRadioButtonGroup10.Location = new System.Drawing.Point(438, 204);
            this.uiRadioButtonGroup10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup10.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup10.Name = "uiRadioButtonGroup10";
            this.uiRadioButtonGroup10.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup10.RectColor = System.Drawing.Color.Black;
            this.uiRadioButtonGroup10.Size = new System.Drawing.Size(201, 63);
            this.uiRadioButtonGroup10.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButtonGroup10.TabIndex = 129;
            this.uiRadioButtonGroup10.Text = "是否為當沖";
            // 
            // rdb_proDaytradeNo
            // 
            this.rdb_proDaytradeNo.BackColor = System.Drawing.Color.Transparent;
            this.rdb_proDaytradeNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_proDaytradeNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_proDaytradeNo.Location = new System.Drawing.Point(129, 28);
            this.rdb_proDaytradeNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_proDaytradeNo.Name = "rdb_proDaytradeNo";
            this.rdb_proDaytradeNo.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_proDaytradeNo.Size = new System.Drawing.Size(57, 29);
            this.rdb_proDaytradeNo.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_proDaytradeNo.TabIndex = 1;
            this.rdb_proDaytradeNo.Text = "否";
            // 
            // rdb_proDaytradeYes
            // 
            this.rdb_proDaytradeYes.BackColor = System.Drawing.Color.Transparent;
            this.rdb_proDaytradeYes.Checked = true;
            this.rdb_proDaytradeYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_proDaytradeYes.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_proDaytradeYes.Location = new System.Drawing.Point(30, 28);
            this.rdb_proDaytradeYes.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_proDaytradeYes.Name = "rdb_proDaytradeYes";
            this.rdb_proDaytradeYes.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_proDaytradeYes.Size = new System.Drawing.Size(82, 29);
            this.rdb_proDaytradeYes.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_proDaytradeYes.TabIndex = 0;
            this.rdb_proDaytradeYes.Text = "是";
            // 
            // uiRadioButtonGroup11
            // 
            this.uiRadioButtonGroup11.Controls.Add(this.uiLabel9);
            this.uiRadioButtonGroup11.Controls.Add(this.ud_InTick);
            this.uiRadioButtonGroup11.Controls.Add(this.rdb_InUpper);
            this.uiRadioButtonGroup11.Controls.Add(this.rdb_InUnder);
            this.uiRadioButtonGroup11.Controls.Add(this.rdb_InOpen);
            this.uiRadioButtonGroup11.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiRadioButtonGroup11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButtonGroup11.ForeColor = System.Drawing.Color.Red;
            this.uiRadioButtonGroup11.Location = new System.Drawing.Point(438, 368);
            this.uiRadioButtonGroup11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup11.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup11.Name = "uiRadioButtonGroup11";
            this.uiRadioButtonGroup11.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup11.RectColor = System.Drawing.Color.Black;
            this.uiRadioButtonGroup11.Size = new System.Drawing.Size(201, 157);
            this.uiRadioButtonGroup11.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButtonGroup11.TabIndex = 129;
            this.uiRadioButtonGroup11.Text = "進場價格";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.uiLabel9.Location = new System.Drawing.Point(150, 123);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(41, 23);
            this.uiLabel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel9.TabIndex = 165;
            this.uiLabel9.Text = "tick";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ud_InTick
            // 
            this.ud_InTick.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ud_InTick.Location = new System.Drawing.Point(96, 92);
            this.ud_InTick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_InTick.Maximum = 100;
            this.ud_InTick.Minimum = -100;
            this.ud_InTick.MinimumSize = new System.Drawing.Size(100, 0);
            this.ud_InTick.Name = "ud_InTick";
            this.ud_InTick.Size = new System.Drawing.Size(100, 29);
            this.ud_InTick.Style = Sunny.UI.UIStyle.Custom;
            this.ud_InTick.TabIndex = 128;
            this.ud_InTick.Text = "_uiIntegerUpDown1";
            this.ud_InTick.Value = 3;
            // 
            // rdb_InUpper
            // 
            this.rdb_InUpper.BackColor = System.Drawing.Color.Transparent;
            this.rdb_InUpper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_InUpper.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_InUpper.Location = new System.Drawing.Point(18, 115);
            this.rdb_InUpper.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_InUpper.Name = "rdb_InUpper";
            this.rdb_InUpper.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_InUpper.Size = new System.Drawing.Size(82, 29);
            this.rdb_InUpper.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_InUpper.TabIndex = 3;
            this.rdb_InUpper.Text = "平盤上";
            // 
            // rdb_InUnder
            // 
            this.rdb_InUnder.BackColor = System.Drawing.Color.Transparent;
            this.rdb_InUnder.Checked = true;
            this.rdb_InUnder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_InUnder.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_InUnder.Location = new System.Drawing.Point(18, 76);
            this.rdb_InUnder.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_InUnder.Name = "rdb_InUnder";
            this.rdb_InUnder.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_InUnder.Size = new System.Drawing.Size(82, 29);
            this.rdb_InUnder.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_InUnder.TabIndex = 2;
            this.rdb_InUnder.Text = "平盤下";
            // 
            // rdb_InOpen
            // 
            this.rdb_InOpen.BackColor = System.Drawing.Color.Transparent;
            this.rdb_InOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_InOpen.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rdb_InOpen.Location = new System.Drawing.Point(18, 36);
            this.rdb_InOpen.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_InOpen.Name = "rdb_InOpen";
            this.rdb_InOpen.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdb_InOpen.Size = new System.Drawing.Size(82, 29);
            this.rdb_InOpen.Style = Sunny.UI.UIStyle.Custom;
            this.rdb_InOpen.TabIndex = 1;
            this.rdb_InOpen.Text = "開盤價";
            // 
            // uiToolTip1
            // 
            this.uiToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.uiToolTip1.OwnerDraw = true;
            // 
            // ckcb_parse
            // 
            this.ckcb_parse.AutoSize = true;
            this.ckcb_parse.Checked = true;
            this.ckcb_parse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcb_parse.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ckcb_parse.Location = new System.Drawing.Point(77, 559);
            this.ckcb_parse.Name = "ckcb_parse";
            this.ckcb_parse.Size = new System.Drawing.Size(56, 23);
            this.ckcb_parse.TabIndex = 147;
            this.ckcb_parse.Text = "Yes";
            this.ckcb_parse.UseVisualStyleBackColor = true;
            // 
            // uiLine12
            // 
            this.uiLine12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.uiLine12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine12.ForeColor = System.Drawing.Color.Red;
            this.uiLine12.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiLine12.Location = new System.Drawing.Point(34, 519);
            this.uiLine12.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine12.Name = "uiLine12";
            this.uiLine12.Size = new System.Drawing.Size(140, 29);
            this.uiLine12.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine12.TabIndex = 146;
            this.uiLine12.Text = "啟動時爬資料";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 807);
            this.Controls.Add(this.uiRadioButtonGroup11);
            this.Controls.Add(this.uiRadioButtonGroup10);
            this.Controls.Add(this.uiRadioButtonGroup9);
            this.Controls.Add(this.uiRadioButtonGroup8);
            this.Controls.Add(this.uiRadioButtonGroup2);
            this.Controls.Add(this.uiLine5);
            this.Controls.Add(this.uiRadioButtonGroup5);
            this.Controls.Add(this.uiGroupBox5);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.uiGroupBox4);
            this.Controls.Add(this.uiGroupBox3);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.tabC_Strategy);
            this.Controls.Add(this.dgv_result);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Center";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.tabC_Strategy.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.uiRadioButtonGroup13.ResumeLayout(false);
            this.uiRadioButtonGroup6.ResumeLayout(false);
            this.uiRadioButtonGroup4.ResumeLayout(false);
            this.uiRadioButtonGroup3.ResumeLayout(false);
            this.uiRadioButtonGroup1.ResumeLayout(false);
            this.uiCheckBoxGroup1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.uiCheckBoxGroup2.ResumeLayout(false);
            this.uiRadioButtonGroup12.ResumeLayout(false);
            this.uiRadioButtonGroup7.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.uiRadioButtonGroup15.ResumeLayout(false);
            this.uiCheckBoxGroup3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.uiCheckBoxGroup4.ResumeLayout(false);
            this.tabPage13.ResumeLayout(false);
            this.uiRadioButtonGroup2.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox4.ResumeLayout(false);
            this.uiGroupBox5.ResumeLayout(false);
            this.uiGroupBox5.PerformLayout();
            this.uiRadioButtonGroup5.ResumeLayout(false);
            this.uiRadioButtonGroup8.ResumeLayout(false);
            this.uiRadioButtonGroup9.ResumeLayout(false);
            this.uiRadioButtonGroup10.ResumeLayout(false);
            this.uiRadioButtonGroup11.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem capitalDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private Sunny.UI.UIDataGridView dgv_result;
        private Sunny.UI.UITabControlMenu tabC_Strategy;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIIntegerUpDown UpDown_closePrice;
        private Sunny.UI.UIRadioButton rdb_bigger;
        private Sunny.UI.UIRadioButton rdb_smaller;
        private Sunny.UI.UIRadioButton rdb_ultimate;
        private Sunny.UI.UIIntegerUpDown ud_avgDays;
        private Sunny.UI.UIIntegerUpDown ud_pickquantity;
        private Sunny.UI.UILine uiLine3;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILine uiLine4;
        private Sunny.UI.UILine uiLine6;
        private Sunny.UI.UIIntegerUpDown ud_testDays;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup3;
        private Sunny.UI.UIRadioButton rdb_s1MajorNone;
        private Sunny.UI.UIRadioButton rdb_s1MajorBuy;
        private Sunny.UI.UIRadioButton rdb_s1MajorSell;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup2;
        private Sunny.UI.UIRadioButton rdb_s1ProfitLong;
        private Sunny.UI.UIRadioButton rdb_s1ProfitShort;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup1;
        private Sunny.UI.UIIntegerUpDown ud_s1TurnoverSmaller;
        private Sunny.UI.UICheckBox ckcb_s1TurnoverSmaller;
        private Sunny.UI.UIIntegerUpDown ud_s1TurnoverBigger;
        private Sunny.UI.UICheckBox ckcb_s1TurnoverBigger;
        private Sunny.UI.UIIntegerUpDown ud_s1TurnoverTop;
        private Sunny.UI.UICheckBox ckcb_s1TurnoverTop;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup4;
        private Sunny.UI.UIRadioButton rdb_s1HighNone;
        private Sunny.UI.UIRadioButton rdb_s1HighYes;
        private Sunny.UI.UIRadioButton rdb_s1HighNo;
        private System.Windows.Forms.TabPage tabPage3;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup2;
        private Sunny.UI.UIDatePicker dp_start;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIDatePicker dp_end;
        private Sunny.UI.UILine uiLine8;
        private Sunny.UI.UILine uiLine7;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UITextBox txt_fileName;
        private Sunny.UI.UILine uiLine9;
        private Sunny.UI.UISymbolButton btn_excelOutput;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UILabel lb_status;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private Sunny.UI.UIComboBox cb_Strategy;
        private Sunny.UI.UISymbolButton btn_run;
        private Sunny.UI.UISymbolButton btn_pause;
        private Sunny.UI.UIGroupBox uiGroupBox5;
        private Sunny.UI.UIDatePicker dp_pickDate;
        private Sunny.UI.UIButton btn_pick;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup5;
        private Sunny.UI.UIRadioButton rdb_notsave;
        private Sunny.UI.UIRadioButton rdb_save;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private System.Windows.Forms.CheckBox ckcb_daytrade;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup6;
        private Sunny.UI.UIRadioButton rdb_highReal;
        private Sunny.UI.UIRadioButton rdb_highVirtual;
        private Sunny.UI.UILine uiLine10;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private Sunny.UI.UISymbolButton btn_smartExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIIntegerUpDown ud_smLoss;
        private Sunny.UI.UIIntegerUpDown ud_smProfit;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILine uiLine11;
        private System.Windows.Forms.ToolStripMenuItem MarkToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TabPage tabPage13;
        private Sunny.UI.UICheckBox ckcb_tPrice;
        private Sunny.UI.UIIntegerUpDown ud_tPrice;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup7;
        private Sunny.UI.UIRadioButton rdb_vibSmall;
        private Sunny.UI.UIRadioButton rdb_vibBig;
        private Sunny.UI.UITextBox txt_vibValue;
        private Sunny.UI.UIRadioButton rdb_vidNone;
        private Sunny.UI.UITextBox txt_c2;
        private Sunny.UI.UITextBox txt_c1;
        private Sunny.UI.UIRadioButton rdb_between;
        private Sunny.UI.UICheckBox uiCheckBox8;
        private Sunny.UI.UICheckBox uiCheckBox7;
        private Sunny.UI.UIIntegerUpDown uiIntegerUpDown5;
        private Sunny.UI.UICheckBox uiCheckBox4;
        private Sunny.UI.UIIntegerUpDown uiIntegerUpDown6;
        private Sunny.UI.UICheckBox uiCheckBox5;
        private Sunny.UI.UIIntegerUpDown uiIntegerUpDown7;
        private Sunny.UI.UICheckBox uiCheckBox6;
        private Sunny.UI.UILine uiLine5;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup8;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIIntegerUpDown ud_earn;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIIntegerUpDown ud_loss;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup9;
        private Sunny.UI.UITextBox txt_discount;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup10;
        private Sunny.UI.UIRadioButton rdb_proDaytradeNo;
        private Sunny.UI.UIRadioButton rdb_proDaytradeYes;
        private Sunny.UI.UITextBox txt_aprofit;
        private Sunny.UI.UITextBox txt_bprofit;
        private Sunny.UI.UITextBox txt_aloss;
        private Sunny.UI.UITextBox txt_bloss;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup11;
        private Sunny.UI.UIRadioButton rdb_InUpper;
        private Sunny.UI.UIRadioButton rdb_InUnder;
        private Sunny.UI.UIRadioButton rdb_InOpen;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UIIntegerUpDown ud_InTick;
        private Sunny.UI.UIToolTip uiToolTip1;
        private Sunny.UI.UICheckBox ckcb_highStopLoss;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup4;
        private Sunny.UI.UIRadioButton rdb_S3Turnoverrate;
        private Sunny.UI.UIIntegerUpDown ud_S3Turnoverrate;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UICheckBox ckcb_highVolume;
        private Sunny.UI.UIIntegerUpDown ud_highVolume;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup15;
        private Sunny.UI.UIRadioButton rdb_S2topLineFalse;
        private Sunny.UI.UIRadioButton rdb_S2topLineTrue;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup3;
        private Sunny.UI.UIRadioButton rdb_S2Turnoverrate;
        private Sunny.UI.UIIntegerUpDown ud_S2Turnoverrate;
        private Sunny.UI.UISymbolLabel uiSymbolLabel8;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup12;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UICheckBox ckcb_notHighDis;
        private Sunny.UI.UITextBox txt_notHighDisValue;
        private System.Windows.Forms.ToolStripMenuItem smartPickerToolStripMenuItem;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup13;
        private Sunny.UI.UIRadioButton rdb_TClose;
        private Sunny.UI.UIRadioButton rdb_THigh;
        private Sunny.UI.UIRadioButton rdb_noneMax;
        private Sunny.UI.UIRadioButton rdb_notMax;
        private Sunny.UI.UIRadioButton rdb_max;
        private Sunny.UI.UICheckBox ckcb_redK;
        private Sunny.UI.UICheckBox ckcb_s1FlDown;
        private Sunny.UI.UICheckBox ckcb_s1FlUp;
        private System.Windows.Forms.ToolStripMenuItem DonateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QueryToolStripMenuItem;
        private Sunny.UI.UICheckBox ckcb_dealpriceOrder;
        private Sunny.UI.UICheckBox ckcb_displayDealpriceAvg;
        private System.Windows.Forms.ToolStripMenuItem analyzeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setIniToolStripMenuItem;
        private System.Windows.Forms.CheckBox ckcb_parse;
        private Sunny.UI.UILine uiLine12;
    }
}

