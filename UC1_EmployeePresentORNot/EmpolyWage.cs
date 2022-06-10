namespace Basicprogram

{
    internal class EmployeeWage
    {

      
        public const int IsAbsnt = 0;
        public const int IsPresent= 1;
       
        public int IsEmployeePresent()
        {
            return new Random().Next(0, 2);
        }
         public void CalculateWage()
        {
        switch(IsEmployeePresent())
            {
                case IsAbsnt:
                    Console.WriteLine("Employee is Not Present");
                    break;
                case IsPresent:
                    Console.WriteLine("Employee is Present");
                    break ;
            }


        }
            }
}

    