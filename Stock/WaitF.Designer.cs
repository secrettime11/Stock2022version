namespace Stock
{
    partial class WaitF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitF));
            this.uiWaitingBar1 = new Sunny.UI.UIWaitingBar();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiWaitingBar1
            // 
            this.uiWaitingBar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiWaitingBar1.Location = new System.Drawing.Point(8, 12);
            this.uiWaitingBar1.MinimumSize = new System.Drawing.Size(70, 23);
            this.uiWaitingBar1.Name = "uiWaitingBar1";
            this.uiWaitingBar1.Size = new System.Drawing.Size(216, 29);
            this.uiWaitingBar1.Style = Sunny.UI.UIStyle.Orange;
            this.uiWaitingBar1.TabIndex = 1;
            this.uiWaitingBar1.Text = "資料載入中";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.Red;
            this.uiLabel1.Location = new System.Drawing.Point(63, 44);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(109, 23);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "資料載入中...";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WaitF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(231, 73);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiWaitingBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WaitF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaitF";
            this.Activated += new System.EventHandler(this.WaitF_Activated);
            this.Load += new System.EventHandler(this.WaitF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIWaitingBar uiWaitingBar1;
        private Sunny.UI.UILabel uiLabel1;
    }
}