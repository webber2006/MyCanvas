namespace MyCanvas
{
    partial class SerchingImageDlg
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
            this.WebTextBox = new System.Windows.Forms.TextBox();
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.ForwardBtn = new System.Windows.Forms.Button();
            this.OkayBtn = new System.Windows.Forms.Button();
            this.webBrowserMain = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WebTextBox
            // 
            this.WebTextBox.Location = new System.Drawing.Point(88, 14);
            this.WebTextBox.Name = "WebTextBox";
            this.WebTextBox.Size = new System.Drawing.Size(879, 21);
            this.WebTextBox.TabIndex = 0;
            this.WebTextBox.WordWrap = false;
            this.WebTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WebTextBox_KeyDown);
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.ForeColor = System.Drawing.Color.Red;
            this.GoBackBtn.Location = new System.Drawing.Point(12, 12);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(32, 23);
            this.GoBackBtn.TabIndex = 1;
            this.GoBackBtn.Text = "<";
            this.GoBackBtn.UseVisualStyleBackColor = true;
            this.GoBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // ForwardBtn
            // 
            this.ForwardBtn.Location = new System.Drawing.Point(50, 12);
            this.ForwardBtn.Name = "ForwardBtn";
            this.ForwardBtn.Size = new System.Drawing.Size(32, 23);
            this.ForwardBtn.TabIndex = 2;
            this.ForwardBtn.Text = ">";
            this.ForwardBtn.UseVisualStyleBackColor = true;
            this.ForwardBtn.Click += new System.EventHandler(this.ForwardBtn_Click);
            // 
            // OkayBtn
            // 
            this.OkayBtn.Location = new System.Drawing.Point(973, 12);
            this.OkayBtn.Name = "OkayBtn";
            this.OkayBtn.Size = new System.Drawing.Size(76, 23);
            this.OkayBtn.TabIndex = 3;
            this.OkayBtn.Text = "확인";
            this.OkayBtn.UseVisualStyleBackColor = true;
            this.OkayBtn.Click += new System.EventHandler(this.OkayBtn_Click);
            // 
            // webBrowserMain
            // 
            this.webBrowserMain.Location = new System.Drawing.Point(12, 42);
            this.webBrowserMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMain.Name = "webBrowserMain";
            this.webBrowserMain.Size = new System.Drawing.Size(1037, 657);
            this.webBrowserMain.TabIndex = 4;
            this.webBrowserMain.Url = new System.Uri("https://www.google.com/imghp?hl=ko", System.UriKind.Absolute);
            // 
            // SerchingImageDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 711);
            this.Controls.Add(this.webBrowserMain);
            this.Controls.Add(this.OkayBtn);
            this.Controls.Add(this.ForwardBtn);
            this.Controls.Add(this.GoBackBtn);
            this.Controls.Add(this.WebTextBox);
            this.Name = "SerchingImageDlg";
            this.Text = "SerchingImage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WebTextBox;
        private System.Windows.Forms.Button GoBackBtn;
        private System.Windows.Forms.Button ForwardBtn;
        private System.Windows.Forms.Button OkayBtn;
        private System.Windows.Forms.WebBrowser webBrowserMain;
    }
}