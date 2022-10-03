using System;
using System.Collections.Generic;

namespace CaloricIntakeApp
{
    public class DailySummary
    {
        public string Date { get; set; }
        public int TotalCalories { get; set; }        
        public DailySummary(string Date, int TotalCalories)
        {
            this.Date = Date;
            this.TotalCalories = TotalCalories;
        }
    }
}
