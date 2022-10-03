using System;
using System.Collections.Generic;
using System.Linq;

namespace CaloricIntakeApp
{
    public class Meal
    {
        public List<MealItems> mealitems = new List<MealItems>();
        public string Date { get; set; }
        public string Time { get; set; }
        public Meal(string Date, string Time, List<MealItems> mealitems)
        {
            this.mealitems = mealitems;
            this.Date = Date;
            this.Time = Time;
        }
        public bool IsNullOrEmpty()
        {
            return String.IsNullOrEmpty(this.Date) || String.IsNullOrEmpty(this.Time) || !this.mealitems.Any();
        }
        public bool UpdateDate(string str_date)
        {
            try
            {
                DateTime mealDate = new DateTime(Convert.ToInt32(str_date.Substring(0, 4)),
                    Convert.ToInt32(str_date.Substring(5, 2)),
                    Convert.ToInt32(str_date.Substring(8, 2)));
                Date = mealDate.ToString("yyyy/MM/dd");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
