using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitCal.DAL;
using FitCal.DATA.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FitCal.UI
{
    public partial class FrmReport : Form
    {
        public User _userReport;
        FitCalContext _context;
        FrmUser _frmUser;

        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            _context = new FitCalContext();
            _frmUser = new FrmUser();

            //default selections
            rdbDate.Checked = true;
            cbxMealList.SelectedIndex = 0;
            cbxFoodList.SelectedIndex = 0;

            //user can't see dates before they joined
            dtpStartDate.MinDate = _userReport.CreatedDate;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (rdbDate.Checked == true)
            {
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;

                if (endDate.Day < startDate.Day)
                {
                    MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz!");
                    return;
                }
                else if (endDate.Day == startDate.Day)
                {
                    //list meals for the day
                    var meals = _context.Meals.Where(x =>
                        x.UserId == _userReport.UserId && x.CreatedDate.Day == startDate.Day &&
                        x.CreatedDate.Month == startDate.Month && x.CreatedDate.Year == startDate.Year).ToList();
                    
                    dgvReport.DataSource = meals;

                    //hide columns food, user and userid
                    dgvReport.Columns["Foods"].Visible = false;
                    dgvReport.Columns["User"].Visible = false;
                    dgvReport.Columns["UserId"].Visible = false;
                }
                else
                {
                    //list meals between two dates
                    dgvReport.DataSource = _context.Meals.Where(x =>
                            x.UserId == _userReport.UserId && x.CreatedDate >= startDate && x.CreatedDate <= endDate)
                        .ToList();

                    //hide columns food, user and userid
                    dgvReport.Columns["Foods"].Visible = false;
                    dgvReport.Columns["User"].Visible = false;
                    dgvReport.Columns["UserId"].Visible = false;
                }
            }
            else if (rdbMeal.Checked == true)
            {
                if (cbxMealList.SelectedIndex==0)
                {
                    MessageBox.Show("Lütfen bir arama kriteri seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //list meals by meal name
                    if (cbxMealList.SelectedIndex == 1)
                    {
                        //list meals by meal names and calories order by date
                        dgvReport.DataSource = _context.Meals.Where(x => x.UserId == _userReport.UserId)
                            .OrderBy(x => x.CreatedDate).ToList();

                        ////show foods in datagridview combobox
                        //DataGridViewComboBoxColumn cmbFoods = new DataGridViewComboBoxColumn();
                        //cmbFoods.HeaderText = "Besinler";
                        //cmbFoods.Name = "Foods";
                        //cmbFoods.DataSource = _context.Meals.Where(x => x.UserId == _userReport.UserId)
                        //    .SelectMany(x => x.Foods).ToList();
                        //cmbFoods.DisplayMember = "Name";
                        //cmbFoods.ValueMember = "FoodId";
                        //dgvReport.Columns.Add(cmbFoods);

                        //hide columns food, user and userid
                        dgvReport.Columns["Foods"].Visible = false;
                        dgvReport.Columns["User"].Visible = false;
                        dgvReport.Columns["UserId"].Visible = false;
                    }
                    else if (cbxMealList.SelectedIndex == 2)
                    {
                        //list meals by calories
                        dgvReport.DataSource = _context.Meals.Where(x => x.UserId == _userReport.UserId)
                            .OrderByDescending(x => x.Calories).ToList();
                    }
                }
            }
            else if (rdbFood.Checked == true)
            {
                if (cbxFoodList.SelectedIndex==0)
                {
                    MessageBox.Show("Lütfen bir arama kriteri seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //list meals by meal name
                    if (cbxFoodList.SelectedIndex == 1)
                    {
                        //select all foods list from meals and show how many times it is consumed
                        var foods = _context.Meals.Where(x => x.UserId == _userReport.UserId)
                            .SelectMany(x => x.Foods).GroupBy(x => x.FoodId).Select(x => new
                            {
                                FoodName = x.FirstOrDefault().Name,
                                FoodCategory = x.FirstOrDefault().Category.Name,
                                FoodCalorie = x.FirstOrDefault().Calories,
                                Count = x.Count()
                            }).OrderByDescending(x => x.Count).ToList();

                        dgvReport.DataSource = foods;

                        //rename columns
                        dgvReport.Columns[0].HeaderText = "Yiyecek Adı";
                        dgvReport.Columns[1].HeaderText = "Besin Kategorisi";
                        dgvReport.Columns[2].HeaderText = "Besin Kalorisi";
                        dgvReport.Columns[3].HeaderText = "Tüketilen Miktar";
                    }
                    else if (cbxFoodList.SelectedIndex == 2)
                    {
                        //Foods consumed by category
                        var foods = _context.Meals.Where(x => x.UserId == _userReport.UserId)
                            .SelectMany(x => x.Foods).GroupBy(x => x.CategoryId).Select(x => new
                            {
                                FoodCategory = x.FirstOrDefault().Category.Name,
                                Count = x.Count()
                            }).OrderByDescending(x => x.Count).ToList();

                        dgvReport.DataSource = foods;

                        //rename columns
                        dgvReport.Columns[0].HeaderText = "Besin Kategorisi";
                        dgvReport.Columns[1].HeaderText = "Tüketilen Miktar";
                    }
                    else if (cbxFoodList.SelectedIndex == 3)
                    {
                        //Foods consumed by meal type group by category
                        var foods = _context.Meals.Where(x => x.UserId == _userReport.UserId)
                            .SelectMany(x => x.Foods).GroupBy(x => new { x.CategoryId}).Select(x => new
                            {
                                FoodCategory = x.FirstOrDefault().Category.Name,
                                FoodCalorie = x.FirstOrDefault().Calories,
                                MealName = x.FirstOrDefault().Meals.FirstOrDefault().Name,
                                Count = x.Count()
                            }).OrderByDescending(x => x.Count).ToList();

                        dgvReport.DataSource = foods;

                        //rename columns
                        dgvReport.Columns[0].HeaderText = "Besin Kategorisi";
                        dgvReport.Columns[1].HeaderText = "Besin Kalorisi";
                        dgvReport.Columns[2].HeaderText = "Tüketilen Miktar";
                        dgvReport.Columns[3].HeaderText = "Öğün Türü";

                    }
                    else if (cbxFoodList.SelectedIndex == 4)
                    {
                        //Foods ordered by calorie
                        var foods = _context.Meals.Where(x => x.UserId == _userReport.UserId)
                            .SelectMany(x => x.Foods).GroupBy(x => x.FoodId).Select(x => new
                            {
                                FoodName = x.FirstOrDefault().Name,
                                FoodCategory = x.FirstOrDefault().Category.Name,
                                FoodCalorie = x.FirstOrDefault().Calories
                            }).OrderBy(x => x.FoodCalorie).ToList();

                        dgvReport.DataSource = foods;

                        //rename columns
                        dgvReport.Columns[0].HeaderText = "Yiyecek Adı";
                        dgvReport.Columns[1].HeaderText = "Besin Kategorisi";
                        dgvReport.Columns[2].HeaderText = "Besin Kalorisi";
                    }
                }
            }
        }

        private void FrmReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmUser._user=_userReport;
            this.Hide();
            _frmUser.Show();
        }
    }
}
