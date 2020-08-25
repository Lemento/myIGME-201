using System;
namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10
        // Output N/(N-1) for all 10 numbers
        // and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            // int i = 0
            // Compile-time Error: declaration didn't end with ; (semicolon) and doesnt need to be declared with 0
            int i;

            // allNumbers change: now is called outside for-loop
            string allNumbers = null;

            // loop through the numbers 1 through 10
            // for (i = 1; i & lt; 10; ++i )
            // Compile-time Error; improper use of semicolon and less than operator, should be <=
            for (i = 1; i <= 10; ++i )
                {
                // declare string to hold all numbers
                //string allNumbers = null;
                // Runtime Error: should be declared outside For-loop

                // output explanation of calculation
                // Console.Write(i + &quot;/ &quot; +i - 1 + &quot; = &quot;);
                // Compile-time Error: replace unicode &quot; with " 
                Console.Write("{0} / {1} = ", arg0: i, arg1: i - 1);

                // output the calculation based on the numbers
                // Console.WriteLine(i / (i - 1));
                // Compile-time Error: i - 1 will first equal 0 which will lead to trying to divide by zero
                if (i <= 1)
                    {
                    Console.WriteLine("0");
                } else
                {
                    Console.WriteLine(i / (i - 1));
                }


                // concatenate each number to allNumbers
                // allNumbers += i + &quot; &quot; ;
                // Compile-time Error: Unicode &quot replaced with ""
                allNumbers += i + " ";


                // increment the counter
                // i = i + 1;
                // Runtime Error: For loop already increments the counter 

            
        }
            // output all numbers which have been processed
            // Compile-time Error: &guot unicode should instead be ""
            // Console.WriteLine(&quot; These numbers have been processed: &quot; allNumbers);
            Console.WriteLine(" These numbers have been processed: {0}", arg0: allNumbers);
        }
    }
}