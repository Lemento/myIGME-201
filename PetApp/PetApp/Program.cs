using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management.Instrumentation;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetApp
{
    class Program
    {
        public class Pets
        {
            public List<Pet> petList;
            public Pet this[int nPetEl]
            {
                get
                {
                    Pet returnVal;
                    try
                    {
                        returnVal = (Pet)petList[nPetEl];
                    }
                    catch
                    {
                        returnVal = null;
                    }

                    return (returnVal);
                }

                set
                {
                    if (nPetEl < petList.Count)
                    {
                        petList[nPetEl] = value;
                    }
                    else
                    {
                        petList.Add(value);
                    }
                }
            }

            public int Count
            {
                get { return petList.Count; }
            }

            public void Add(Pet pet)
            {
                petList.Add(pet);
            }

            public void Remove(Pet pet)
            {
                petList.Remove(pet);
            }

            public void RemoveAt(int petEl)
            {
                petList.RemoveAt(petEl);
            }
        }

        public interface ICat
        {
            void Eat();
            void Play();
            void Scratch();
            void Purr();
            void GotoVet();
        }

        public interface IDog
        {
            void Eat();
            void Play();
            void Bark();
            void NeedWalk();
            void GotoVet();
        }

        public abstract class Pet
        {
            private string name = "[BLANK]";
            public int age;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public abstract void Eat();

            public abstract void Play();

            public abstract void GotoVet();

            public Pet(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        public class Cat : Pet, ICat 
        {
            public override void Eat()
            {
                Console.WriteLine(this.Name + " decides to eat.");
            }
            public override void Play()
            {
                Console.WriteLine(this.Name + " plays for a bit.");
            }
            public void Purr()
            {
                Console.WriteLine(this.Name + " purrs in delight.");
            }
            public void Scratch()
            {
                Console.WriteLine("SSSCCCCRRITCH! A violent attack by " + this.Name + "!");
            }
            public override void GotoVet()
            {
                Console.WriteLine(this.Name + " is sent to the vet.");
            }

            public Cat(string name, int age) : base(name, age)
            {

            }
        }

        public class Dog : Pet, IDog
        {
            public string license;

            public override void Eat()
            {
                Console.WriteLine(this.Name + " happily chomps down on dog chow.");
            }

            public override void Play()
            {
                Console.WriteLine(this.Name + " runs into the backyard for a while.");
            }

            public void Bark()
            {
                Console.WriteLine(this.Name + " barks loudily at no one in particular.");
            }

            public void NeedWalk()
            {
                Console.WriteLine(this.Name + " is begging to go outside.");
            }

            public override void GotoVet()
            {
                Console.WriteLine(this.Name + " is going to the vet.");
            }

            public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
            {

            }
        }

        static void Main(string[] args)
        {
            // Create reference variables for pets and interfaces
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();
            Random rand = new Random();


            for (int i = 0; i < 50; i++)
            {
                start:
                // 1 in 10 chance of adding an animal
                if( rand.Next(1, 11) == 1 )
                {
                    // 50% chance of adding a dog
                    if( rand.Next(0, 2) == 0)
                    {
                        // Upon winning the dog, initialize variables and ask for each of their values
                        Console.WriteLine("Congratulations, you won a dog!");

                        string license = null;
                        string name = null;
                        int age = 0;

                        Console.Write("What is its age? ");


                        do
                        {
                            try
                            {
                                age = Int16.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.Write("Please enter an integer: ");
                            }
                        } while (age <= 0);


                        Console.WriteLine("What will you call it? ");
                        try
                        {
                            name = Console.ReadLine();
                        }
                        catch
                        {

                        }

                        Console.WriteLine("Give it a license #: ");
                        try
                        {
                            license = Console.ReadLine();
                        }
                        catch
                        {

                        }

                        // Create new dog passing values to its constructor, and add it to petList
                        
                        pets.Add(dog = new Dog(license, name, age));

                        Console.WriteLine("License: #" + license + ", Name: " + name + ", Age: " + age);
                    }
                    else
                    {
                        // else add a cat
                        // Upon winning the dog, initialize variables and ask for each of their values
                        Console.WriteLine("Congratulations, you won a cat!");

                        string name = null;
                        int age = 0;

                        Console.Write("What is its age? ");


                        do
                        {
                            try
                            {
                                age = Int16.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.Write("\r");
                                Console.Write("Please enter an integer: ");
                            }
                        } while (age <= 0);


                        Console.WriteLine("What will you call it? ");
                        try
                        {
                            name = Console.ReadLine();
                        }
                        catch
                        {

                        }

                        // Create new cat passing values to its constructor, and add it to petList
                        pets.Add(cat = new Cat(name, age));

                        Console.WriteLine("Name: " + name + ", Age: " + age);
                    }
                }
                else
                {
                    try
                    {
                        // Get a random pet from petList and make it do something
                        if (thisPet.GetType() == typeof(Cat))
                        {
                            iCat = (ICat)thisPet;

                            // make the cat do something random
                            int nAction = rand.Next(0, 4);
                            switch (nAction)
                            {
                                case 0:
                                    iCat.Eat();
                                    break;
                                case 1:
                                    iCat.Scratch();
                                    break;
                                case 2:
                                    iCat.Play();
                                    break;
                                case 3:
                                    iCat.Purr();
                                    break;
                                case 4:
                                    iDog.GotoVet();
                                    break;
                            }
                        }
                        // Get a random pet from petList and make it do something
                        else if (thisPet.GetType() == typeof(Dog))
                        {
                            iDog = (IDog)thisPet;

                            // make the cat do something random
                            int nAction = rand.Next(0, 4);
                            switch (nAction)
                            {
                                case 0:
                                    iDog.Eat();
                                    break;
                                case 1:
                                    iDog.NeedWalk();
                                    break;
                                case 2:
                                    iCat.Play();
                                    break;
                                case 3:
                                    iDog.Bark();
                                    break;
                                case 4:
                                    iDog.GotoVet();
                                    break;
                            }
                        }
                    }
                    catch
                    {
                        goto start;
                    }
                }

                Console.WriteLine(i);
            }
        }
    }
}
