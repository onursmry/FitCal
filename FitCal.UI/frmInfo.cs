using System;
using System.Windows.Forms;

namespace FitCal.UI
{
    public partial class FrmInfo : Form
    {
        private FrmMain _frmMain;
        public FrmInfo()
        {
            InitializeComponent();
        }

        private void FrmInfo_Load(object sender, EventArgs e)
        {
            _frmMain = new FrmMain();
        }

        private void FrmInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmMain.Show();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmMain.Show();
        }
    }
}
