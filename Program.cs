using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollegeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(1,"Pawar Nagar Thane west", "30-12-2011" );
            
            Person student = new Student(2, "Vasant Vihar Thane west", "16-07-2003", "IT");
           
            Person professor = new Professor(3, "Dombivali East", "20-04-1985", 80000);
          
          PrintInfo( person );  
          PrintInfo( student );
          PrintInfo(professor);
           


        }

        public static void PrintInfo(Person person)
        {
            Console.WriteLine(person.GetType().Name);
            Console.WriteLine(person.PrintDetails());
            Console.WriteLine();

        }


    }
}
