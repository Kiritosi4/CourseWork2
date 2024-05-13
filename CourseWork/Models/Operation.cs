using System;
using System.Collections.Generic;

namespace CourseWork
{
    public class Operation
    {
        public double Value { get; set; }
        public DateTime CreateDate { get; set; }
        public string CategoryId { get; set; }
        public KeyValuePair<string, double> Target { get; set; }

        public Operation(double value, DateTime createDate, string categoryId, KeyValuePair<string, double> target)
        {
            Value = value;
            CreateDate = createDate;
            CategoryId = categoryId;
            Target = target;
        }
    }
}
