using System;
namespace Project1
{
    public class Asiakas

    {
        public string AsiakasId { get; set; } = "";
        public string FullName { get; set; } = "";
        public string RegDate { get; set; } = "";
        public DateTime DoB { get; set; }
        public int Age {

            get
            {
                int age = DateTime.Now.Year - DoB.Year;
                if (age > 0)
                    age -= Convert.ToInt32(DateTime.Now < DoB.Date.AddYears(age));
                else
                    age = 0;
                return age;
            }
        }


        //constructors
        public Asiakas()
        {
        }
        public Asiakas(string id, string fName, string regDate, string dob)
        {
            AsiakasId = id;
            FullName = fName;
            RegDate = regDate;
            DoB = Convert.ToDateTime(dob);

        }
        public void Tulosta()
        {
            Console.WriteLine( $"Asiakas ID {AsiakasId }");
            Console.WriteLine($"Asiakas Niemi {FullName }");
            Console.WriteLine($"Asiakas rekestrori päivä: { RegDate}");
            Console.WriteLine($" Ikä : {Age }");
        }
        
    }
}
