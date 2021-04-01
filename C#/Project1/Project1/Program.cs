using System;

namespace Project1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Simple Project Start");

            Asiakas a1 = new Asiakas("id1", "Pekka", "2020-12-12", "12-07-1989");

            a1.Tulosta();


            // tilaus
            Tilaus t1 = new Tilaus("Whisky", "25", "4", "til1");
            t1.Tulosta();
        }
    }
}
