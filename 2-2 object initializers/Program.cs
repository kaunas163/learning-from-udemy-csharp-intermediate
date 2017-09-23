using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_object_initializers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Mosh",
                LastName = "Hamedani"
            };

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }
    }
}
