/* Author: Robert Nazinitsky
 * Date: 9/19/19
 * Class: ISM 4300
 * Description: Takes user's name and displays a welcome message and then runs a guesssing game if the user wants to play.
 * Purpose: Practice using methods
 */
 using System;

namespace method_example
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //initalize a boolean for launching guessing game
                Boolean b = true;

                //ask for user's name
                Console.WriteLine("What is your name?");
                string inputName = Console.ReadLine();
                Welcome(inputName);//calls the welcome message for the user.

                //prompts user if they want to play
                Console.WriteLine("Would you like to play a guessing game? (Enter Y/N): ");
                string playGame = Console.ReadLine();

                //if they respond yes
                if (playGame == "Y")
                {
                    while (b == true) //continually run the game
                    {
                        b = GuessingGame();//unless the user gets bored or incorrectly enters input.
                    }
                }
                //if they don't want to play, say nice to meet you.
                else
                {
                    Console.WriteLine("Okay. Nice to meet you " + inputName + ". Have a nice day.");
                }
            }
            catch
            {
                Console.WriteLine("An unknown error has occured.");
            }
            
        
        }
        private static void Welcome(string name) //welcome method takes a name as a string and displays hello.
        {
            Console.WriteLine("Hello " + name + "!");
        }

        private static Boolean GuessingGame() //guessing game will run and return either true or false
        {
            Random rand = new Random();
            int winningNumber = rand.Next(1, 10);//sets the winning number to a random number 1-10.
            Console.WriteLine("Guess a number 1-10: ");

            try //verifies that the input can be parsed as an int
            {
                int guess = int.Parse(Console.ReadLine());
                if (guess == winningNumber) // if the guess is correct
                {
                    Console.WriteLine("You won! You guessed the number " + winningNumber + " correcly.");
                }
                else //if the guess is wrong
                {
                    Console.WriteLine("You guessed the number incorrectly. The correct number was: " + winningNumber);
                }
            }
            catch //otherwise catch the error in input
            {
                Console.WriteLine("Please only enter a number 1-10 as your guess.");
            }

            //ask if the user wants to play again
            Console.WriteLine("Would you like to play again? (Enter Y/N)");
            string playAgain = Console.ReadLine();

            //if yes
            if (playAgain == "Y")
            {
                return true;
            }
            //if no
            else if (playAgain == "N")
            {
                Console.WriteLine("Thank you for playing!");
                return false;
            }
            //if other, exit
            else
            {
                Console.WriteLine("You didn't enter a valid input, exiting the code.");
                return false;
            }
        }
    }
}
