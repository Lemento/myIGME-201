using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12
{
    public class MyClass
    {
        private string myString = "myString";
        public virtual string GetString()
        {
            return myString;
        }

        public string MyString
        {
            set { myString = value; }
        }
    }

    public class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            return base.GetString() + " (output from the derived class)";
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            MyDerivedClass derived = new MyDerivedClass();

            Console.WriteLine(derived.GetString());
        }
    }
}
