using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PE8_DaGamaPaes
{
    class Program
        /// Class: Program
        /// Author: Phillip Da Gama Paes
        /// Purpose: Contains the projects for questions 5, 7, 8, 9 for PE-8
        /// Restrictions: Couldn't figure out #5
    {
        static void Main(string[] args)
            /// Method: Main
            /// Purpose: Will load up each question concurrently
            /// Restrictions: There is no answer for #5
        {
            // Project for #7
            // Take input and return it in reverse
            Console.WriteLine("Give a sentence to be reversified.");
            string userInput = Console.ReadLine();
            char[] inputCharArray = userInput.ToCharArray();
            for (int i = inputCharArray.Length - 1; i >= 0; i--)
            {
                Console.Write(inputCharArray[i]);
            }
            Console.WriteLine();

            // Project for #8
            // Every occurence of no will be changed to yes
            Console.WriteLine("No means yes");
            string noToYes = Console.ReadLine();
            Console.WriteLine(noToYes.Replace("no", "yes"));
            Console.WriteLine();

            // Project for #9
            // Every inputted word will be quoted
            string wordQuote = Console.ReadLine();
            string[] wordQuoteArray = wordQuote.Split(' ');
            foreach (string i in wordQuoteArray)
            {
                Console.Write( "\"" + i + "\" ");
            }


            /// given the formula z = 3y^2 + 2x - 1
            /// Calulate the z for the following ranges x and y
            /// -1 <= x <= 1 in 0.1 increments
            /// 1 <= y <= 4 in 0.1 increments
            /// Use 3-dimensional arrays to store the values of
            /// x, y, and z


            //double x = -1.0, y = 1.0, z = 0.0, i = 0;
            /*
            double z;

            for (double y = 1.0; y <= 4.0; y += 0.1)
            {
                for (double x = -1.0; x <= 1.0; x += 0.1)
                {
                    
                    z = (3 * (y * y)) + (2 * x) - 1;
double[,,] values = new double[,,] { {x}, {y}, {z} };

                }
            }
            */

        }
    }
}
