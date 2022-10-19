using System;
using System.Windows.Forms;

namespace CaloricIntakeApp
{
    public partial class AddMeal : Form
    {
        private Form parent_form;
        public AddMeal(Form main_form)
        {
            parent_form = main_form;
            InitializeComponent();
        }

        private void AddMeal_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent_form.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            parent_form.Show();
            this.Close();
            this.Dispose();
        }
    }
}
