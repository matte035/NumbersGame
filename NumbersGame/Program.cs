using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 10);
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök");
            int answer;
            Program P = new Program();
            int guess = P.CheckGuess;


            for (int i = 0; i < 5; i++)
            {
                answer = int.Parse(Console.ReadLine());
                if (answer == number)
                {
                    Console.WriteLine("Grattis du har svarat rätt! :)");

                }
                else if (answer < number)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");

                }
                else if (answer > number)
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                }

                if (i >= answer)
                {
                    Console.WriteLine("Tyvärr du har gissat fel för många gånger");
                    
                }


            }



        }
        static int CheckGuess(int guess)
        {
            Console.WriteLine("Du har gisssat"+ guess ++);
        }

    }
}
   


