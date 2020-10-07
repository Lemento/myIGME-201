using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14Q1
{
    public interface Interface1
    {
        void IMethod();
    }

    public class Class1 : Interface1
    {
        public void IMethod()
        {
            Console.WriteLine("This is called by Class1.");
        }
    }

    public class Class2 : Interface1
    {
        public void IMethod()
        {
            Console.WriteLine("This is called by Class2.");
        }
    }


    class Program
    {
        public static void MyMethod(object myObject)
        {
            Interface1 interface1 = (Interface1)myObject;
            interface1.IMethod();
        }

        static void Main(string[] args)
        {
            Interface1 class1 = new Class1();
            Interface1 class2 = new Class2();

            MyMethod(class1);
            MyMethod(class2);
        }
    }
}
