using System;
namespace Intermediate
{
    class StopWatch
    {
            private DateTime startTime;
            private DateTime stopTime;
            bool stopWatchStarted =  false;

            public void Start()
            {
                if(!stopWatchStarted)
                {
                    startTime  = DateTime.Now;
                  
                    stopWatchStarted = true;
                }
                else
                {
                    System.Console.WriteLine("StopWach already Started");
                    
                }
            }

            public void Stop()
            {
                if(stopWatchStarted)
                {
                    stopTime  = DateTime.Now;
                   

                    stopWatchStarted = false;

                }
                 else
                {
                    System.Console.WriteLine("Start StopWach first");
                    
                }
            }

            public TimeSpan GetDuration()
            {
               return (stopTime - startTime);
            }
     }

}