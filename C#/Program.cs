using System;
namespace csHarjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text =
            System.IO.File.ReadAllLines(@"../num.txt");
            float sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != "")
                {
                    sum += Int32.Parse(text[i]);
                }
            }
            System.Console.WriteLine(sum);
        }
    }
}
