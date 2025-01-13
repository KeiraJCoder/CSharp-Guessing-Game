using System;

class Program 
{
    static void Main()
    {
        //Welcome Message
        Console.WriteLine("Welcome to the Number Guessing Game");

        // High score tracking
        int highScore = int.MaxValue;

        while(true)
        {
            Console.WriteLine("Do you want to play the game or check the current High Score? ");
            string choice = Console.ReadLine().ToLower();

            if (choice == "check")
            { 
                if (highScore == int.MaxValue)
                {
                    Console.WriteLine("No high score yet. Be the first to set one!");
                }
                else 
                {
                    Console.WriteLine($"The current high score is {highScore}");
                }
                continue;
            }
            else if (choice != "play")
            {
                Console.WriteLine("Invalid option. Please type either 'play' or 'check'");
                continue;check
            }

        //Generate random number between 1 and 100
        Random random = new Random();
        int targetNumber = random.Next(1,101);

        //Initialise variable

        int guess = 0;
        int attempts = 0;

        //Game loop

        while (guess != targetNumber)
        {
            //Prompt the user for a guess (1-100)
            Console.Write("Enter a number between 1-100 : ");
            string input = Console.ReadLine();

            //Validate input 

            if (int.TryParse(input, out guess))
                {
                    attempts++;
                    if (guess < targetNumber)
                    {
                        Console.WriteLine("Too low, try again!");
                    }
                    else if (guess > targetNumber)
                    {
                        Console.WriteLine("Too high, try again");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You got it");
                        
                        // Update to display high score
                        if (attempts < highScore)
                        {
                            highScore = attempts;
                            Console.WriteLine($"New High Score : {highScore} attempts ");
                        }     
                        else 
                        {
                            Console.WriteLine($"The current High Score is {highScore}");
                        }
                    }
                } else
                {
                    Console.WriteLine("Invalid Input, Please enter a number between 1 and 100");
                }
            }
            // Ask if the user wants to play again
            Console.WriteLine("Do you want to play again? Yes/No ");
            string playAgain = Console.ReadLine().ToLower();

            if (playAgain != "yes")
            {
                Console.WriteLine("Thanks for playing! Goodbye!");
                break;
            }
        }
    }
}