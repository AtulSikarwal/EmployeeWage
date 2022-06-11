using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprogram
{
    internal class Company
    {
        public float EmpWagePerHourse = 20;
        public int FullTime_Daily_Hours = 8;
        public int PartTime_Day_Hours = 4;
        public  int Max_WorkingHrs = 20;
        public  int Max_WorkingDay = 100;
        public String CompanyName;

        public Company(String CompanyName,float EmpWagePerHourse, int FullTime_Daily_Hours, int PartTime_Day_Hours, int Max_WorkingHrs, int Max_WorkingDay)
        {
          this.CompanyName = CompanyName;
            this.EmpWagePerHourse= EmpWagePerHourse;
            this.FullTime_Daily_Hours= FullTime_Daily_Hours;
            this.PartTime_Day_Hours = PartTime_Day_Hours;
            this.Max_WorkingHrs = Max_WorkingHrs;
            this.Max_WorkingDay = Max_WorkingDay;
        }
    }
}
