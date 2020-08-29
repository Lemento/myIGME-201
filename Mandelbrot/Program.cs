using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            bool check = false;

            double imagMin, imagMax, realMin, realMax;

            do
            {
                Console.WriteLine("Please input your image limits.");

                Console.WriteLine("(Default value: 1.2) Set the Min of the ImagCoord");
                imagMin = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("(Default value: -1.2) Set the Max of the imageCoord, must be smaller than last input.");
                imagMax = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("(Default value: -0.6) Set the Min of the realCoord");
                realMin = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("(Default value: 1.77) Set the Max of the realCoord, must be larger than last input.");
                realMax = Convert.ToDouble(Console.ReadLine());

                if (imagMin > imagMax && realMin < realMax)
                {
                    check = true;
                } else
                {
                    Console.WriteLine("Try Again.\n");
                }

            } while (check == false);


            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            for (imagCoord = imagMin; imagCoord >= imagMax; imagCoord -= (imagMin - imagMax)/48)
            {
                for (realCoord = realMin; realCoord <= realMax; realCoord += (realMax - realMin)/80)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
