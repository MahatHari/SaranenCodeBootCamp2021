using System;
using System.Collections.Generic;

namespace Generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

         List<string> merkkijonot = new();
            Car c = new Car();
            merkkijonot.Add("Testi");
            merkkijonot.Add("Toinen");
            merkkijonot.Add("Kolmas");

            foreach(string merkkijono in merkkijonot)
            {
                Console.WriteLine(merkkijono);
            }

            // Auto
            Car myCar = new()
            {
                Malli = "VW",
                Merkki = "Jett",
                Speed = 240,
            };
            Car myCar2 = new()
            {
                Malli = "Auddi",
                Merkki = "A7",
                Speed = 240,
            };

            List<Car> cars = new();
            cars.Add(myCar);
            cars.Add(myCar2);

            foreach( Car car in cars)
            {
                Console.WriteLine(car.Malli);
                Console.WriteLine(car.Merkki);
                Console.WriteLine(car.Speed);

            }

            //Dictionary

            Dictionary<int, string> asiakat= new();
            asiakat.Add(100, "Teppo Testaia");
            asiakat.Add(101, "Janu Juho");

            // Enumerating dictionary
            foreach(var asikas in asiakat)
            {
                Console.WriteLine(asikas.Key+ ":" + asikas.Value);
            }

            // Key Value
            foreach(int key in asiakat.Keys)
            {
                string nimi = asiakat[key];
                Console.WriteLine( key+ ": "+ nimi);
            }

        }
    }
}
