using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_DaGama
{
    class Program
    /// Class: Program
    /// Author: Phillip Da Gama Paes
    /// Purpose: Contains anser to PE9, Question 3
    /// Restrictions: none
    {
        // the definition of the delegate function data type
        public delegate void DelM();

        public static void Message()
        {
            Console.WriteLine(Console.ReadLine());
        }
        static void Main(string[] args)
        // Method: Main
        // Purpose: Impersonate the ReadLine Function with a delegate function
        // Restrictions: Can only take user input and echo it

        {
            Console.WriteLine("Input message.");
            DelM output = Message;
            output();
        }
    }
}
