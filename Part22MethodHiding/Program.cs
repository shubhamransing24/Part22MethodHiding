using System;

namespace Part22MethodHiding
{
    class Program
    {
        class Employee
        {
            public string firstname;
            public string lastname;
            public void PrintFullName()
            {
                Console.WriteLine("Full Name={0} {1}", firstname, lastname);
            }
        }
        class FullTimeEmployee :Employee
        {
            int yearlysalary = 400000;
            public new void PrintFullName()
            {
                Console.WriteLine("Full Name ={0} {1} -Contractor",firstname,lastname);
            }
        }
        class PartTimeEmployee : Employee
        {
            int Hourlysalary = 400;
            public new void PrintFullName()
            {
                Console.WriteLine("Full Name={0} {1}-contractor", firstname, lastname);
            }
        }
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.firstname = "Shubham";
            fte.lastname = "Ransing";
            fte.PrintFullName();
            //In method hiding base class reference varibale pointing to derived class object will called base class method and hide child class method
            Employee e = new PartTimeEmployee();
            e.firstname = "Shubham";
            e.lastname = "Ransing";
            e.PrintFullName();
            PartTimeEmployee pte = new PartTimeEmployee();
            pte.firstname = "Saurabh";
            pte.lastname = "Ransing";
            pte.PrintFullName();
            Employee e1 = new PartTimeEmployee();
            e1.firstname = "Saurabh";
            e1.lastname = "Ransing";
            e1.PrintFullName();

        }
    }
}
