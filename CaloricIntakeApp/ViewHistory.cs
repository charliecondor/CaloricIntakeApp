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
        public ViewHistory()
        {
            InitializeComponent();
            MealHistory mealHistory = new MealHistory();
            mealHistory = mealHistory.LoadJSON();
            
            MealSummary mealSummary = mealHistory.GenerateSummary();
            mealSummary.CalculateSummaryValues();

            lblLTtotalvalue.Text = Convert.ToString(mealSummary.getLifetimeTotal());
            lblLTaveragevalue.Text = String.Format("{0:F}", mealSummary.getLifetimeAverage());
            lblLThighvalue.Text = Convert.ToString(mealSummary.getLifetimeHigh()) + " (" + Convert.ToString(mealSummary.getLifetimeHighDate()) + ")";
            lblLTlowvalue.Text = Convert.ToString(mealSummary.getLifetimeLow()) + " (" + Convert.ToString(mealSummary.getLifetimeLowDate()) + ")";

            lblTDtotalvalue.Text = Convert.ToString(mealSummary.getTendayTotal());
            lblTDaveragevalue.Text = String.Format("{0:F}", mealSummary.getTendayAverage());
            lblTDhighvalue.Text = Convert.ToString(mealSummary.getTendayHigh()) + " (" + Convert.ToString(mealSummary.getTendayHighDate()) + ")";
            lblTDlowvalue.Text = Convert.ToString(mealSummary.getTendayLow()) + " (" + Convert.ToString(mealSummary.getTendayLowDate()) + ")";

            dGridViewHistory.DataSource = mealHistory;

            mealHistory.SaveJSON();
        }
    }
}
