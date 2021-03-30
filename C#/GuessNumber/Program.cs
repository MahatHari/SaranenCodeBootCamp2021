using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int number = r.Next(0, 20);
            System.Console.WriteLine(number);
            int i = 0;
            do
            {
                System.Console.WriteLine("Guess the Number");
                int guess = Int32.Parse(System.Console.ReadLine());
                if (guess > number)
                {
                    System.Console.WriteLine("Your guess  is Greater than number ");
                }
                else if (guess < number)
                {
                    System.Console.WriteLine("Your guess is Less than number");

                }
                else if (guess == number)
                {
                    System.Console.WriteLine("You guessed it");
                    break;
                }
                i++;
            } while (i < 3);
            System.Console.WriteLine("You run out of guess chances");


        }

    }
}
