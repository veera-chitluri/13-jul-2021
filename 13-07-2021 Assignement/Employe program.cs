using System;

namespace EMploye_Assignement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the salary of the Employe");
            double Salary = int.Parse(Console.ReadLine());
            Employe Obj = new Employe(Salary);

            Console.WriteLine("Enter the ID of the Employe");
            Obj.EmployeId = int.Parse(Console.ReadLine ());
            Console.WriteLine("Enter the Name of the Employe");
            Obj.Name = Console.ReadLine();
            Console.WriteLine("Enter the Designation of the Employe");
            Obj.Designation = Console.ReadLine();
            Console.WriteLine($"EmployeId :{Obj.EmployeId},\n  Name : {Obj.Name},\n Designation : {Obj.Designation}, \n  Salary : {Obj.Salary}"  );
                





        }
    }
}
