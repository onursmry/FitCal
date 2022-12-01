using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FitCal.DAL;
using FitCal.DATA.Entities;

namespace FitCal.UI
{
    public partial class FrmMeal : Form
    {
        FitCalContext _context;
        FrmUser _frmUser;
        double _totalCalories;
        double _mealCalories;
        List<Food> _foods;
        public User _userMeal;

        public FrmMeal()
        {
            InitializeComponent();
        }

        private void FrmMeal_Load(object sender, EventArgs e)
        {
            _context = new FitCalContext();
            _frmUser = new FrmUser();

            //add all meals to Datagridview
            dgvMyMeals.DataSource = _context.Meals.Where(x => x.UserId == _userMeal.UserId).ToList();

            //exclude foods from meals
            dgvMyMeals.Columns["Foods"].Visible = false;
            dgvMyMeals.Columns["User"].Visible = false;
            dgvMyMeals.Columns["UserId"].Visible = false;

            //add all foods to listbox
            lbxAllFood.DataSource = _context.Foods.ToList();
            lbxAllFood.DisplayMember = "Name";
            lbxAllFood.ValueMember = "Calories";

            btnUpdateMeal.Enabled = false;

            lblCalories.BackColor = Color.Teal;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add selected item to listbox show displayname
            lbxMealFood.Items.Add(lbxAllFood.SelectedItem);
            lbxMealFood.DisplayMember = "Name";
            lbxMealFood.ValueMember = "Calories";

            //add calories to label
            Food food = (Food)lbxAllFood.SelectedItem;
            _mealCalories += food.Calories;
            lblCalories.Text = _mealCalories.ToString();

            //add foods to list
            _foods = new List<Food>();
            _foods.Add(food);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Food food = (Food)lbxMealFood.SelectedItem;

            if (lbxMealFood.SelectedItem != null)
            {
                lbxMealFood.Items.Remove(lbxMealFood.SelectedItem);
                //remove food from list
                _foods.Remove(food);

                if (food != null)
                {
                    _mealCalories -= food.Calories;
                    lblCalories.Text = _mealCalories.ToString();
                }
                else
                {
                    _mealCalories -= 0;
                    lblCalories.Text = "0";
                    System.Media.SystemSounds.Beep.Play();
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir besin seçiniz", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

        }

        private void FrmMeal_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmUser._user = _userMeal;
            this.Hide();
            _frmUser.Show();
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            Meal meal = new Meal();
            meal.UserId = _userMeal.UserId;
            meal.CreatedDate = DateTime.Now;
            meal.Name = cbxMealName.Text;
            meal.Calories = Convert.ToDouble(lblCalories.Text);
            foreach (var item in lbxMealFood.Items)
            {
                //_foods.Add((Food)item);
                _foods.Add((Food)item);
            }

            meal.Foods = _foods;
            meal.Notes = rtbMealNotes.Text;
            _context.Meals.Add(meal);
            _context.SaveChanges();

            MessageBox.Show("Öğün başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            dgvMyMeals.DataSource = _context.Meals.ToList();
            lbxMealFood.Items.Clear();
            rtbMealNotes.Clear();
            lbxAllFood.SelectedIndex = -1;

            lblCalories.Text = "...";
            _mealCalories = 0;
        }

        private void btnUpdateBringInfo_Click(object sender, EventArgs e)
        {
            btnUpdateAdd.Enabled = true;
            btnUpdateRemove.Enabled = true;
            btnUpdateMeal.Enabled = true;

            int mealId = Convert.ToInt32(nudUpdateMealId.Value);
            Meal meal = new Meal();

            if (_context.Meals.Any(x => x.MealId == mealId))
            {
                meal = _context.Meals.Find(mealId);
            }
            else
            {
                MessageBox.Show("Girdiğiniz id'ye ait öğün bulunamadı", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                lbxUserMeal.Items.Clear();
                lbxUpdateMeal.DataSource = null;
                cbxUpdateMealName.Text = "";
                rtbUpdateMealNotes.Clear();
                lblUpdatedCalories.Text = "...";
                return;
            }

            //check if the meal belongs to current user
            if (meal.UserId != _userMeal.UserId)
            {
                MessageBox.Show("Girdiğiniz id'ye ait öğün bulunamadı", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {
                lbxUpdateMeal.DataSource = _context.Foods.ToList();
                lbxUpdateMeal.DisplayMember = "Name";
                lbxUpdateMeal.ValueMember = "Calories";
                cbxUpdateMealName.Text = meal.Name;
                rtbUpdateMealNotes.Text = meal.Notes;

                lbxUserMeal.Items.Clear();

                foreach (Food item in _context.Meals.Where(x => x.MealId == mealId && x.UserId == _userMeal.UserId)
                             .Select(x => x.Foods).FirstOrDefault())
                {
                    if (item != null)
                    {
                        lbxUserMeal.Items.Add(item);
                        lbxUserMeal.DisplayMember = "Name";
                        lbxUserMeal.ValueMember = "Calories";
                    }
                }

                //bring calories to label
                lblUpdatedCalories.Text = meal.Calories.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxAllFood.DataSource = _context.Foods.Where(x => x.Name.Contains(txtSearchFood.Text)).ToList();
        }

        private void btnUpdateMeal_Click(object sender, EventArgs e)
        {
            //Select the meal
            int mealId = Convert.ToInt32(nudUpdateMealId.Value);
            Meal meal = _context.Meals.Find(mealId);
            meal.Foods = _context.Meals.Where(x => x.MealId == mealId).Select(x => x.Foods).FirstOrDefault().ToList();
            meal.Foods.Clear();

            _context.Entry(meal).Collection(x => x.Foods).Load();

            //hashset to generic list casting
            ICollection<Food> foods = new List<Food>();
            meal.Name = cbxUpdateMealName.Text;
            meal.Notes = rtbUpdateMealNotes.Text;
            meal.Calories = Convert.ToDouble(lblUpdatedCalories.Text);

            //Attach new food list
            foreach (var item in lbxUserMeal.Items)
            {
                foods.Add((Food)item);
            }

            ////remove foods from meal if removed from listbox
            //foreach (var item in _context.Meals.Where(x => x.MealId == mealId && x.UserId == _userMeal.UserId)
            //    .Select(x => x.Foods).FirstOrDefault())
            //{
            //    if (!foods.Contains(item))
            //    {
            //        _context.Foods.Remove(item);
            //    }
            //}

            meal.Foods = foods;

            //attach new foods
            //_context.Entry(meal).Collection(x => x.Foods).EntityEntry.State = EntityState.Modified;
            _context.SaveChanges();

            MessageBox.Show("Öğün başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            dgvMyMeals.DataSource = _context.Meals.ToList();

            //clear controls
            lbxUserMeal.Items.Clear();
            lbxUpdateMeal.DataSource = null;
            cbxUpdateMealName.Text = "";
            rtbUpdateMealNotes.Clear();
            lblUpdatedCalories.Text = "...";

            btnUpdateMeal.Enabled = false;
        }

        private void btnUpdateAdd_Click(object sender, EventArgs e)
        {
            //get meal calories
            _totalCalories = Convert.ToDouble(lblUpdatedCalories.Text);

            //add selected item to listbox show displayname
            lbxUserMeal.Items.Add(lbxUpdateMeal.SelectedItem);
            lbxUserMeal.DisplayMember = "Name";
            lbxUserMeal.ValueMember = "Calories";

            if (btnUpdateRemove.Enabled == false)
            {
                btnUpdateRemove.Enabled = true;
            }

            //update calories
            Food food = (Food)lbxUpdateMeal.SelectedItem;
            _totalCalories += food.Calories;
            lblUpdatedCalories.Text = _totalCalories.ToString();
        }

        private void btnUpdateRemove_Click(object sender, EventArgs e)
        {
            _totalCalories = Convert.ToDouble(lblUpdatedCalories.Text);
            if (lbxUserMeal.SelectedIndex != -1)
            {
                Food food = (Food)lbxUserMeal.SelectedItem;
                _totalCalories -= food.Calories;
                lblUpdatedCalories.Text = _totalCalories.ToString();

                //if listbox is empty, set remove button to false
                if (_totalCalories <= 0)
                {
                    btnUpdateRemove.Enabled = false;
                }
                
                lbxUserMeal.Items.Remove(lbxUserMeal.SelectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir öğün seçiniz", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnShowMeal_Click(object sender, EventArgs e)
        {
            //get meal id and show in datagridview
            int mealId = Convert.ToInt32(nudDeleteMealId.Value);

            dgvMyMeals.DataSource = _context.Meals.Where(x => x.MealId == mealId).ToList();
        }

        private void btnRemoveMeal_Click(object sender, EventArgs e)
        {
            Meal meal = _context.Meals.Find(nudDeleteMealId.Value);
            if (meal == null)
            {
                MessageBox.Show("Öğün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _context.Entry(meal).Collection(x => x.Foods).Load();
            _context.Meals.Remove(meal);
            _context.SaveChanges();
            dgvMyMeals.DataSource = _context.Meals.ToList();
            MessageBox.Show("Öğün Silme İşlemi Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
