using System;

namespace StopWatchClass
{
    public class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;
        private bool running;

        public DateTime StartTime
        {
            get { return startTime; }
        }

        public DateTime EndTime
        {
            get { return endTime; }
        }

        public StopWatch()
        {
            running = false;
        }

        public void Start()
        {
            startTime = DateTime.Now;
            running = true;
        }

        public void Stop()
        {
            endTime = DateTime.Now;
            running = false;
        }

        public TimeSpan GetElapsedTime()
        {
            if (running)
            {
                throw new InvalidOperationException("StopWatch is still running. Stop it first.");
            }

            return endTime - startTime;
        }
    }

}
