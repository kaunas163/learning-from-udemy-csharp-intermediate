using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_params
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 4, 5, 9, 7));
            Console.WriteLine(calculator.Add(3, 2));
            Console.WriteLine(calculator.Add(8, 4, 5, 6));
            Console.WriteLine(calculator.Add(new int[]{5, 8, 9}));
        }
    }
}
