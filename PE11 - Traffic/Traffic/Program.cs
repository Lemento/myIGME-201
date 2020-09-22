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
        /// Class: Program
        /// Author: Phillip Da Gama Paes
        /// Purpose: Contains functions that use external dll
        /// Restricitons: None
    {
        static void AddPassenger(IPassengerCarrier car)
            /// Purpose: To run a function from an objects interface
            /// Restrictions: Doesn't work with classes whose objects didn't inherit IPassengerCarrier interface
        {
            car.LoadPassenger();
        }
        static void Main(string[] args)
            /// Purpose: To declare interface from created object and send it into function AddPassenger
            /// Restrictions: None:
        {
            IPassengerCarrier myCar = new SUV();
            AddPassenger(myCar);
        }
    }
}
