using System;
namespace Project1
{
    public class Tilaus
    {
        public string TilausId { get; set; }
       
        public string ProductName { get; set; }
        public string Hinta { get; set; }
        public string Märä { get; set;  }

        public string[] Tilauksia
        {
            get
            {
                return new String[] {TilausId, ProductName, Hinta, Märä
                };
            }
        }

        public Tilaus()
        {
        }
        public Tilaus(string pName, string hinta, string qty, string id)
        {
            ProductName = pName;
            Hinta = hinta;
            Märä = qty;
            TilausId = id;

        }
        public void Tulosta()
        {
            Console.WriteLine($"Tilaus ID {TilausId }");
            for(int i=0; i<Tilauksia.Length; i++)
            {
                Console.WriteLine($"{Tilauksia[i] }");
            }
            
           
        }
    }
}
