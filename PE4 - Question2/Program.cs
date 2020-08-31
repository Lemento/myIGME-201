using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare bool exit variable for while-loop called done
            bool done = false;

            // make while loop for inputs so that user input events would be repeated were they to fail
            while (done == false)
            {
                // declare empty variable and give user instructions to start the operation
                int var1, var2;
                Console.WriteLine("Give me two values, one thats greater than 10, and one that isn't.");

                // Ask user to input values into both variables that are then converted into integers
                Console.WriteLine("Please input first value");
                var1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Please input second value");
                var2 = Convert.ToInt16(Console.ReadLine());

                // After reading user events, first check if user succeeded 
                // on giving one value greater than ten, and one value less than ten
                if ((var1 > 10 && var2 > 10) || (var1 <= 10 && var2 <= 10))
                {
                    // Check if the user gave two values greater than ten
                    // Give message telling them what they did wrong before loop restarts
                    if (var1 > 10 && var2 > 10)
                        Console.WriteLine("\nOnly one value can be bigger than 10.\n");

                    // Check if the user gave two values less than ten, and tell them so
                    // Give message telling them what they did wrong before loop restarts
                    if (var1 <= 10 && var2 <= 10)
                        Console.WriteLine("\nBoth values less than ten, one must be greater.\n");
                    
                // If the user didn't fail, check if the first value is greater than ten, if not go to else
                // If the first value is greater than ten, output that to console and end loop
                } else if (var1 < 10)
                {
                    Console.WriteLine(var1 + " is greater than " + var2);
                    done = true;

                // Output to console that the second value is greater than the first, and end loop
                } else
                {
                    Console.WriteLine(var2 + " is greater than " + var1);
                    done = true;
                }
            }
        }
    }
}
