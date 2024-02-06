using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    internal class Operation
    {
        public float Sum;
        public int TimeStamp;
        public DateTime CreateDate => new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).AddSeconds(TimeStamp);
    }
}
