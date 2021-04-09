using System;

namespace Generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CarGeneric<int> wheelNum = new CarGeneric<int>();
            wheelNum.Wheels(4);

            CarGeneric<string> WheelType = new CarGeneric<string>();
            WheelType.Wheels("Almunium");

            CarGeneric<string> wheelBrand = new CarGeneric<string>();
            wheelBrand.Wheels("RV4");

            Car c = new Car();

            Console.WriteLine(c);
        }
    }
}
