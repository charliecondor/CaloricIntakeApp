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
            dataGridView1.DataSource = mealHistory;
        }

        private void ViewHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
