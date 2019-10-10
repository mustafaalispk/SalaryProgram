using System;
using static System.Console;

namespace Abstract_Virtual_Override_Implementation
{
    class Worker : SalaryDepartment
    {
        public override void Display()
        {
            WriteLine("Name: {0} FixTime: {1} PerHour: {2}", name, fixTime, perHour);
            WriteLine("---------------------------------------------------------");
            WriteLine("Total salary of {0} : {1}", name, salary);
        }



    }
}
    
