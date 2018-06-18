using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Developer : Employee
    {
        public override void CountSalary()
        {
            totalSalary = basicSalary + (2000 * experinece);
            Console.WriteLine("\nTotal salary of Developer is:" + totalSalary);
        }
    }
}
