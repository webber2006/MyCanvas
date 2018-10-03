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
    public partial class SerchingImageDlg : Form
    {
        public SerchingImageDlg()
        {
            InitializeComponent();
        }        

        private void OkayBtn_Click(object sender, EventArgs e)
        {
            String url = WebTextBox.Text;
            webBrowserMain.Navigate(url);            
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            webBrowserMain.GoBack();
        }

        private void ForwardBtn_Click(object sender, EventArgs e)
        {

            webBrowserMain.GoForward();
        }

        private void WebTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                OkayBtn_Click(sender, e);
            }
        }
    }
}
