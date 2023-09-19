using System;

class Program
{
    static void Main(string[] args)
    {
        string again = "yes";
        while (again == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);
            int guesses = 0;

            Console.WriteLine("Welcome to Guess My Number!");
            Console.WriteLine("Choose a number between 1-100:");
            Console.WriteLine("");

            int guessNumber = -1;

            while (magicNumber != guessNumber)
            {
                guesses = guesses + 1;
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());

                if (magicNumber > guessNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guessNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guess it!");
                    if (guesses == 1)
                    {
                        Console.WriteLine($"You made it in {guesses} guess!");
                    }
                    else
                    {
                        Console.WriteLine($"It took you {guesses} guesses!");
                    }
                    
                    Console.Write("Do you want to play again? (yes/no): ");
                    again = Console.ReadLine();
                    if (again == "yes")
                    {
                        Console.WriteLine("");
                    }
                }
            
            }
        }
    }
}