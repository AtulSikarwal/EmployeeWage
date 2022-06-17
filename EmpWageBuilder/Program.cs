namespace Basicprogram
{

    class program
    {

        public static void Main(String[] args)
        {
            EmpolyWage Empwage = new EmpolyWage(3);
            Empwage.AddCompany("Dell", 23, 22, 11, 44, 33);
            Empwage.AddCompany("Tcs", 3, 2, 11, 4, 3);
            Empwage.CalculateWage("Tcs");
            Empwage.CalculateWage("Dell");
            Empwage.DisplayArray();

            Console.Write("Enter the name of Company you want to see the total wage of :");
            string Name = Console.ReadLine();
            Empwage.View_Wage(Name);


        }
    }
}