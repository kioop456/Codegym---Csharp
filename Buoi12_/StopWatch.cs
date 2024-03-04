using System;

namespace Buoi12_
{
    internal partial class Program
    {
        public class StopWatch
        {
            private double startTime;
            private double endTime;

            public double StartTime => startTime;
            public double EndTime => endTime;

            public StopWatch()
            {
                startTime = DateTime.Now;
            }
            public void Start()
            {
                startTime = DateTime.Now;
            }
            public void Stop()
            {
                endTime = DateTime.Now;
            }
            public double GetElapsedTime()
            {
                return startTime.Millisecond - endTime.Millisecond;
            }
        }
    }
}
