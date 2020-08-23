using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_DaGama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm Phillip, and I can count to ten");

            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine("x is {0}", x);
            }
        }
    }
}
