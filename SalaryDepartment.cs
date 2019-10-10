using System;
using static System.Console;

namespace Abstract_Virtual_Override_Implementation
{
    public abstract class SalaryDepartment
    {
        public int salary = 0, totalHour = 0, perHour = 100, fixTime = 8;
        public string name;
        public abstract void Display();
        public void SalaryCounter(int bonus, int overTime)
        {
            salary = perHour * fixTime; //100*8
            overTime = overTime + fixTime; // 10=2+8
            if ( overTime > fixTime)
            {
                totalHour = overTime - fixTime;// 2=10-8
                salary = salary + (perHour*totalHour);
            }
            salary = salary + bonus;
            WriteLine("Bonus: {0} TotalTime: {1}", bonus, overTime);
            
        }
    }
}
