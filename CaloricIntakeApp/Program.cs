using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Runtime.CompilerServices;

namespace CaloricIntakeApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public class MealItemJSON
        {
            public string Quantity { get; set; }
            public string MeasurementUnit { get; set; }
            public string Description { get; set; }
            public int Calories { get; set; }
        }
        public class MealJSON
        {
            public DateTime Date { get; set; }
            public List<MealItemJSON> MealItems { get; set; }
            public int TotalCalories { get; set; }
        }
        [STAThread]
        static void Main()
        {
            var mealJSON = new MealJSON()
            {
                Date = DateTime.Now,                
                TotalCalories = 0
            };

            mealJSON.MealItems = new List<MealItemJSON> { new MealItemJSON { Quantity = "1", MeasurementUnit = "cup", Description = "corn", Calories = 80 } };
            mealJSON.MealItems.Add(new MealItemJSON { Quantity = "2", MeasurementUnit = "tbsp", Description = "mayo", Calories = 100 });
        
            string fileName = "Meals.json";
            string jsonString = JsonSerializer.Serialize(mealJSON);
            // string jsonString = JsonSerializer.Deserialize(mealJSON, null);
            File.WriteAllText(fileName, jsonString);
                     
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
