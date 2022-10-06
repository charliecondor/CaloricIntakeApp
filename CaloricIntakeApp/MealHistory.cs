using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            var options = new JsonSerializerOptions { IncludeFields = true };  // Include fields for serializing objects with objects
            return File.Exists(fileJSON) ? JsonSerializer.Deserialize<MealHistory>(File.ReadAllText(fileJSON), options) : null;
        }
        public void SaveJSON()
        {
            var options = new JsonSerializerOptions { IncludeFields = true };  // Include fields for serializing objects with objects
            string mealJSON = JsonSerializer.Serialize(this, options);
            File.WriteAllText(fileJSON, mealJSON);
        }
        public MealSummary GenerateSummary()
        {
            MealSummary dailySummary = new MealSummary();

            foreach (Meal meal in meals)
            {
                if (!dailySummary.meal_totals.Exists(x => x.date == meal.Date))
                {
                    dailySummary.meal_totals.Add(new MealDayTotal(meal.Date, 0));
                }
            }

            dailySummary.meal_totals.Sort((x, y) => x.date.CompareTo(y.date));

            foreach (MealDayTotal day in dailySummary.meal_totals)
            {
                foreach (Meal meal in meals)
                {
                    if (day.date == meal.Date)
                    {
                        foreach (MealItems mealitem in meal.mealitems)
                        {
                            day.total_calories += mealitem.Calories;
                        }
                    }
                }
            }

            dailySummary.meal_totals.Reverse();

            return dailySummary;
        }
    }
}
