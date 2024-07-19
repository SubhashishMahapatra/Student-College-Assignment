using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollegeAssignment
{
    internal class Person
    {
        public int PersonId { get; set; }
        public string PersonAddress { get; set; }    
        public string PersonDob { get; set; }


        public Person(int personId, string personAddress, string personDob)
        {
            PersonId = personId;
            PersonAddress = personAddress;
            PersonDob = personDob;
        }

        public virtual string PrintDetails()
        {
            return ("Id is: " + PersonId + "\nAddress is: "+PersonAddress+ "\nDOB is: "+PersonDob);
        }

    }
}
