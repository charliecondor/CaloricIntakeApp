using System;
using System.Collections.Generic;

namespace CaloricIntakeApp
{
    public class MealDayTotal
    {
        public string date { get; set; }
        public int total_calories { get; set; }
        public MealDayTotal(string date, int total_calories)
        {
            this.date = date;
            this.total_calories = total_calories;
        }
    }
}
