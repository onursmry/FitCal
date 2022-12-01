using FitCal.DATA.Entities;
using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using FitCal.DAL;
using FitCal.DATA.Enums;
using FitCal.UI.Repositories;

namespace FitCal.UI
{
    public partial class FrmRegister : Form
    {
        private FitCalContext _context;
        private Form _frmMain;
        private User _user = new User();
        Password _password = new Password();
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            _context = new FitCalContext();
            _frmMain = new FrmMain();
            rdbMale.Checked = true;
            cbxSecurity.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add the user to the database
            _user.FirstName = txtFirstName.Text;
            _user.LastName = txtLastName.Text;

            if (Method.IsValidEmail(txtEmail.Text))
            {
                _user.Email = txtEmail.Text;
            }
            else if (txtEmail.Text != txtEmail2.Text)
            {
                MessageBox.Show("E-posta adresleri uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //check password and confirm password
            if (txtPassword.Text == txtPassword2.Text)
            {
                if (Method.CheckForUpperCase(txtPassword.Text) && Method.CheckForLowerCase(txtPassword.Text) && Method.CheckForSpecialCharacter(txtPassword.Text))
                {
                    _password.Text = Method.Sha256_hash(txtPassword.Text);
                    _password.SecurityWord = txtSecurityKey.Text;
                    _password.CreatedDate = DateTime.Now;
                    _password.SecurityQuestion = cbxSecurity.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Parola en az 1 büyük harf, 1 küçük harf ve 1 özel karakter içermelidir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Parolalar eşleşmiyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //check birthdate
            if (DateTime.Now.Year - dtpBirthDate.Value.Year >= 20 && DateTime.Now.Year - dtpBirthDate.Value.Year <= 30)
            {
                _user.BirthDate = dtpBirthDate.Value.Date;
            }
            else
            {
                MessageBox.Show("Kayıt olmak için 20-30 yaş arasında olmalısınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _user.Height = Convert.ToByte(txtHeight.Text);
            _user.Weight = Convert.ToDouble(txtWeight.Text);
            _user.UserType = UserTypes.User;
            _user.IsActive = UserStates.Active;
            _user.CreatedDate = DateTime.Now;
            _user.Password = _password;

            if (rdbFemale.Checked)
            {
                _user.Gender = Genders.Kadın;
            }
            else
            {
                _user.Gender = Genders.Erkek;
            }

            if (Method.CheckIfBlankField(gbxUserRegistration))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else if (_context.Users.Any(x => x.Email == _user.Email))
            {
                DialogResult dr = MessageBox.Show("Bu email ile kayıtlı üye bulunmaktadır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    txtEmail.Text = "";
                    txtEmail2.Text = "";
                }
                return;
            }
            else
            {
                _context.Users.Add(_user);
                _context.SaveChanges();
                MessageBox.Show("Üye başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Hide();
            _frmMain.Show();

        }


        private void DigitsOnly(object sender, KeyPressEventArgs keyPressEvent)
        {
            //Sayı harici giriş yapmayı engelle

            if (!char.IsControl(keyPressEvent.KeyChar) && !char.IsDigit(keyPressEvent.KeyChar))
            {
                keyPressEvent.Handled = true;
            }

        }

        private void DigitsDecimal(object sender, KeyPressEventArgs keyPressEvent)
        {
            //Sayı harici giriş yapmayı engelle

            if (!char.IsControl(keyPressEvent.KeyChar) && !char.IsDigit(keyPressEvent.KeyChar) && (keyPressEvent.KeyChar != '.'))
            {
                keyPressEvent.Handled = true;
            }

            if ((keyPressEvent.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                keyPressEvent.Handled = true;
            }
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            //add photo for user
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Lütfen bir fotoğraf seçiniz.";
            ofd.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxUserPhoto.ImageLocation = ofd.FileName;
            }
            else
            {
                MessageBox.Show("Fotoğraf seçilmedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //save photopath to database
            string photoPath = pbxUserPhoto.ImageLocation;
            _user.PhotoPath = photoPath;
        }

        private void FrmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Kayıt işlemini iptal etmek istediğinize emin misiniz?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                _frmMain.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //tooltip hint show password hint
            ttpPasswordHint.Show("Parolanız en 8 karakterden oluşmalı ve büyük harf, küçük harf, özel karakter içermelidir", txtPassword, 8000);
        }
    }
}
