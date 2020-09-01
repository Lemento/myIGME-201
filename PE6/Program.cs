using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6
{
    // Declare program that will hold the main method the program will call on
    class Program
    {
        // Declare method that will contain all the code that the program will run
        static void Main(string[] args)
        {
            // Create random instance and declare a new variable and 
            // set it equal to a random number between 0 and 100
            Random rand = new Random();
            int randomNumber = rand.Next(0, 101);

            // print the variables assigned random value
            Console.WriteLine(randomNumber);

            // declare variable for incrementing in the while loop and boolean for user success
            int i = 0;

            // Declare user input variable as well as tip string
            int guess = 0;
            string tip = null;

            // Introduce the rules of the game
            Console.WriteLine("\nGuess a number between 0 and 100.");

            // for loop that ends after giving the user eight tries to guess the random number
            do
            {

                // After their first try, output to the console how many tries they have left
                // Output when its their last try in order to add pressure
                if (i == 7)
                    Console.WriteLine("\nLast Try.");
                else if (i > 0)
                    Console.WriteLine("\nTries left: " + (7 - i));

                // Checks if the guess is an integer, if not then they are put into 
                // another while loop until their guess is valid so they do not use up their turns
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Not an integer");
                }
                
                // Check is guess is wrong, if so output tips to console
                if (guess != randomNumber)
                {
                    // Checks if guess was lower or higher than the answer, then outputs to string
                    if (guess < randomNumber)
                        tip = "low";
                    else
                        tip = "high";

                    // Outputs that the user is incorrect and whether their too low or high
                    Console.WriteLine("\nIncorrect, your guess was too " + tip);

                    // Outputs vague location of the answer if the guess was too distant
                    if (randomNumber >= 66 && guess <= 66)
                        Console.WriteLine("The answer is above 65");
                    else if (randomNumber <= 33 && guess >= 33)
                        Console.WriteLine("The answer is below 34");
                    else if (randomNumber >= 34 && guess <= 33 || guess >= 66)
                        Console.WriteLine("The answer is inbetween 33 and 66");
                    else
                        Console.WriteLine("You are getting very close");

                    // Tells user if one of their digits matches the answers as a clue
                    if (randomNumber % 10 == guess % 10 || randomNumber - (randomNumber%10) == guess - (guess%10))
                        Console.WriteLine("One of your digits matches one of the answers digits");
                }

                i++;
            }
            // Loop while loop as long as user has gone less than eight times and hasn't won
            while (i < 8 && guess != randomNumber);

            // Check if user succeeded in guessing the random number
            // If so, then write congratulations along with turns taken and score, 
            // if not than write failure with the correct answer
            if (guess == randomNumber)
            {
                Console.WriteLine("\nCongratulations, you won the game! Turns taken: " + i);

                // Added score based on number of turns taken, highest possible score is 1000,
                // while the lowest is 300
                Console.WriteLine("Your score is: " + (1000 - (i - 1) * 100));
            } else
            {
                Console.WriteLine("\nYou lost. The correct number was " + randomNumber + ".");
            }
        }
    }
}
