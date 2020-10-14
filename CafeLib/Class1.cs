using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        public virtual int AddSugar(byte amount)
        {
            return amount;
        }

        public abstract void Steam();

        public HotDrink()
        {

        }

        public HotDrink(string brand)
        {

        }
    }

    public interface IMood
    {
        string Mood
        {
            get;
        }
    }

    public interface ITakeOrder
    {
        void TakeOrder();

    }
    public class Walter : IMood
    {
        public string name;

        public string Mood
        {
            get;
        }

        public void ServeCustomer(HotDrink cup)
        {

        }
    }

    public class Customer : IMood
    {
        public string name;
        public string creditCardNumber;
        public string Mood
        {
            get;
        }

        public class CupOfCoffee : HotDrink, ITakeOrder
        {
            public string beanType;

            public override void Steam()
            {
                
            }

            public void TakeOrder()
            {

            }

            public CupOfCoffee(string brand) : base(brand)
            {

            }

            public class CupOfTea : HotDrink, ITakeOrder
            {
                public string leafType;

                public override void Steam()
                {

                }

                public void TakeOrder()
                {

                }

                public CupOfTea(bool customerIsWealthy)
                {

                }

                public class CupOfCocoa : HotDrink, ITakeOrder
                {
                    public static int numCups;
                    public bool marshmallows;
                    private string source;

                    public string Source
                    {
                        set { source = value; }
                    }

                    public override void Steam()
                    {
                        
                    }

                    public override int AddSugar(byte amount)
                    {
                        return base.AddSugar(amount);
                    }

                    public void TakeOrder()
                    {

                    }

                    public CupOfCocoa() : this(false)
                    {
                       
                    }

                    public CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand")
                    {

                    }
                }
            } 
        }
    }
}
