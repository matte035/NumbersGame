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
            

            for (int i = 0; i <antal; i++)
            {

                answer = int.Parse(Console.ReadLine());
                if (answer == number)
                {
                    Console.WriteLine("Grattis du har svarat rätt! :)");
                    return;

                }
                else if (answer < number)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");

                }
                else if (answer > number)
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                }
                Console.WriteLine("Du har gissat "+ (i+1)+" gånger");
                if  (i >= antal -1) 
                
                {
                    Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
                    CheckGuess();
                    return;
                }


                
            }



        }
        static void CheckGuess()

        {
            int guessCount = 0;
            if (guessCount == 5)
            
            {
                
                Console.ReadLine();
            }

        }

    }
}
   


