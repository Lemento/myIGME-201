using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Data;

namespace Madlibs_PhillipDaGamaPaes
{
    class Program
    /// Class: Program
    /// Author Phillip Da Gama Paes
    /// Purpose: Contains the method from which Mad Libs will occur
    /// Restrictions: None
    {
        static void Main(string[] args)
        /// Method: Main
        /// Purpose: Loads up Mad Libs stories from text file and prompts the user to start
        /// and replace the words as they come up, ending with their generated story
        /// Restrictions: Every time a word is concatenated, a space is made before it in order 
        /// to maintain grammatical purity, but also causes every new line to start with a space.
        {
            EventStart:

            Console.WriteLine("Enter your name. ");
            string playerName = Console.ReadLine();


            int numLibs = 0;
            int cntr = 0;
            int nChoice = 0;

            StreamReader input;

            // open the template file to count how many Mad Libs it contains
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }

            // close it
            input.Close();

            // only allocate as many strings as there are Mad Libs
            string[] madLibs = new string[numLibs];

            // read the Mad Libs into the array of strings
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            line = null;
            while ((line = input.ReadLine()) != null)
            {
                // set this array element to the current line of the template file
                madLibs[cntr] = line;

                // replace the "\\n" tag with the newline escape character
                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                ++cntr;
            }

            input.Close();

            // Declare exit variable for while loop called gameConfirm and Ask the user if they wish to play
            bool gameConfirm = false;
            do
            {
                Console.WriteLine("Hello " + playerName + ", would you like to play Mad Libs?");
                // Create a variable to store the users reply
                var check = Console.ReadLine();
                check = check.Trim();
                check = check.ToLower();
                // If they select yes, move on
                if (check == "yes")
                {
                    gameConfirm = true;
                }
                // If they select no, they are taken to the end of the program via 
                else if (check == "no")
                {
                    goto EventEnd;
                }

                // Anything other than yes or no or any capitalized variants will prompt them again
            } while (gameConfirm == false);

            // prompt the user for which Mad Lib they want to play (nChoice)
            Console.WriteLine("Choose a story to play. Enter a number between 1 and " + numLibs);

            // Create an event to circle bask to every time the user types an invalid answer
            EventChoice:
            try
            {
                nChoice = Convert.ToInt16(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid choice, please enter a integer\n");
                goto EventChoice;
            }

            if (nChoice <= 0 || nChoice > numLibs)
            {
                Console.WriteLine("Invalid choice, please enter a number between 1 and " + numLibs + "\n");
                goto EventChoice;
            }
            else
            {
                nChoice--;
            }


            // split the Mad Lib into separate words
            string[] words = madLibs[nChoice].Split(' ');

            // Declare the string the finished mad lib will be stored in
            string resultString = null;

            Console.WriteLine("Type in a replacement for every word that pops up.");

            foreach (string word in words)
            {
                
               
                
                
                if (word == "\n")
                {
                    resultString += '\n';
                    // if word is a placeholder
                } else if (word[0] == '{')
                {
                    string wordReplace = word;
                    wordReplace = wordReplace.Replace("_", " ");
                    wordReplace = wordReplace.Replace("{", "");
                    wordReplace = wordReplace.Replace("}", "");
                    
                    // prompt the user for the replacement
                    Console.WriteLine("\n" + wordReplace);
                    
                    // and append the user response to the result string
                    resultString += ' ' + Console.ReadLine();
                }
                // else append word to the result string
                else
                {
                    resultString += ' ' + word;
                }
            }
            // Clear the console and print out the finished madlib
            Console.Clear();
            Console.WriteLine(resultString);


            // Event to goto had the user said the didn't want to play Mad Libs
            EventEnd:
            if(gameConfirm == true)
            {
                Console.WriteLine("\nWould you like to play again?\n Please type yes or no.");
                if(Console.ReadLine() == "yes")
                {
                    Console.Clear();
                    goto EventStart;
                }
            }
            Console.WriteLine("\ngoodbye");
        }
    }
}
