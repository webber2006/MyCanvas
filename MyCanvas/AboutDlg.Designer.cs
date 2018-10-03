namespace MyCanvas
{
    partial class AboutDlg
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
            this.ProgramInfo = new System.Windows.Forms.Label();
            this.LicenseInfo = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProgramInfo
            // 
            this.ProgramInfo.AutoSize = true;
            this.ProgramInfo.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProgramInfo.Location = new System.Drawing.Point(12, 9);
            this.ProgramInfo.Name = "ProgramInfo";
            this.ProgramInfo.Size = new System.Drawing.Size(140, 19);
            this.ProgramInfo.TabIndex = 0;
            this.ProgramInfo.Text = "myCanvas 1.0";
            // 
            // LicenseInfo
            // 
            this.LicenseInfo.Location = new System.Drawing.Point(12, 34);
            this.LicenseInfo.Name = "LicenseInfo";
            this.LicenseInfo.Size = new System.Drawing.Size(140, 18);
            this.LicenseInfo.TabIndex = 1;
            this.LicenseInfo.Text = "윈도우 프로그래밍";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(115, 97);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 2;
            this.OkBtn.Text = "확인";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // AboutDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 125);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.LicenseInfo);
            this.Controls.Add(this.ProgramInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDlg";
            this.Text = "myCanvas 정보";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProgramInfo;
        private System.Windows.Forms.Label LicenseInfo;
        private System.Windows.Forms.Button OkBtn;
    }
}