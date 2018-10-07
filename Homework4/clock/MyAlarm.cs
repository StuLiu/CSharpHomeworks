using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock {
    /// <summary>
    /// event subscriber
    /// </summary> 
    class MyAlarm {

        /// <summary>
        /// response function
        /// </summary>
        /// <param name="time">time when the Alarming call</param>
        /// <param name="seconds">how many seconds the alarming continues</param>
        public void Alarming(MyTime time,int seconds)  {
            Console.WriteLine($"Alarm time -- {time.Hour}:{time.Minute}:{time.Second}");
            Console.WriteLine($"Contiue {seconds} seconds");
            while (seconds-- > 0) {
                Console.WriteLine("dingling dingling dingling dingling dingling\a");
                Thread.Sleep(1000);
            }
        }
    }
}
