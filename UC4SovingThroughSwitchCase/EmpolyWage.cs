namespace Basicprogram

{
    internal class EmployeeWage
    {

      
        public const int IsAbsnt = 0;
        public const int IsPresent= 1;
        public int Wage_Per_Hours = 20;
        public int FullTime_Daily_Hours = 8;
        public int DailyWage = 0;
        public float EmpDailyWage = 0;
        public const int IsPartTime = 2;
        public int PartTime_Day_Hours = 4;

        public int IsEmployeePresent()
        {
            return new Random().Next(0, 3);
        }
        public void CalculateWage()
        {
            int EmpWorkingHrs = 0;
            switch (IsEmployeePresent())
            {
                case IsAbsnt:
                    Console.WriteLine("Employee is Not Present");
                    break;
                case IsPresent:
                    Console.WriteLine("Employee is Present");
                    EmpWorkingHrs = FullTime_Daily_Hours;
                    break;
                case IsPartTime:
                    EmpWorkingHrs = PartTime_Day_Hours;
                    break;
            }
            EmpDailyWage = EmpWorkingHrs * Wage_Per_Hours;
            Console.WriteLine(EmpDailyWage);

        }
            }
}

    