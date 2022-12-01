using System;
using System.Linq;
using System.Windows.Forms;
using FitCal.DAL;
using FitCal.DATA.Entities;
using FitCal.DATA.Enums;
using FitCal.UI.Repositories;

namespace FitCal.UI
{
    public partial class FrmMain : Form
    {
        FitCalContext _context;
        FrmRegister _frmRegister;
        FrmAdmin _frmAdmin;
        FrmChangePassword _frmChangePassword;
        FrmUser _frmUser;
        FrmInfo _frmInfo;
        public User _userMain;

        public FrmMain()
        {
            InitializeComponent();
            _context = new FitCalContext();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _frmRegister = new FrmRegister();
            _frmAdmin = new FrmAdmin();
            _frmChangePassword = new FrmChangePassword();
            _frmUser = new FrmUser();
            _frmInfo = new FrmInfo();
        }

        private void cbxShowPassword_MouseHover(object sender, EventArgs e)
        {
            //pop-up message box
            toolTip1.Show("Parolayı göster", cbxShowPassword);
        }

        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //show password
            if (cbxShowPassword.Checked)
            {
                txtUserPassword.PasswordChar = '\0';
            }
            else
            {
                txtUserPassword.PasswordChar = '*';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmRegister.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //login the user
            string username = txtUserName.Text;
            string password = Method.Sha256_hash(txtUserPassword.Text);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı veya parola boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _userMain = _context.Users.FirstOrDefault(x => x.Email.ToString() == username && x.Password.Text == password);
            if (_userMain == null || _userMain.IsActive == UserStates.Passive)
            {
                MessageBox.Show("Kullanıcı adı veya parola hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Giriş başarılı", "Hoşgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (_userMain.UserType == UserTypes.Admin)
                {
                    _frmAdmin = new FrmAdmin();
                    _frmAdmin._userAdmin = _userMain;
                    this.Hide();
                    _frmAdmin.Show();
                }
                else
                {
                    //pass the user to the user form
                    _frmUser = new FrmUser();
                    _frmUser._user = this._userMain;
                    this.Hide();
                    _frmUser.Show();
                }
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmChangePassword.Show();
        }

        private void lnkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            _frmInfo.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ask for confirmation
            DialogResult result = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        //accept enter key as submit button
        private void txtUserPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
