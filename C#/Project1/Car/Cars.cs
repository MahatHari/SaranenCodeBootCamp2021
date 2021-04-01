using System;
namespace Car
{
    public class Cars
    {
        public string Name { get; set; }
        private int Nopeus { get; set; }
        protected int MaxSpeed = 220;
        // constructors
        public Cars()
        {
        }
        public Cars(string name, int speed)
        {
            Name = name;
            Nopeus = speed;
        }

        // change speed
        public int IncreaseSpeed(int speed)

        {
            Nopeus += speed;
            if (Nopeus > MaxSpeed)
            {
                Nopeus = MaxSpeed;
            }

            return Nopeus;

        }
        public int DecreseSPeed(int speed)
        {
            return Nopeus -= speed;
        }
        

        // Tulosta Car
        public void Tulosta()
        {
            Console.WriteLine($" Car Name: {Name}");
            Console.WriteLine($" Car Speed: {Nopeus}");

        }
    }
}
