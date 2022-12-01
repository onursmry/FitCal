using System;
using System.Drawing;
using System.Windows.Forms;
using FitCal.DAL;
using FitCal.DATA.Entities;
using FitCal.DATA.Enums;

namespace FitCal.UI
{
    public partial class FrmUserInfo : Form
    {
        FitCalContext _context;
        FrmUser _frmUser;
        FrmMain _frmMain;
        public User _userUserInfo;
        public FrmUserInfo()
        {
            InitializeComponent();
        }

        private void FrmUserInfo_Load(object sender, EventArgs e)
        {
            _context = new FitCalContext();
            //show user info
            txtFirstName.Text = _userUserInfo.FirstName;
            txtLastName.Text = _userUserInfo.LastName;
            txtEmail.Text = _userUserInfo.Email.ToString();
            txtHeight.Text = _userUserInfo.Height.ToString();
            txtWeight.Text = _userUserInfo.Weight.ToString();
            dtpBirthDate.Value = _userUserInfo.BirthDate;
            if (_userUserInfo.PhotoPath != null)
            {
                pbxProfilePicture.Image = Image.FromFile(_userUserInfo.PhotoPath);
            }
            txtGender.Text = _userUserInfo.Gender.ToString();
            txtAge.Text = (DateTime.Now.Year - _userUserInfo.BirthDate.Year).ToString();
            txtBMI.Text = Math.Round((_userUserInfo.Weight / (_userUserInfo.Height * _userUserInfo.Height))*10000, 2).ToString();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            //Get User by UserId
            User user = _context.Users.Find(_userUserInfo.UserId);

            //update user info
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.BirthDate = dtpBirthDate.Value;
            user.Height = Convert.ToByte(txtHeight.Text);
            user.Weight = Convert.ToDouble(txtWeight.Text);
            
            _context.SaveChanges();
            MessageBox.Show("Kullanıcı bilgileri başarılı bir şekilde güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            _frmMain = new FrmMain();
            _frmUser = new FrmUser();

            User user = _context.Users.Find(_userUserInfo.UserId);

            //make user's account passive
            user.IsActive = UserStates.Passive;
            _context.SaveChanges();
            MessageBox.Show("Hesabınız silinmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            _frmUser.Hide();
            _frmMain.Show();
        }

        private void btnUpdatePhoto_Click(object sender, EventArgs e)
        {
            User user = _context.Users.Find(_userUserInfo.UserId);

            //change user's profile picture
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Lütfen bir fotoğraf seçiniz";
            ofd.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxProfilePicture.Image = Image.FromFile(ofd.FileName);
                user.PhotoPath = ofd.FileName;
                _context.SaveChanges();
                MessageBox.Show("Profil fotoğrafınız başarılı bir şekilde güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmUserInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
