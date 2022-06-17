using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprogram
{
    internal class EmpolyWage : ICompute_Emp_Wage
    {
        public int EmpCheak = 1;
        public const int FullTime = 1;
        public int DailyWage = 0;
        public int Num_Working_permonth = 20;
        public const int ISAbest = 0;
        public float EmpDailyWage = 0;
        public const int IsPartTime = 2;
        public float EmpMonthlyWage = 0;
        // public string[] CompanyList;
        public ArrayList CompanyList;
        public int ArrayIndex = 0;
        private Dictionary<String, Company> Compaies = new Dictionary<String, Company>();



        public EmpolyWage(int Number)//Constructor
        {
            // CompanyList = new string[Number * 2];
            CompanyList = new ArrayList();
        }
        public void AddCompany(String CompanyName, int EmpWagePerHourse, int FullTime_Daily_Hours, int PartTime_Day_Hours, int Max_WorkingHrs, int Max_WorkingDay)
        {
            Company company = new Company(CompanyName.ToLower(), EmpWagePerHourse, FullTime_Daily_Hours, PartTime_Day_Hours, Max_WorkingDay, Max_WorkingHrs);
            Compaies.Add(CompanyName.ToLower(), company);
            // CompanyList[ArrayIndex]=CompanyName;
            CompanyList.Add(CompanyName);
            CompanyList.Add(EmpWagePerHourse * FullTime_Daily_Hours);
            ArrayIndex++;
        }
        public int IsEmpPeresnt()
        {
            return new Random().Next(0, 3);
        }

        public void CalculateWage(String CompanyName)
        {
            int DayNumber = 1;
            int EmpWorkingHrs = 0;
            int TotalWorkingHrs = 0;
            if (!Compaies.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentNullException("Company don't exist");
            Compaies.TryGetValue(CompanyName.ToLower(), out Company company);
            while (DayNumber <= company.Max_WorkingDay && TotalWorkingHrs <= company.Max_WorkingHrs)
            {
                switch (IsEmpPeresnt())
                {
                    case ISAbest:
                        EmpWorkingHrs = 0;
                        break;
                    case IsPartTime:
                        EmpWorkingHrs = company.PartTime_Day_Hours;
                        break;
                    case FullTime:
                        EmpWorkingHrs = company.FullTime_Daily_Hours;
                        break;
                }
                EmpDailyWage = EmpWorkingHrs * company.EmpWagePerHourse;
                EmpMonthlyWage += EmpDailyWage;
                DayNumber++;
                TotalWorkingHrs += EmpWorkingHrs;
            }
            // CompanyList[ArrayIndex]=Convert.ToString(EmpMonthlyWage);
            // ArrayIndex++;
            CompanyList.Add(EmpMonthlyWage);
            Console.WriteLine("\n Comapny Name  " + CompanyName + "\nTotalWorkingHrs  " + EmpMonthlyWage);
        }

        public void DisplayArray()
        {
            for (int i = 0; i < CompanyList.Count; i += 3)
            {

                Console.WriteLine("\n Monthly wage for {0} with\nDailyWage={1} is {2}\n", CompanyList[i], CompanyList[i + 1], CompanyList[i + 2]);
            }

        }

        public void View_Wage(string Name)
        {
            int Index = CompanyList.IndexOf(Name);
            Console.WriteLine("\n Monthly wage for {0} with\nDailyWage={1} is {2}\n", CompanyList[Index], CompanyList[Index + 1], CompanyList[Index + 2]);

        }

    }
}