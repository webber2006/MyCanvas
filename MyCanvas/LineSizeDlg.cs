using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCanvas
{
    public partial class LineSizeDlg : Form
    {
        private MainForm Num = null;
        private MainForm Sty = null;
        int LineSizeNum;
        int StyNum;
        
        public LineSizeDlg(MainForm Num, MainForm Sty)
        {
            InitializeComponent();
            this.Num = Num;
            this.Sty = Sty;
        }
        

        private void LineSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LineSizeComboBox.SelectedItem.ToString() == "1pt")
            {
                LineSizeNum = 1;
            }
            else if(LineSizeComboBox.SelectedItem.ToString() == "2pt")
            {
                LineSizeNum = 2;
            }
            else if (LineSizeComboBox.SelectedItem.ToString() == "3pt")
            {
                LineSizeNum = 3;
            }
            else if (LineSizeComboBox.SelectedItem.ToString() == "4pt")
            {
                LineSizeNum = 4;
            }
            else if (LineSizeComboBox.SelectedItem.ToString() == "5pt")
            {
                LineSizeNum = 5;
            }
            else if (LineSizeComboBox.SelectedItem.ToString() == "6pt")
            {
                LineSizeNum = 6;
            }
            else if (LineSizeComboBox.SelectedItem.ToString() == "7pt")
            {
                LineSizeNum = 7;
            }
            else if (LineSizeComboBox.SelectedItem.ToString() == "8pt")
            {
                LineSizeNum = 8;
            }
            else if (LineSizeComboBox.SelectedItem.ToString() == "9pt")
            {
                LineSizeNum = 9;
            }
            else if (LineSizeComboBox.SelectedItem.ToString() == "10pt")
            {
                LineSizeNum = 10;
            }
    }

        private void LineSizeOKBtn_Click(object sender, EventArgs e)
        {
            Num.SetData1(LineSizeNum);
            Sty.SetData2(StyNum);
            Close();
        }

        private void LineStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)     //Style
        {
            if(LineStyleComboBox.SelectedItem.ToString() == "Dot")
            {
                StyNum = 1;
            }
            else if(LineStyleComboBox.SelectedItem.ToString() == "Dash")
            {
                StyNum = 2;
            }
            else if(LineStyleComboBox.SelectedItem.ToString() == "DashDot")
            {
                StyNum = 3;
            }
            else if(LineStyleComboBox.SelectedItem.ToString() == "DashDotDot")
            {
                StyNum = 4;
            }
        }
    }
}
