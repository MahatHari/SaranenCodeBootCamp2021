using System;

namespace Car
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cars ");
            Cars urheluAuto = new Cars("Ferrari", 100);
         

            Console.WriteLine("Increasing Speed ");

            for (int i = 0; i < 5; i++)
            {
                urheluAuto.IncreaseSpeed(50);
                urheluAuto.Tulosta();

            }
            Console.WriteLine("Decreasing Speed ");
            for (int i = 0; i < 5; i++)
            {
                urheluAuto.DecreseSPeed(5);
                urheluAuto.Tulosta();

            }
            
            
        }
    }
}
