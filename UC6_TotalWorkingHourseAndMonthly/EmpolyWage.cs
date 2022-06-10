using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprogram
{
    internal class EmpolyWage
    {
        public int EmpCheak = 1;
        public int Wage_Per_Hours = 20;
        public int FullTime_Daily_Hours = 8;
        public int PartTime_Day_Hours = 4;
        public const int FullTime = 1;
        public int DailyWage = 0;
        public int Num_Working_permonth = 20;
        public const int ISAbest = 0;
        public float EmpDailyWage = 0;
        public const int IsPartTime = 2;
        public float EmpMonthlyWage = 0;
        public const int Max_WorkingDay = 20;
        public const int Max_WorkingHrs = 100;
        public int IsEmpPeresnt()
        {
            return new Random().Next(0, 3);
        }

        public void CalculateWage()
        {
            int DayNumber = 1;
            int EmpWorkingHrs = 0;
            int TotalWorkingHrs = 0;
            while (DayNumber <= Max_WorkingDay && TotalWorkingHrs <= Max_WorkingHrs)
            {
                switch (IsEmpPeresnt())
                {
                    case ISAbest:
                        EmpWorkingHrs = 0;
                        break;
                    case IsPartTime:
                        EmpWorkingHrs = PartTime_Day_Hours;
                        break;
                    case FullTime:
                        EmpWorkingHrs = FullTime_Daily_Hours;
                        break;
                }
                EmpDailyWage = EmpWorkingHrs * Wage_Per_Hours;
                EmpMonthlyWage += EmpDailyWage;
                DayNumber++;
                TotalWorkingHrs += EmpWorkingHrs;
            }
            Console.WriteLine("\nEmp monthlyWage  " + EmpMonthlyWage + "\nTotalWorkingHrs  " + TotalWorkingHrs);
        }

    }
}

