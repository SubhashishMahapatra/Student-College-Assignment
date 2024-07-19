using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollegeAssignment
{
    internal class Professor : Person
    {
        public const double HRMS = 0.4;
        public const double ALLOWANCES = 0.5;
        public double BasicSalary {  get; set; }

        public Professor(int personId, string personAddress, string personDob, double basicSalary):base(personId, personAddress, personDob) 
        {
            BasicSalary = basicSalary;
        }  

        public override string PrintDetails()
        {
            return(base.PrintDetails()+"\nProfessor Salary is: "+ SalaryCalculation());
        }

        public double SalaryCalculation()
        {
            double salary = BasicSalary + (BasicSalary * HRMS) + (BasicSalary * ALLOWANCES);

            return salary;
        }
    }
}
