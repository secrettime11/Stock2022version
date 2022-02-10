namespace Stock
{
    partial class AnalyzeForm
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
            this.btn_setDir = new System.Windows.Forms.Button();
            this.txt_dir = new System.Windows.Forms.TextBox();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.cb_sheet = new System.Windows.Forms.ComboBox();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.btn_file = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_setDir
            // 
            this.btn_setDir.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_setDir.Location = new System.Drawing.Point(190, 12);
            this.btn_setDir.Name = "btn_setDir";
            this.btn_setDir.Size = new System.Drawing.Size(75, 23);
            this.btn_setDir.TabIndex = 16;
            this.btn_setDir.Text = "預設資料夾";
            this.btn_setDir.UseVisualStyleBackColor = true;
            this.btn_setDir.Click += new System.EventHandler(this.btn_setDir_Click);
            // 
            // txt_dir
            // 
            this.txt_dir.Location = new System.Drawing.Point(12, 12);
            this.txt_dir.Multiline = true;
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.ReadOnly = true;
            this.txt_dir.Size = new System.Drawing.Size(162, 23);
            this.txt_dir.TabIndex = 15;
            // 
            // txt_FileName
            // 
            this.txt_FileName.Location = new System.Drawing.Point(12, 43);
            this.txt_FileName.Multiline = true;
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.ReadOnly = true;
            this.txt_FileName.Size = new System.Drawing.Size(253, 23);
            this.txt_FileName.TabIndex = 14;
            // 
            // cb_sheet
            // 
            this.cb_sheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sheet.FormattingEnabled = true;
            this.cb_sheet.Location = new System.Drawing.Point(12, 78);
            this.cb_sheet.Name = "cb_sheet";
            this.cb_sheet.Size = new System.Drawing.Size(162, 20);
            this.cb_sheet.TabIndex = 13;
            this.cb_sheet.SelectedIndexChanged += new System.EventHandler(this.cb_sheet_SelectedIndexChanged);
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToAddRows = false;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(12, 110);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowTemplate.Height = 24;
            this.dgv_data.Size = new System.Drawing.Size(888, 324);
            this.dgv_data.TabIndex = 12;
            this.dgv_data.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_data_RowPostPaint);
            // 
            // btn_file
            // 
            this.btn_file.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_file.Location = new System.Drawing.Point(190, 76);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(75, 22);
            this.btn_file.TabIndex = 11;
            this.btn_file.Text = "...";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.btn_setDir);
            this.Controls.Add(this.txt_dir);
            this.Controls.Add(this.txt_FileName);
            this.Controls.Add(this.cb_sheet);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.btn_file);
            this.Name = "AnalyzeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "分析表";
            this.Load += new System.EventHandler(this.AnalyzeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_setDir;
        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.TextBox txt_FileName;
        private System.Windows.Forms.ComboBox cb_sheet;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Button btn_file;
    }
}