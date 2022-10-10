using System;

namespace Stopwatch
{

    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 'Start' to start the stopwatch, or 'Exit' to exit the program.");
            var input = Console.ReadLine();

            if (input.ToLower() == "start")
            {
                var startTime = StartTime.SetStartTime();
                //Console.WriteLine(startTime);

                Console.WriteLine("Type 'Stop' to stop the stopwatch, or 'Exit' to exit the program.");
                var input2 = Console.ReadLine();

                if (input2.ToLower() == "stop")
                {
                    var stopTime = StopTime.SetStopTime();
                    //Console.WriteLine(stopTime);

                    //Also calculate the time passed between start and stop
                    var timePassed = TimePassed.CalcTimePassed(startTime, stopTime);
                    Console.WriteLine("Stopwatch stopped at " + timePassed.Hours + " hours, "  + timePassed.Minutes + " minutes and " + timePassed.Seconds + " seconds");
                }

                else if (input2.ToLower() == "exit")
                {
                    Console.WriteLine("Have a nice day");
                    //Maybe Make new "ExitProgram" Method?
                }
            }

            else if (input.ToLower() == "exit")
            {
                Console.WriteLine("Have a nice day");
                //Maybe Make new "ExitProgram" Method?
            }

        }
    }
}