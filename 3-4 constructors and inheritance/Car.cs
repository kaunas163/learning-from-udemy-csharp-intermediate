using System;

namespace _3_4_constructors_and_inheritance
{
    public class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car is being initialized.");
        }

        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }
    }
}