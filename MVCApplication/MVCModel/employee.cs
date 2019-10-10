using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCModel
{
    public class employee
    {
        public long EmpId { get; set; }
        public string EmpName { get; set; }
        public long? Age { get; set; }
        public string MartalStatus { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public string EmpLocation { get; set; }
    }
}
