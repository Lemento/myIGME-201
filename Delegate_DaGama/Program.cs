using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_DaGama
{   /// Class: Program
    /// Author: Phillip Da Gama Paes
    /// Purpose: Contains anser to PE9, Question 3
    /// Restrictions: none
    class Program
    {
        // the definition of the delegate function data type
        public delegate void DelM();

        // Method: Main
        // Purpose: Impersonate the ReadLine Function with a delegate function
        // Restrictions: Can only take user input and echo it

        public static void Message()
        {
            Console.WriteLine(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input message.");
            DelM output = Message;
            output();
        }
    }
}
