namespace MyCanvas
{
    partial class TextDlg
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
            this.FontGroup = new System.Windows.Forms.GroupBox();
            this.FontBtn = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.FontSize = new System.Windows.Forms.Label();
            this.FontName = new System.Windows.Forms.Label();
            this.txtContents = new System.Windows.Forms.TextBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.FontDlg = new System.Windows.Forms.FontDialog();
            this.FontGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // FontGroup
            // 
            this.FontGroup.Controls.Add(this.FontBtn);
            this.FontGroup.Controls.Add(this.txtSize);
            this.FontGroup.Controls.Add(this.txtFont);
            this.FontGroup.Controls.Add(this.FontSize);
            this.FontGroup.Controls.Add(this.FontName);
            this.FontGroup.Location = new System.Drawing.Point(12, 12);
            this.FontGroup.Name = "FontGroup";
            this.FontGroup.Size = new System.Drawing.Size(494, 51);
            this.FontGroup.TabIndex = 0;
            this.FontGroup.TabStop = false;
            this.FontGroup.Text = "Font";
            // 
            // FontBtn
            // 
            this.FontBtn.Location = new System.Drawing.Point(372, 14);
            this.FontBtn.Name = "FontBtn";
            this.FontBtn.Size = new System.Drawing.Size(105, 23);
            this.FontBtn.TabIndex = 5;
            this.FontBtn.Text = "글꼴 변경";
            this.FontBtn.UseVisualStyleBackColor = true;
            this.FontBtn.Click += new System.EventHandler(this.FontBtn_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(266, 14);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 21);
            this.txtSize.TabIndex = 3;
            this.txtSize.Text = "\"\"";
            // 
            // txtFont
            // 
            this.txtFont.Location = new System.Drawing.Point(41, 14);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(184, 21);
            this.txtFont.TabIndex = 2;
            this.txtFont.Text = "\"\"";
            // 
            // FontSize
            // 
            this.FontSize.AutoSize = true;
            this.FontSize.Location = new System.Drawing.Point(231, 17);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(29, 12);
            this.FontSize.TabIndex = 1;
            this.FontSize.Text = "크기";
            // 
            // FontName
            // 
            this.FontName.AutoSize = true;
            this.FontName.Location = new System.Drawing.Point(6, 17);
            this.FontName.Name = "FontName";
            this.FontName.Size = new System.Drawing.Size(29, 12);
            this.FontName.TabIndex = 0;
            this.FontName.Text = "글꼴";
            // 
            // txtContents
            // 
            this.txtContents.Location = new System.Drawing.Point(12, 69);
            this.txtContents.Multiline = true;
            this.txtContents.Name = "txtContents";
            this.txtContents.Size = new System.Drawing.Size(495, 240);
            this.txtContents.TabIndex = 4;
            this.txtContents.Text = "\"\"";
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(431, 315);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 6;
            this.OKBtn.Text = "확인";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // TextDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 346);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.txtContents);
            this.Controls.Add(this.FontGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextDlg";
            this.Text = "Text Out";
            this.FontGroup.ResumeLayout(false);
            this.FontGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FontGroup;
        private System.Windows.Forms.Button FontBtn;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.Label FontSize;
        private System.Windows.Forms.Label FontName;
        private System.Windows.Forms.TextBox txtContents;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.FontDialog FontDlg;
    }
}