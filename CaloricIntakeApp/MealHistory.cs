using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace CaloricIntakeApp
{
    internal class MealHistory
    {
        private const string fileJSON = "MealHistoryJSON.json";
        public List<Meal> meals = new List<Meal>();
        public bool AddMeal(Meal meal)
        {
            meals.Add(new Meal(meal.Date, meal.Time, meal.mealitems));
            return true;
        }
        public MealHistory LoadJSON()
        {
            //var options = new JsonSerializerOptions { IncludeFields = true };  // Include fields for serializing objects with objects            
            //return File.Exists(fileJSON) ? JsonSerializer.Deserialize<MealHistory>(File.ReadAllText(fileJSON), options) : null;
            return File.Exists(fileJSON) ? JsonSerializer.Deserialize<MealHistory>(File.ReadAllText(fileJSON)) : null;
        }
        public void SaveJSON()
        {
            //var options = new JsonSerializerOptions { IncludeFields = true };  // Include fields for serializing objects with objects
            //string mealJSON = JsonSerializer.Serialize(this, options);
            string mealJSON = JsonSerializer.Serialize(this);
            File.WriteAllText(fileJSON, mealJSON);
        }
        public List<DailySummary> GenerateSummary()
        {
            List<DailySummary> dailySummary = new List<DailySummary>();

            foreach (Meal meal in meals)
            {
                if (!dailySummary.Exists(x => x.Date == meal.Date))
                {
                    dailySummary.Add(new DailySummary(meal.Date, 0));
                }
            }

            dailySummary.Sort((x, y) => x.Date.CompareTo(y.Date));

            foreach (DailySummary day in dailySummary)
            {
                foreach (Meal meal in meals)
                {
                    if (day.Date == meal.Date)
                    {
                        foreach (MealItems mealitem in meal.mealitems)
                        {
                            day.TotalCalories += mealitem.Calories;
                        }
                    }
                }
            }

            return dailySummary;
        }
    }
}
