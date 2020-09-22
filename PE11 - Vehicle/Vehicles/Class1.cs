using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
        /// Class: Vehicle
        /// Author: Phillip
        /// Purpose: Parent class for all vehicle objects
        /// Restrictions: Can't be instantiated
    {
        public virtual void LoadPassenger() { }
        /// Purpose: Empty method to be inherited by vehicles
        /// Restrictions: None
    }

    public interface IPassengerCarrier
        /// Purpose: Interface that contains empty method
        /// Restrictions: None
    {
        void LoadPassenger();
        /// Purpose: Empty method to be inherited by vehicles that load passengers
        /// Restriction: None
    }

    public interface IHeavyLoadCarrier
        /// Purpose: Interface that contains empty method
        /// Restrictions: None
    {

    }

    public abstract class Car : Vehicle
        /// Class: Car
        /// Purpose: Class that inherits from vehicle
        /// Restrictions: Can't be instantiated
    {

    }


    public abstract class Train : Vehicle
        /// Class: Train
        /// Purpose: Class that inherits from vehicle
        /// Restrictions: Can't be instantiated
    {

    }

    public class Compact : Car, IPassengerCarrier
        /// Class: Compact
        /// Purpose: Class that inherits from parent class Car and interface IPassengerCarrier
        /// Restrictions: None
    {

    }

    public class SUV : Car, IPassengerCarrier
        /// Class: SUV
        /// Purpose: Class that inherits from parent class Car and interface IPassengerCarrier
        /// Restrictions: None
    {

    }

    public class Pickup : Car, IPassengerCarrier, IHeavyLoadCarrier
        /// Class: Pickup
        /// Purpose: Class that inherits from parent class Car and interfaces IPassengerCarrier and IHeavyLoadCarrier
        /// Restrictions:None
    {

    }

    public class PassengerTrain : Train, IPassengerCarrier
        /// Class: PassengerTrain
        /// Purpose: Class that inherits from parent class Train and interface IPassengerCarrier
        /// Restrictions: None
    {

    }

    public class FreightTrain : Train, IHeavyLoadCarrier
        /// Class: FreightTrain
        /// Purpose: Class that inherits from parent class Train and interface IHeavyLoadCarrier
        /// Restrictions:None
    {

    }

    public class _424DoubleBogey : Train, IHeavyLoadCarrier
        /// Class: 424DoubleBogey
        /// Purpose: Class that inherits from parent class Train and interface IHeavyLoadCarrier
        /// Restrictions: None
    {

    }
    public class Class1
    {

    }
}
