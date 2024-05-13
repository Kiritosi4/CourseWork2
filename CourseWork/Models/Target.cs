using CourseWork.Interfaces;
using System;

namespace CourseWork
{
    public class Target : ITarget
    {
        public string Title { get; set; }
        public double Value { get; set; }
        public double MaxValue { get; set; }

        public Target(string title, double value, double maxValue)
        {
            Title = title;
            Value = value;
            MaxValue = maxValue;
        }
    }
}
