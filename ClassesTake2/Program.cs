using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTake2
{
    class Program
    {
        static void Main(string[] args)
        //obtain the information about the employee and store it as variables 
        {
            Console.WriteLine("Please enter employee's first name");
            string fname = Console.ReadLine();
            Console.WriteLine("Please enter the same employee's lastname");
            string lname = Console.ReadLine();
            Console.WriteLine("please make up a tax rate for the employee");
            double tax = double.Parse(Console.ReadLine());
            Console.WriteLine($"Please enter {fname}'s Gross");
            double gross = double.Parse(Console.ReadLine());


            // Create an employee object using the constructor and populating it with 
            //the variables where we saved the employee's info.
            Employee p1 = new Employee(fname, lname, tax, gross);

            //Display the info. back to the user using the employee object (p1.)
            Console.WriteLine($"Employee's name {p1.Fname}{p1.Lname} Tax rate: {p1.Tax}% " +
                $"Gross: {p1.Gross} Take home pay: (employee's net) {p1.Net()}");
            Console.ReadLine();
        }
    }
    

    class Employee
    {   //get and set 
        public string Fname { get; set; }
        public string Lname { get; set; }
        public double Tax { get; set; }
        public double Gross { get; set; }

        //constructor list
        public Employee (string _fname, string _lname, double _tax, double _gross)
        {
            Fname = _fname;
            Lname = _lname;
            Tax = _tax;
            Gross = _gross;
        }
        //Method (for calulating net in this example)
        public double Net()
        {
            return Gross * (1 - Tax / 100);
        }
    }
}