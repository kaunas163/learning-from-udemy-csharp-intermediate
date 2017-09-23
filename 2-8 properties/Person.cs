using System;

namespace _2_8_properties
{
    public class Person
    {
        public DateTime Birthdate { get; } // auto implemented property, readonly
        public string Name { get; set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}