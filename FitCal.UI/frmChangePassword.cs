using System;
using System.Linq;
using System.Windows.Forms;
using FitCal.DAL;
using FitCal.DATA.Entities;
using FitCal.UI.Repositories;

namespace FitCal.UI
{
    public partial class FrmChangePassword : Form
    {
        FitCalContext _context;
        User _user;
        Password _password;
        FrmMain _frmMain;
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            _context = new FitCalContext();
            _frmMain = new FrmMain();
        }

        private void btnGetUser_Click(object sender, EventArgs e)
        {
            //find the user by email
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Lütfen e-posta adresinizi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                _user = _context.Users.FirstOrDefault(x => x.Email.ToString() == txtUserName.Text);
                if (_user == null)
                {
                    //if user is not found, show a message
                    MessageBox.Show("Kullanıcı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            //get user's password
            _password = _context.Passwords.FirstOrDefault(x => x.PasswordId == _user.UserId);
            if (_user != null)
            {
                //if user is found, show the user's name
                txtSecurityQuestion.Text = _user.Password.SecurityQuestion;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) && string.IsNullOrEmpty(txtPasswordRepeat.Text) && string.IsNullOrEmpty(txtSecurityKey.Text))
            {
                MessageBox.Show("Lütfen tüm bilgilerinizi doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSecurityKey.Text == _user.Password.SecurityWord)
            {
                if (txtPassword.Text.Length < 8 || txtPassword.Text.Length > 12 || txtPasswordRepeat.Text.Length < 8 || txtPasswordRepeat.Text.Length > 12)
                {
                    MessageBox.Show("Şifreniz 8 ile 12 karakter arasında olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Method.CheckForUpperCase(txtPassword.Text) && Method.CheckForLowerCase(txtPassword.Text) && Method.CheckForSpecialCharacter(txtPassword.Text) && txtPassword.Text == txtPasswordRepeat.Text && txtPassword.Text.Length >= 8 && txtPassword.Text.Length <= 12 && txtPasswordRepeat.Text.Length >= 8 && txtPasswordRepeat.Text.Length <= 12)
                {
                    _user.Password.Text = Method.Sha256_hash(txtPassword.Text);
                    MessageBox.Show("Şifre değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _context.SaveChanges();
                    this.Close();
                    _frmMain.Show();
                }
                else if (txtPassword.Text.Length < 8 || txtPassword.Text.Length > 12 || txtPasswordRepeat.Text.Length < 8 || txtPasswordRepeat.Text.Length > 12)
                {
                    MessageBox.Show("Şifreniz 8 ile 12 karakter aralığında olmalı ve En az 1 Büyük Harf, 1 Küçük Harf ve 1 Özel Karakter İçermelidir!.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("Şifreler eşleşmemektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Güvenlik kelimesi yanlış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void FrmChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmMain.Show();
        }
    }
}
