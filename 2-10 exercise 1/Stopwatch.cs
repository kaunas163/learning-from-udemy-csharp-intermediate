using System;

namespace _2_10_exercise_1
{
    public class Stopwatch
    {
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public TimeSpan Duration { get; private set; }

        public void Start()
        {
            // TODO: don't let to start stopwatch if it's already started
            StartTime = DateTime.Now;
            Console.WriteLine("Stopwatch started: " + StartTime);
        }

        public void Stop()
        {
            EndTime = DateTime.Now;
            Console.WriteLine("Stopwatch stopped: " + EndTime);
            Duration = EndTime - StartTime;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Stopwatch duration: " + Duration);
        }
    }
}