using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprogram
{
    public interface ICompute_Emp_Wage
    {
        public void AddCompany(String CompanyName, int EmpWagePerHourse, int FullTime_Daily_Hours, int PartTime_Day_Hours, int Max_WorkingHrs, int Max_WorkingDay);
        public void CalculateWage(String CompanyName);
    }

    
}
