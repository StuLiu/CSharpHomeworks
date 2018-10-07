using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {

    class Goods {

        private uint goodsId;

        private string goodsName;

        private double goodsValue;

        public Goods(uint id, string name, double value) {
            Id = id;
            Name = name;
            Value = value;
        }

        public uint Id {
            get { return goodsId; }
            set { goodsId = value; }
        }

        public string Name {
            get { return goodsName; }
            set { goodsName = value; }
        }

        public double Value {
            get { return goodsValue; }
            set {
                if (value >= 0)
                    goodsValue = value;
                else
                    throw new ArgumentOutOfRangeException("value must >= 0!");
            }
        }

        public string Info {
            get { return $"goodsId:{goodsId}, goodsName:{goodsName}, goodsValue:{goodsValue}"; }
        }
    }
}
