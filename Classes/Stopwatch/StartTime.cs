using System;

namespace Stopwatch
{
    public class StartTime
    {
        public static DateTime SetStartTime()
        { 
            var startTime = DateTime.Now;
            return startTime;
        }
    }
}