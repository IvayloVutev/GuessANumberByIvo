using System;

namespace GuessANumber
{
    class GuessANumber
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);
            int countTheTryes = 0;

            Console.Write("Choose a level of difficulty - [easy] [medium] [hard]: ");
            string difficult = Console.ReadLine();
            Difficult(difficult);
            int numberOfgames = Difficult(difficult);
  
            Console.WriteLine($"You have {numberOfgames} tryes to guess the number");
            Console.WriteLine();
            
            while (true)
            {
                countTheTryes++;

                if (countTheTryes <= numberOfgames)
                {
                    Console.Write("Guess a number (1-100): ");
                }
                else if (countTheTryes > numberOfgames)
                {
                    Console.WriteLine("Game over");
                    Console.Write("Type [yes] to Play Again or [no] to quit: ");
                    string input = Console.ReadLine();

                    if (input == "yes")
                    {
                        countTheTryes = 0;
                        continue;
                    }
                    else if (input == "no")
                    {
                        break;
                    }
                }
 
                string playerInput = Console.ReadLine();
                bool isValid = int.TryParse(playerInput, out int playerNumber);

                if (isValid)
                {
                    if (playerNumber == computerNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if (playerNumber > computerNumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else
                    {
                        Console.WriteLine("Too Low");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }
        }

        static int Difficult(string text)
        {          
            int numberOfgames = 0;
            if (text == "easy")
            {
                numberOfgames = 11;
            }
            else if (text == "medium")
            {
                numberOfgames = 7;
            }
            else if (text == "hard")
            {
                numberOfgames = 5;
            }
            else
            {
                Console.WriteLine("Invalid level");
                
            }
            return numberOfgames;
        }
    }
}
