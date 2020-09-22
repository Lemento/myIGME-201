using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    class Program
    {
        static void AddPassenger(IPassengerCarrier car)
        {
            car.LoadPassenger();
        }
        static void Main(string[] args)
        {
            IPassengerCarrier myCar = new SUV();
            AddPassenger(myCar);
        }
    }
}
