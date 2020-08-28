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
            int var1, var2, var3, var4;
            int resultVar;

            Console.WriteLine("Please input first value...");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input second value...");
            var2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input third value...");
            var3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input fourth value...");
            var4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("var1: " + var1 + ", var2: " + var2 + ", var3: " + var3 + ", var4: " + var4);

            resultVar = (var1 * var2 * var3 * var4);
            Console.WriteLine("The product is: " + resultVar);
        }
    }
}
