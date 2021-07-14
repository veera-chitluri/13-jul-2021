using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Student
    {
        public int DOB;
        public int Id;
        public string Name;
        public int Age;
        

        public DateTime BirthDate { get; set; }
        public object Getdetails { get; internal set; }

        public void Details()
        {
            
            Console.WriteLine("Enter the Id:");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter DOB:");
            DateTime dateTime = new DateTime();
            



        }
        
        public void Get_details()
        {
            Console.WriteLine("Name:{0}\nId:{1}\nDOB:{2}\nAGE:{3} yrs", Name, Id, DOB, get_age());
        }

      
        public string getDob(DateTime birthdate)
        {
            BirthDate = birthdate;
            return (string)BirthDate.ToShortDateString();
        }

       
        public int get_age()
        {
            int year = DateTime.Now.Year;
            int age = year - DOB;
            return age;
        }
    }
}











