using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class HR : Employee
    {
        public override void CountSalary()
        {
            totalSalary = basicSalary + (1000 * experinece);
            Console.WriteLine("\nTotal salary of HR is:" + totalSalary);
        }
    }
}
