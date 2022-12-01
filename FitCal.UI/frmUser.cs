using FitCal.DAL;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FitCal.DATA.Entities;

namespace FitCal.UI
{
    public partial class FrmUser : Form
    {
        FitCalContext _context;
        private FrmMain _frmMain;
        private FrmMeal _frmMeal;
        private FrmUserInfo _frmUserInfo;
        FrmReport _frmReport;
        public User _user;
        public FrmUser()
        {
            InitializeComponent();
        }
        private void FrmUser_Load(object sender, EventArgs e)
        {
            _frmMain = new FrmMain();
            _frmMeal = new FrmMeal();
            _frmUserInfo = new FrmUserInfo();
            _frmReport = new FrmReport();
            _context = new FitCalContext();
            //show user info
            lblUserInfo.Text = _user.FirstName + " " + _user.LastName + "\n" + _user.Email + "\n" + "Boy: " + _user.Height + "\n" + "Kilo: " + _user.Weight + "\n" + "Doğum Tarihi: " + _user.BirthDate.ToShortDateString();
            if (_user.PhotoPath != null)
            {
                pbxAvatar.Image = Image.FromFile(_user.PhotoPath);
            }
            
            dgvMeals.DataSource = _context.Meals.Where(x => x.UserId == _user.UserId).ToList();
            dgvMeals.Columns["Foods"].Visible = false;
            dgvMeals.Columns["User"].Visible = false;
            dgvMeals.Columns["UserId"].Visible = false;

            //rename columns
            dgvMeals.Columns["MealId"].HeaderText = "Öğün ID";
            dgvMeals.Columns["Calories"].HeaderText = "Toplam Kalori";
            dgvMeals.Columns["Name"].HeaderText = "Öğün Adı";
            dgvMeals.Columns["CreatedDate"].HeaderText = "Oluşturulma Tarihi";
            dgvMeals.Columns["Notes"].HeaderText = "Öğün Açıklaması";
            
        }

        private void FrmUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmMain.Show();
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            _frmMeal._userMeal = _user;
            this.Close();
            _frmMain.Hide();
            _frmMeal.Show();
        }

        private void btnShowUserInfo_Click(object sender, EventArgs e)
        {
            _frmUserInfo = new FrmUserInfo();
            
            //pass user info to UserInfo form
            _frmUserInfo._userUserInfo = this._user;
            _frmUserInfo.Show();
        }

        private void mclUser_DateSelected(object sender, DateRangeEventArgs e)
        {
            
            ////show meals of selected date
            //dgvMeals.DataSource = _context.Meals.Where(x => x.UserId == _user.UserId && x.CreatedDate.Day == mclUser.SelectionStart.Day && x.CreatedDate.Month == mclUser.SelectionStart.Month && x.CreatedDate.Year == mclUser.SelectionStart.Year).ToList();

            //show meals of selected date range
            dgvMeals.DataSource = _context.Meals.Where(x => x.UserId == _user.UserId && x.CreatedDate.Day >= mclUser.SelectionRange.Start.Day && x.CreatedDate.Month >= mclUser.SelectionRange.Start.Month && x.CreatedDate.Year >= mclUser.SelectionRange.Start.Year && x.CreatedDate.Day <= mclUser.SelectionRange.End.Day && x.CreatedDate.Month <= mclUser.SelectionRange.End.Month && x.CreatedDate.Year <= mclUser.SelectionRange.End.Year).ToList();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                _frmMain.Show();
                //Environment.Exit(0);
                //return;
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            _frmReport._userReport = _user;
            this.Close();
            _frmMain.Hide();
            _frmReport.Show();
        }
    }
}
