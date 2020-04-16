using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {   
            int level = 0;
            Console.WriteLine("Welcome to our guessing game...");
            Console.WriteLine("Please, select the level you wish to play.\nPress 1 for Easy.\nPress 2 for Medium \nPress 3 for Hard");
            Console.Write("Enter a level number here: ");
            level = Convert.ToInt32(Console.ReadLine());
            if (level == 1){
                // easy level
                Console.WriteLine("You have selected Easy Level");
                int secretNunber = 6;
                int guess = 0;
                int guessCount = 0;
                int guessLimit = 6;
                bool outOfGuesses = false;

                // Check if the guess is correct and user is still within guess limit
                while(guess != secretNunber && !outOfGuesses){
                    if(guessCount < guessLimit){
                        try
                        {
                            Console.Write("Guess a number between 1 - 10: ");
                            // converts guess input to integer
                            guess = Convert.ToInt32(Console.ReadLine());
                            if (guess == secretNunber){
                                Console.WriteLine("You got it right!");
                                }
                            else if (guess > 10){
                                Console.WriteLine("The value you entered is greater than 10");
                            }
                            else{
                            Console.WriteLine("That was wrong");
                            guessCount++;
                            Console.WriteLine("You have " + (guessLimit - guessCount) + " guesses left");
                        }                  

                            }
                        // If the user enters anything other than a number
                        catch (Exception)
                        {
                            Console.WriteLine("The value you entered is not a number.");
                            
                            }
                    // When the user is out of guess limit
                    } else {
                        outOfGuesses = true;
                        Console.WriteLine("Game over!");
                }
            
                }
            }


            else if (level == 2){
                // Medium
                Console.WriteLine("You have selected Medium Level");
                int secretNunber = 12;
                int guess = 0;
                int guessCount = 0;
                int guessLimit = 4;
                bool outOfGuesses = false;

                while(guess != secretNunber && !outOfGuesses){
                    if(guessCount < guessLimit){
                        try
                        {
                            Console.Write("Guess a number between 1 - 20: ");
                            guess = Convert.ToInt32(Console.ReadLine());
                            if (guess == secretNunber){
                                Console.WriteLine("You got it right!");
                        }
                            else if (guess > 20){
                                Console.WriteLine("The value you entered is greater than 20");
                            }
                            else{
                            Console.WriteLine("That was wrong");
                            guessCount++;
                            Console.WriteLine("You have " + (guessLimit - guessCount) + " guesses left");
                        }                  

                            }
                        catch (Exception)
                        {
                            Console.WriteLine("The value you entered is not a number.");
                            
                            }

                    } else {
                        outOfGuesses = true;
                        Console.WriteLine("Game over!");
                    }
                }
            }

            else if (level == 3){
                // Hard
                Console.WriteLine("You have selected Hard Level");
                int secretNunber = 43;
                int guess = 0;
                int guessCount = 0;
                int guessLimit = 3;
                bool outOfGuesses = false;

                while(guess != secretNunber && !outOfGuesses){
                    if(guessCount < guessLimit){
                        try
                        {
                            Console.Write("Guess a number between 1 - 50: ");
                            guess = Convert.ToInt32(Console.ReadLine());
                            if (guess == secretNunber){
                                Console.WriteLine("You got it right!");
                        }
                            else if (guess > 50){
                                Console.WriteLine("The value you entered is greater than 50");
                            }
                            else{
                            Console.WriteLine("That was wrong");
                            guessCount++;
                            Console.WriteLine("You have " + (guessLimit - guessCount) + " guesses left");
                        }                  

                            }
                        catch (Exception)
                        {
                            Console.WriteLine("The value you entered is not a number.");
                            
                            }

                    } else {
                        outOfGuesses = true;
                        Console.WriteLine("Game over!");
                    }
                }
            }
            else{
                Console.WriteLine("You have entered an invalid number");
            }
        }
    }
}
