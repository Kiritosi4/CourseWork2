using CourseWork.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseWork.Persistance
{
    public class DbContext
    {
        
        public List<Operation> ExpensesList { get; set; } = new List<Operation>();
        public List<Operation> ProfitList { get; set; } = new List<Operation>();
        public Dictionary<string, Target> TargetList { get; set; } = new Dictionary<string, Target>();
        public Dictionary<string, Budjet> BudjetList { get; set; } = new Dictionary<string, Budjet>();
    }
}
