using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public abstract class Employee
    {
        protected int id;
        protected string name;
        protected string designation;
        protected double experinece;
        protected double annualSalary;
        protected string joinDate;
        protected double basicSalary=8000;
        protected double totalSalary=0;

        public abstract void CountSalary();

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Designation
        {
            get
            {
                return designation;
            }
            set
            {
                designation = value;
            }
        }

        public double Experience
        {
            get
            {
                return experinece;
            }
            set
            {
                experinece = value;
            }
        }

        public double AnnualSalary
        {
            get
            {
                return annualSalary;
            }
            set
            {
                annualSalary = value;
            }
        }

        public string JoinDate
        {
            get
            {
                return joinDate;
            }
            set
            {
                joinDate = value;
            }
        }
    }
}
