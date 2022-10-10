using System;

namespace Stopwatch
{
        public class TimePassed
        {
            public static TimeSpan CalcTimePassed(DateTime startTime, DateTime stopTime)
            {
                var timePassed = stopTime - startTime;
                return timePassed;
            }
        }
    }