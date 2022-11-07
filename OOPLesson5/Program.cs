using OOPLesson5;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students("yarin", 30);
           // students.Print();//30 ,yarin

            Truck truck = new Truck(1,"sdf","sdfsdfsd");
            Console.WriteLine(truck.Get());

            Ship ship = new Ship(1,"red");
            Console.WriteLine(ship.Get());

        }
        internal class Students : Person
        {
            public Students(string firstName, int age)
             :base(firstName)
            {
                Age = age;
            }
            public int Age { get; set; }
            public new void Print()
            {
                base.Print();
                Console.WriteLine(Age);
            }

        }

        internal class Person
        {
            public Person(string firstName)
            {
                FirstName = firstName;
            }

            public string FirstName { get; set; }

            public void Print()
            {
                Console.WriteLine(FirstName);
            }


        }

    }
}