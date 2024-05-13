using CourseWork.Interfaces;
using CourseWork.Presentation;
using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseWork.Models
{
    public class Budjet : ITarget
    {
        public string Title { get; set; }
        public double Value { get; set; }
        public double MaxValue { get; set; }
        public string CategoryId { get; set; }
        public int PeriodId { get; set; }
        public int PeriodValue { get; set; }

        public Budjet(string title, double value, double maxValue, string categoryId, int periodId)
        {
            Title = title;
            Value = value;
            MaxValue = maxValue;
            CategoryId = categoryId;
            PeriodId = periodId;
            PeriodValue = GetCurrentPeriodValue();
        }

        public int GetCurrentPeriodValue()
        {
            int currPeriodValue = 0;
            switch (PeriodId)
            {
                case 0:
                    currPeriodValue = DateTime.Now.Day;
                    break;
                case 1:
                    currPeriodValue = DateTime.Now.Month;
                    break;
                case 2:
                    currPeriodValue = DateTime.Now.Year;
                    break;
            }

            return currPeriodValue;
        }

        public void Update()
        {
            int currPeriodValue = GetCurrentPeriodValue();

            if (PeriodValue != currPeriodValue)
            {
                Value = 0;
                PeriodValue = currPeriodValue;
            }
        }

    }
}
