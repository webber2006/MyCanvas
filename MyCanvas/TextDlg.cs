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
    public partial class TextDlg : Form
    {
        public TextDlg()
        {
            InitializeComponent();
        }

        private void FontBtn_Click(object sender, EventArgs e)
        {
            //폰트 대화상자 표시, 선택 후 텍스트 박스에 저장 표시
            if(FontDlg.ShowDialog(this) == DialogResult.OK)
            {
                txtFont.Text = FontDlg.Font.Name;
                txtSize.Text = Convert.ToString(FontDlg.Font.Size);
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Font newFont = new Font(txtFont.Text, Convert.ToSingle(txtSize.Text));
                MainForm.myFont = newFont;
                MainForm.Contents = txtContents.Text;
                this.Close();
            }
            catch(Exception fontE)
            {
                MessageBox.Show(this, "Font의 종류를 선택해 주세요.");
            }
        }
    }
}
