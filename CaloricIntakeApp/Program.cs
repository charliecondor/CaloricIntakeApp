using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace CaloricIntakeApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public class DailyCaloricJSON
        {
            public DateTime Date { get; set; }
            public int TotalCalories { get; set; }
        }
        [STAThread]
        static void Main()
        {
            var dailycaloricJSON = new DailyCaloricJSON
            {
                Date = DateTime.Now,
                TotalCalories = 0
            };

            if (File.Exists("DailyCaloric.json"))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File Doesnt Exists");
                string fileName = "DailyCaloric.json";
                string jsonString = JsonSerializer.Serialize(dailycaloricJSON);
                File.WriteAllText(fileName, jsonString);
            }            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
