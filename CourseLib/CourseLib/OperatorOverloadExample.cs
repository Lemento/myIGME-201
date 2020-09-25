using System;
using System.Collections.Generic;
using PeopleLib;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create people SortedList<> class
            People people = new People();

            // 4 Person objects
            Student student1;
            Teacher teacher1;
            Student student2;
            Teacher teacher2;


            // create the 4 objects and set their
            // name, age, LicenseId, email, gpa and specialty

            student1 = new Student();
            student1.name = "John Smith";
            student1.age = 21;
            student1.gpa = 4;
            student1.LicenseId = 123;
            student1.email = "j@s.com";

            student2 = new Student();
            student2.name = "Mary Johnson";
            student2.age = 19;
            student2.gpa = 3.4;
            student2.LicenseId = 456;
            student2.email = "m@j.com";

            teacher1 = new Teacher();
            teacher1.name = "Joe Howard";
            teacher1.age = 45;
            teacher1.specialty = "Math";
            teacher1.LicenseId = 789;
            teacher1.email = "j@h.com";

            teacher2 = new Teacher();
            teacher2.name = "Scott Clinton";
            teacher2.age = 51;
            teacher2.specialty = "Psychology";
            teacher2.LicenseId = 987;
            teacher2.email = "s@c.com";

            // add the 4 objects to people
            // people[person.email] = person;
            people[student1.email] = student1;
            people[student2.email] = student2;
            people[teacher1.email] = teacher1;
            people[teacher2.email] = teacher2;

            // iterate through the people SortedList
            foreach (KeyValuePair<string,Person> keyValuePair in people.sortedList)
            {
                // keyValuePair contains Key and Value

                // if keyValuePair.Value is a Student
                if ( keyValuePair.Value.GetType() == typeof(Student))
                {
                    // declare a Student variable to point to keyValuePair.Value to have access to the Student fields
                    Student student = (Student)keyValuePair.Value;

                    // output Name, Age, Email, LicenseId, GPA
                    Console.WriteLine($"Name: {student.name} Age: {student.age} Email: {student.email} LicenseId: {student.LicenseId} GPA: {student.gpa}");
                }
                else
                {
                    // else a Teacher
                    // declare a Teacher variable to point to keyValuePair.Value to have access to the Teacher fields
                    Teacher teacher = (Teacher)keyValuePair.Value;

                    // output Name, Age, Email, LicenseId, Specialty
                    Console.WriteLine($"Name: {teacher.name} Age: {teacher.age} Email: {teacher.email} LicenseId: {teacher.LicenseId} Spec: {teacher.specialty}");
                }

                // call the Live() function for the current person to Eat(), Work() and Party()
                Live(keyValuePair.Value);

                Console.WriteLine("-------------------------------");
            }

            // using the Student operator overloads test if student1 > student2 and output who has the higher GPA
            if (student1 > student2)
            {
                Console.WriteLine($"{student1.name} has a higher GPA than {student2.name}");
            }
            else
            {
                Console.WriteLine($"{student2.name} has a higher GPA than {student1.name}");
            }

            // using the Person operator overloads test if student1 > teacher1 and output who is older
            // note that we have to cast the objects as (Person) for .NET to use the operator overloads associated with the Person class
            // because the operator function signature is expecting 2 Person parameters:
            //          public static bool operator >(Person p1, Person p2)
            if ((Person)student1 > (Person)teacher1)
            {
                Console.WriteLine($"{student1.name} is older than {teacher1.name}");
            }
            else
            {
                Console.WriteLine($"{teacher1.name} is older than {student1.name}");
            }
        }

        static void Live(object obj)
        {
            IStudent iStudent;
            IPerson iPerson;
            Person person;

            // use the Person parent class to call obj.Work()
            person = (Person)obj;
            person.Work();

            // use the IPerson interface to call obj.Eat()
            iPerson = (IPerson)obj;
            iPerson.Eat();

            // the object is a Student, use the IStudent interface to call obj.Party()
            if ( obj.GetType() == typeof(Student))
            {
                iStudent = (IStudent)obj;
                iStudent.Party();
            }
        }
    }
}
