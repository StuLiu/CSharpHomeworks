using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock {

    // event publisher
    class MyClock {

        // current time
        private MyTime currentTime;

        // Keys are Id of the time when clock begins alarming
        // Values are the alarm time continues
        private Dictionary<int, int> times;

        public delegate void TimeDelegate(MyTime time, int seconds);
        public event TimeDelegate AlarmEvent;

        public MyClock() {
            currentTime = new MyTime();
            times = new Dictionary<int, int>();
        }

        public MyTime CurrentTime {
            get { return currentTime; }
        }

        // add alarm time into clock
        public void AddAlarmTime(int hour, int minute, int second, int secContinue = 60) {
            times[new MyTime(hour, minute, second).Id] = secContinue;
        }

        // remove alarm time from clock
        public void RemoveAlarmTime(int hour, int minute, int second) {
            MyTime time = new MyTime(hour, minute, second);
            if (times.ContainsKey(time.Id))
                times.Remove(time.Id);
        }

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
