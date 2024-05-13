using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseWork.Extensions
{
    public static class UIExtensions
    {
        public static DataPoint Find(this DataPointCollection points, Predicate<DataPoint> match)
        {
            foreach (var item in points)
            {
                if(match(item)) return item;
            }

            return null;
        }
    }
}
