using System;

namespace DatePractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Working the C# Dates");

            DateTime dob =  DateTime.Parse("12-07-1989");
            Console.WriteLine(dob.DayOfWeek);
            Console.WriteLine(dob.Month);

            Console.WriteLine("Give Date mm.dd.yy");
            string da = Console.ReadLine();
            DateTime date = DateTime.Parse(da);

            DateTime aweekLate = date.AddDays(7);

            Console.WriteLine(aweekLate);
            Console.WriteLine(DateTime.Now);

        }
    }
}
