using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock {

    // the time obj
    class MyTime {

        private int hour;

        private int minute;

        private int second;

        private int id;

        public MyTime(int hour = 0, int minute = 0, int second = 0) {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public int Hour {
            get { return hour; }
            set {
                if(value >= 0 && value < 24) {
                    hour = value;
                } else {
                    throw new ArgumentOutOfRangeException("hour invalid!");
                }
            }
        }

        public int Minute {
            get { return minute; }
            set {
                if (value >= 0 && value < 60) {
                    minute = value;
                } else {
                    throw new ArgumentOutOfRangeException("minute invalid!");
                }
            }
        }

        public int Second {
            get { return second; }
            set {
                if (value >= 0 && value < 60) {
                    second = value;
                } else {
                    throw new ArgumentOutOfRangeException("second invalid!");
                }
            }
        }

        public int Id {
            get { return hour * 10000 + minute * 100 + second; }
        }
    }
}
