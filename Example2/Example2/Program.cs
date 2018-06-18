using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program 
    {
        static void Main(string[] args)
        {

            HR hr = new HR();
            Developer developer = new Developer();
            SetHrData(hr);
            hr.CountSalary();

            SetDeveloperData(developer);
            developer.CountSalary();


        }

        private static void SetDeveloperData(Developer developer)
        {
            developer.Id = 101;
            developer.Name = "Aman";
            developer.Designation = "Developer";
            developer.Experience = 5;
            developer.AnnualSalary = 120000;
            developer.JoinDate = "1-2-2013";
        }

        private static void SetHrData(HR hr)
        {
            hr.Id = 101;
            hr.Name = "Priya";
            hr.Designation = "HR";
            hr.Experience = 4;
            hr.AnnualSalary = 100000;
            hr.JoinDate = "1-1-2014";
        }
    }
}
