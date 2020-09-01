using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_DaGama
{
    // Declare class that contains the main programs method    
    class Program
    {
        // Declare static void method that will hold the functions the console app will run
        static void Main(string[] args)
        {
            // Output message to console
            Console.WriteLine("I'm Phillip, and I can count to ten");

            // Output a count from one to ten in the console
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine("x is {0}", x);
            }
        }
    }
}
