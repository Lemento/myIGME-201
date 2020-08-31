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
            // Proceed to then convert each user inputted string into an integer for multiplication
            Console.WriteLine("Please input first value...");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input second value...");
            var2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input third value...");
            var3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input fourth value...");
            var4 = Convert.ToInt32(Console.ReadLine());

            // Give console visual of all the variables they had inputted to be multiplied
            Console.WriteLine("var1: " + var1 + ", var2: " + var2 + ", var3: " + var3 + ", var4: " + var4);

            // make resultVar equal to the product of all the variables and output it to the console
            resultVar = (var1 * var2 * var3 * var4);
            Console.WriteLine("The product is: " + resultVar);
        }
    }
}
