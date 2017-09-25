using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_10_exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            Console.WriteLine("Write 'start' when you want to start the stopwatch");
            Console.WriteLine("And write 'stop' when you want to stop the stopwatch");
            string input;
            do
            {
                // TODO: let it run multiple times, but better than this

                input = Console.ReadLine();
                if (input == "start")
                {
                    stopwatch.Start();
                }
                input = Console.ReadLine();
                if (input == "stop")
                {
                    stopwatch.Stop();
                }
                Console.WriteLine("Again? (y/n)");
                input = Console.ReadLine();
            } while (input == "y");
        }
    }
}
