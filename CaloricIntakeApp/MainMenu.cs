using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloricIntakeApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();            
        }

        private void btnViewHistory_MouseClick(object sender, MouseEventArgs e)
        {
            Form viewHistory = new ViewHistory(this);
            this.Hide();
            viewHistory.Show();
        }
    }
}
