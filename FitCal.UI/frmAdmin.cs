using FitCal.DATA.Entities;
using System;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using FitCal.DAL;
using FitCal.DATA.Enums;
using FitCal.UI.Repositories;

namespace FitCal.UI
{
    public partial class FrmAdmin : Form
    {
        FitCalContext _context;
        FrmUserInfo _frmUserInfo;
        FrmMain _frmMain;
        public User _userAdmin;
        public User _loggedAdmin;

        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            _context = new FitCalContext();
            _frmUserInfo = new FrmUserInfo();
            _frmMain = new FrmMain();
            _loggedAdmin = _frmMain._userMain;
            cbxFoodCategory.DataSource = _context.Categories.Select(x => x.Name).ToList();
            dgvAdminPanel.DataSource = _context.Users.ToList();

            //hide id, createddate and updateddate columns
            dgvAdminPanel.Columns[0].Visible = false;
            dgvAdminPanel.Columns[8].Visible = false;
            dgvAdminPanel.Columns[10].Visible = false;
            dgvAdminPanel.Columns[12].Visible = false;
            dgvAdminPanel.Columns[13].Visible = false;
            dgvAdminPanel.Columns[14].Visible = false;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            if (!Method.CheckIfBlankField(gbxAddFood))
            {
                food.Name = txtFoodName.Text + "-" + txtPortion.Text;
                food.Calories = Convert.ToDouble(txtFoodCalories.Text);
                food.CategoryId = _context.Categories.FirstOrDefault(x => x.Name == cbxFoodCategory.Text).CategoryId;
                food.FoodPhotoPath = lblFoodPhotoPath.Text;
                food.FoodPhoto = pbxFoodPhoto.Image == null ? null : Method.ImageToByteArray(pbxFoodPhoto.Image);

                _context.Foods.Add(food);
                _context.SaveChanges();

                MessageBox.Show("Besin başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları dolurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFoodPhoto_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            //add food photo
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string picPath = ofd.FileName.ToString();
                pbxFoodPhoto.ImageLocation = picPath;
                lblFoodPhotoPath.Text = picPath;
            }
        }

        private void FrmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            _frmMain.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //check if textboxes are empty
            if (!Method.CheckIfBlankField(gbxAdminPanel))
            {
                //get selected user from datagridview
                User user = (User)dgvAdminPanel.CurrentRow.DataBoundItem;
                //update user
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.BirthDate = dtpBirthDate.Value;
                user.Email = Method.IsValidEmail(txtEmail.Text) ? txtEmail.Text : throw new Exception("Lütfen geçerli bir e-posta adresi giriniz");

                //save changes
                _context.SaveChanges();
                //refresh datagridview
                Method.RefreshDataGridView(dgvAdminPanel, _context.Users.ToList());

                MessageBox.Show("Kullanıcı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //clear textboxes
            Method.ClearAllTextBoxes(gbxUserPanel);
            dtpBirthDate.Value = DateTime.Now;
        }

        //btnDelete click event

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get selected user from datagridview
            User user = (User)dgvAdminPanel.CurrentRow.DataBoundItem;
            
            //change user status to active false
            if (user.UserType == UserTypes.Admin)
            {
                MessageBox.Show("Yönetici hesapları silinemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                user.IsActive = UserStates.Passive;
            }
            
            //save changes
            _context.SaveChanges();

            //refresh datagridview
            Method.RefreshDataGridView(dgvAdminPanel, _context.Users.ToList());

        }

        //btnActivateUser click event

        private void btnActivateUser_Click(object sender, EventArgs e)
        {
            //get selected user from datagridview
            User user = (User)dgvAdminPanel.CurrentRow.DataBoundItem;
            //change user status to active true
            user.IsActive = UserStates.Active;
            //save changes
            _context.SaveChanges();
            
            //refresh datagridview
            Method.RefreshDataGridView(dgvAdminPanel, _context.Users.ToList());

            MessageBox.Show("Kullanıcı aktif edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        //Cell double click event for datagridview

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //fill textboxes with selected user's information
            User user = (User)dgvAdminPanel.CurrentRow.DataBoundItem;
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            dtpBirthDate.Value = user.BirthDate;
            txtAge.Text = (DateTime.Now.Year - user.BirthDate.Year).ToString();
            txtEmail.Text = user.Email.ToString();
            txtWeight.Text = user.Weight.ToString();
            txtHeight.Text = user.Height.ToString();
            txtGender.Text = user.Gender.ToString();
            txtBMI.Text = ((user.Weight / (user.Height * user.Height))*10000).ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //refresh datagridview
            Method.RefreshDataGridView(dgvAdminPanel, _context.Users.ToList());
        }

        private void btnListFood_Click(object sender, EventArgs e)
        {
            //list all food in datagridview
            dgvAdminPanel.DataSource = _context.Foods.ToList();

            //auto resize columns in datagridview
            dgvAdminPanel.AutoResizeColumns();

            //auto resize rows in datagridview
            dgvAdminPanel.AutoResizeRows();
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            //list all users in datagridview
            dgvAdminPanel.DataSource = _context.Users.ToList();
        }
    }
}
