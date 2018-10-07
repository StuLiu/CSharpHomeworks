using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock {

    /// <summary>
    /// event publisher:Clock class
    /// </summary> 
    class MyClock {

        
        private MyTime currentTime;

        // Keys are Id of the time when clock begins alarming
        // Values are the alarm time continuing
        private Dictionary<int, int> times;

        /// <summary>
        /// delegate for time operation
        /// </summary>
        /// <param name="time"></param>
        /// <param name="seconds"></param>
        public delegate void TimeDelegate(MyTime time, int seconds);

        /// <summary>
        /// alarm event
        /// </summary>
        public event TimeDelegate AlarmEvent;

        /// <summary>
        /// constuctor
        /// </summary>
        public MyClock() {
            currentTime = new MyTime();
            times = new Dictionary<int, int>();
        }

        /// <summary>
        /// current time
        /// </summary>
        public MyTime CurrentTime {
            get { return currentTime; }
        }

        /// <summary>
        /// add alarm time into clock
        /// </summary>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        /// <param name="second"></param>
        /// <param name="secContinue"></param> 
        public void AddAlarmTime(int hour, int minute, int second, int secContinue = 60) {
            times[new MyTime(hour, minute, second).Id] = secContinue;
        }

        /// /// <summary>
        /// remove alarm time from clock 
        /// </summary>
        public void RemoveAlarmTime(int hour, int minute, int second) {
            MyTime time = new MyTime(hour, minute, second);
            if (times.ContainsKey(time.Id))
                times.Remove(time.Id);
        }

        /// <summary>
        /// clock is running after call this function
        /// </summary>
        public void run() {
            while (true) {
                DateTime systemTime = DateTime.Now;
                currentTime.Hour = systemTime.Hour;
                currentTime.Minute = systemTime.Minute;
                currentTime.Second = systemTime.Second;
                if (times.ContainsKey(currentTime.Id))
                    AlarmEvent(currentTime, times[currentTime.Id]);
                Thread.Sleep(1000);
            }
        }
    }
}
