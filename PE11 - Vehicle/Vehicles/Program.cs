using System;
using System.Runtime;

namespace Vehicles
{
    public abstract class Vehicles
    {
        public virtual void LoadPassenger() { }
    }

    public interface IPassengerCarrier
    {
        void LoadPassenger();
    }

    public interface IHeavyLoadCarrier
    {

    }

    public abstract class Car : Vehicles
    {

    }


    public abstract class Train : Vehicles
    {

    }

    public class Compact : Car, IPassengerCarrier
    {

    }

    public class SUV : Car, IPassengerCarrier
    {

    }

    public class Pickup : Car, IPassengerCarrier, IHeavyLoadCarrier
    {

    }

    public class PassengerTrain : Train, IPassengerCarrier
    {

    }

    public class FreightTrain : Train, IHeavyLoadCarrier
    {

    }

    public class _424DoubleBogey : Train, IHeavyLoadCarrier
    {

    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
