using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollegeAssignment
{
    internal class Student : Person
    {
        public string Branch {  get; set; }
        public Student(int personId, string personAddress, string personDob, string branch):base( personId,  personAddress, personDob) 
        {
            Branch = branch;
        }

        public override string PrintDetails()
        {
            return (base.PrintDetails() + "\nStudent Branch is: " + Branch);
        }


    }
}
