using System;
using System.Collections.Generic;

namespace CaloricIntakeApp
{
    public class MealItems
    {
        public string Quantity { get; set; }
        public string UnitMeasurement { get; set; }
        public string Description { get; set; }
        public int Calories { get; set; }
        public MealItems(string Quantity, string UnitMeasurement, string Description, int Calories)
        {
            this.Quantity = Quantity;
            this.UnitMeasurement = UnitMeasurement;
            this.Description = Description;
            this.Calories = Calories;
        }
    }
}
