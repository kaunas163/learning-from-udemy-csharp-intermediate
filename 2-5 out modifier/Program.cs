using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_out_modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = int.Parse("abc"); // will crash

            // parse

            try
            {
                var number1 = int.Parse("abc");
                Console.WriteLine(number1);
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed");
            }

            // tryparse

            int number2;
            var result = int.TryParse("abc", out number2);
            if (result)
            {
                Console.WriteLine(number2);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }
        }
    }
}
