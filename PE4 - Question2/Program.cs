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
            bool prog = true;
            while (prog == true)
            {
                int var1, var2;
                Console.WriteLine("Give me two values, one thats greater than 10, and one that isn't.");

                Console.WriteLine("Please input first value");
                var1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Please input second value");
                var2 = Convert.ToInt16(Console.ReadLine());

                if ((var1 > 10 && var2 > 10) || (var1 <= 10 && var2 <= 10))
                {
                    Console.WriteLine("\nOnly one value can be bigger than 10.\n");
                } else if (var1 < 10)
                {
                    Console.WriteLine(var1 + " is greater than " + var2);
                    prog = false;
                } else
                {
                    Console.WriteLine(var2 + " is greater than " + var1);
                    prog = false;
                }
            }
        }
    }
}
