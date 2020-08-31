using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3__5
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables for user input and their product
            int var1, var2, var3, var4;
            int resultVar;

            // For each variable, ask user to input the value to be multiplied with the others
            Console.WriteLine("Please input first value...");
            Console.WriteLine("Please input second value...");
            Console.WriteLine("Please input third value...");
            Console.WriteLine("Please input fourth value...");

            // Proceed to then convert each user inputted string into an integer for multiplication
            var1 = Convert.ToInt32(Console.ReadLine());
            var2 = Convert.ToInt32(Console.ReadLine());
            var3 = Convert.ToInt32(Console.ReadLine());
            var4 = Convert.ToInt32(Console.ReadLine());

            // Give console visual of all the variables they had inputted to be multiplied
            Console.WriteLine("var1: " + var1 + ", var2: " + var2 + ", var3: " + var3 + ", var4: " + var4);

            // make resultVar equal to the product of all the variables and output it to the console
            resultVar = (var1 * var2 * var3 * var4);
            Console.WriteLine("The product is: " + resultVar);
        }
    }
}
