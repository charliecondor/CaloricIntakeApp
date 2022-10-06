using System;
using System.Collections.Generic;

namespace CaloricIntakeApp
{
    public class MealSummary
    {
        public List<MealDayTotal> meal_totals = new List<MealDayTotal>();

        private int lifetime_total;
        private double lifetime_average;
        private int lifetime_high;
        private int lifetime_low = 10000;
        private string lifetime_highdate;
        private string lifetime_lowdate;
        private int tenday_total;
        private double tenday_average;
        private int tenday_high;
        private int tenday_low = 10000;
        private string tenday_highdate;
        private string tenday_lowdate;

        public void CalculateSummaryValues()
        {
            foreach (MealDayTotal day in meal_totals)
            {
                lifetime_total += day.total_calories;
                if (lifetime_high < day.total_calories)
                {
                    lifetime_high = day.total_calories;
                    lifetime_highdate = day.date;
                }
                if (lifetime_low > day.total_calories && day.date != meal_totals[0].date)
                {
                    lifetime_low = day.total_calories;
                    lifetime_lowdate = day.date;
                }
            }
            lifetime_average = (double)lifetime_total / meal_totals.Count;

            int last_ten = 1;
            while (last_ten < 11)
            {
                tenday_total += meal_totals[last_ten].total_calories;
                if (tenday_high < meal_totals[last_ten].total_calories)
                {
                    tenday_high = meal_totals[last_ten].total_calories;
                    tenday_highdate = meal_totals[last_ten].date;
                }
                if (tenday_low > meal_totals[last_ten].total_calories)
                {
                    tenday_low = meal_totals[last_ten].total_calories;
                    tenday_lowdate = meal_totals[last_ten].date;
                }
                last_ten++;
            }
            tenday_average = (double)tenday_total / 10;
        }
        public int getLifetimeTotal()
        {
            return lifetime_total;
        }
        public double getLifetimeAverage()
        {
            return lifetime_average;
        }
        public int getLifetimeHigh()
        {
            return lifetime_high;
        }
        public int getLifetimeLow()
        {
            return lifetime_low;
        }
        public string getLifetimeHighDate()
        {
            return lifetime_highdate;
        }
        public string getLifetimeLowDate()
        {
            return lifetime_lowdate;
        }
        public int getTendayTotal()
        {
            return tenday_total;
        }
        public double getTendayAverage()
        {
            return tenday_average;
        }
        public int getTendayHigh()
        {
            return tenday_high;
        }
        public int getTendayLow()
        {
            return tenday_low;
        }
        public string getTendayHighDate()
        {
            return tenday_highdate;
        }
        public string getTendayLowDate()
        {
            return tenday_lowdate;
        }
    }
}
