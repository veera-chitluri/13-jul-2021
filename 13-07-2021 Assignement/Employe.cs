using System;
using System.Collections.Generic;
using System.Text;

namespace EMploye_Assignement
{
    class Employe
    {
        private double salary;
        public int EmployeId;
        public string Name;
        public string Designation;

        public Employe(double salary)
        {
            this.salary = salary;
        }

        public double Salary
        {
            get { return salary; }
        }

        public bool Promotion
        {
            set
            {
                if(isPromoted)
                    salary = (salary * 10) / 100;
            }
        }

       
        
    }
}
