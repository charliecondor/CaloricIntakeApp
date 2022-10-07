using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloricIntakeApp
{
    public partial class ViewHistory : Form
    {
        private Form parent_form;
        private MealHistory mealHistory = new MealHistory();
        private MealSummary mealSummary = new MealSummary();
        public ViewHistory(Form main_form)
        {
            parent_form = main_form;
            InitializeComponent();
            LoadMealHistory();
            UpdateLabels();
            UpdateGridView();
        }
        private void LoadMealHistory()
        {
            mealHistory = mealHistory.LoadJSON();
            mealSummary = mealHistory.GenerateSummary();
            mealSummary.CalculateSummaryValues();
        }
        private void UpdateLabels()
        {
            lblLTtotalvalue.Text = Convert.ToString(mealSummary.getLifetimeTotal());
            lblLTaveragevalue.Text = String.Format("{0:F}", mealSummary.getLifetimeAverage());
            lblLThighvalue.Text = Convert.ToString(mealSummary.getLifetimeHigh()) + " (" + Convert.ToString(mealSummary.getLifetimeHighDate()) + ")";
            lblLTlowvalue.Text = Convert.ToString(mealSummary.getLifetimeLow()) + " (" + Convert.ToString(mealSummary.getLifetimeLowDate()) + ")";

            lblTDtotalvalue.Text = Convert.ToString(mealSummary.getTendayTotal());
            lblTDaveragevalue.Text = String.Format("{0:F}", mealSummary.getTendayAverage());
            lblTDhighvalue.Text = Convert.ToString(mealSummary.getTendayHigh()) + " (" + Convert.ToString(mealSummary.getTendayHighDate()) + ")";
            lblTDlowvalue.Text = Convert.ToString(mealSummary.getTendayLow()) + " (" + Convert.ToString(mealSummary.getTendayLowDate()) + ")";
        }
        private void UpdateGridView()
        {
            foreach (MealDayTotal meal in mealSummary.meal_totals)
            {
                dGVMealSummary.Rows.Add(meal.date, meal.total_calories);
            }
        }
        private void dGridViewHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dGVMealTime.Rows.Clear();  // Clear rows for previously selected date
            string selected_date = dGVMealSummary.Rows[e.RowIndex].Cells[0].Value.ToString();  // Retrieves the date of the selected row            
            //MessageBox.Show(e.RowIndex.ToString() + " | " + selected_date, "Click", MessageBoxButtons.OK);

            foreach (Meal meal in mealHistory.meals)  // Lists all meal times for a selected meal date
            {
                if (meal.Date == selected_date)
                {
                    int total_calories = 0;                    
                    foreach (MealItems item in meal.mealitems)
                    {
                        total_calories += item.Calories;
                    }
                    dGVMealTime.Rows.Add(meal.Time, total_calories.ToString());
                }
            }

            //mealHistory.meals[e.RowIndex].mealitems
        }
        private void ViewHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            mealHistory.SaveJSON();
            parent_form.Show();
        }
    }
}
