using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 21);
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök");
            int answer;
            int antal = 5;




            for (int i = 0; i < antal; i++)
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

                if  (i >= answer)
                {
                    CheckGuess();

                }

                if (antal < 5)
                {
                    Console.WriteLine();
                }

            }



        }
        static void CheckGuess()

        {
            int GuessCount = 0;
            if (GuessCount == 5)
            {
               
                Console.ReadLine();
            }

        }

    }
}
   


