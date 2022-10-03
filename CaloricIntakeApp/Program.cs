using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace CaloricIntakeApp
{
    internal static class Program
    {                
        [STAThread]
        static void Main()
        {
            MealHistory mealHistory = new MealHistory();
            mealHistory = mealHistory.LoadJSON();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());

            mealHistory.SaveJSON();
        }
    }
}
