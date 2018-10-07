using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock {
    class MainClass {

        static void Main(string[] args) {
            try {
                MyClock clock = new MyClock();
                MyAlarm alarm = new MyAlarm();
                DateTime systemTime = DateTime.Now;
                clock.AddAlarmTime(systemTime.Hour, systemTime.Minute, systemTime.Second, 5); ;
                clock.AlarmEvent += new MyClock.TimeDelegate(alarm.Alarming); //添加一个委托实例
                clock.run();
            } catch(Exception e) {
                Console.WriteLine(e.Message);
            } 
        }
    }
}
