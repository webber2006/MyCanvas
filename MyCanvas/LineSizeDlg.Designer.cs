namespace MyCanvas
{
    partial class LineSizeDlg
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
            this.LineSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LineSizeOKBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LineStyleComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LineSizeComboBox
            // 
            this.LineSizeComboBox.FormattingEnabled = true;
            this.LineSizeComboBox.Items.AddRange(new object[] {
            "1pt",
            "2pt",
            "3pt",
            "4pt",
            "5pt",
            "6pt",
            "7pt",
            "8pt",
            "9pt",
            "10pt"});
            this.LineSizeComboBox.Location = new System.Drawing.Point(72, 6);
            this.LineSizeComboBox.Name = "LineSizeComboBox";
            this.LineSizeComboBox.Size = new System.Drawing.Size(143, 20);
            this.LineSizeComboBox.TabIndex = 0;
            this.LineSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.LineSizeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "LineSize";
            // 
            // LineSizeOKBtn
            // 
            this.LineSizeOKBtn.Location = new System.Drawing.Point(142, 91);
            this.LineSizeOKBtn.Name = "LineSizeOKBtn";
            this.LineSizeOKBtn.Size = new System.Drawing.Size(75, 23);
            this.LineSizeOKBtn.TabIndex = 2;
            this.LineSizeOKBtn.Text = "적용";
            this.LineSizeOKBtn.UseVisualStyleBackColor = true;
            this.LineSizeOKBtn.Click += new System.EventHandler(this.LineSizeOKBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "LineStyle";
            // 
            // LineStyleComboBox
            // 
            this.LineStyleComboBox.FormattingEnabled = true;
            this.LineStyleComboBox.Items.AddRange(new object[] {
            "Dot",
            "Dash",
            "DashDot",
            "DashDotDot"});
            this.LineStyleComboBox.Location = new System.Drawing.Point(74, 50);
            this.LineStyleComboBox.Name = "LineStyleComboBox";
            this.LineStyleComboBox.Size = new System.Drawing.Size(141, 20);
            this.LineStyleComboBox.TabIndex = 4;
            this.LineStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.LineStyleComboBox_SelectedIndexChanged);
            // 
            // LineSizeDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 130);
            this.Controls.Add(this.LineStyleComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LineSizeOKBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LineSizeComboBox);
            this.Name = "LineSizeDlg";
            this.Text = "LineSize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LineSizeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LineSizeOKBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LineStyleComboBox;
    }
}