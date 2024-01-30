using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Zgadnij numer pomiędzy " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Próba: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " To za dużo!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " To za mało!");
                    }
                    guesses++;
                }
                Console.WriteLine("Numer: " + number);
                Console.WriteLine("WYGRYWASZ!");
                Console.WriteLine("Liczba prób: " + guesses);

                Console.WriteLine("Czy chcesz zagrać ponownie? (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Dzięki za pogranie 8)");

           _  = Console.ReadKey();
        }
    }
}

