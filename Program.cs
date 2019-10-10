using System;

namespace Abstract_Virtual_Override_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker Guard = new Worker();
            Guard.name = "Ali";
            Guard.SalaryCounter(0,5);
            Guard.Display();

            Worker Manager = new Worker();
            Manager.name = "Hassan";
            Manager.perHour = 200;
            Manager.SalaryCounter(0, 2);
            Manager.Display();

            
            



        }
    }
}
