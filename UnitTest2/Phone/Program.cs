using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2Q4
{
    public abstract class Phone
    {
        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            set
            {
                this.phoneNumber = value;
            }
        }
        private string address;
    }

    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }

    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }

        public void Connect()
        {

        }

        public void Disconnect()
        {

        }
    }

    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }

        public void Connect()
        {

        }

        public void Disconnect()
        {

        }
    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewDriver;
        private byte whichDrWho;
        public byte WhichDrWho
        {
            get
            {
                return this.whichDrWho;
            }
        }

        private string femaleSideKick;
        public string FemaleSideKick
        {
            get
            {
                return this.FemaleSideKick;
            }
        }

        public double exteriorSurfaceArea;
        public double interiorVolume;

        public void TimeTravel()
        {

        }
    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superman;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor()
        {

        }

        public void CloseDoor()
        {

        }
    }

    class Program
    {
        static void UsePhone(object obj)
        {
            PhoneInterface phone = (PhoneInterface)obj;
            phone.MakeCall();

            if (obj.GetType() == typeof(PhoneBooth))
            {
                PhoneBooth booth = (PhoneBooth)obj;
                booth.OpenDoor();
            }
            else if (obj.GetType() == typeof(Tardis))
            {
                Tardis tardis = (Tardis)obj;
                tardis.TimeTravel();
            }
        }
        static void Main(string[] args)
        {
            Tardis mytardis = new Tardis();
            PhoneBooth mybooth = new PhoneBooth();

            UsePhone(mytardis);
            UsePhone(mybooth);
        }
    }
}
