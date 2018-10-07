using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {

    class OrderDetails {

        private uint orderDetailsId;

        private Goods goods;

        private uint quantity;

        public OrderDetails(uint orderDetailsId, Goods goods, uint quantity) {
            OrderDetailsId = orderDetailsId;
            Goods = goods;
            Quantity = quantity;
        }

        public uint OrderDetailsId  {
            get { return orderDetailsId; } 
            set { orderDetailsId = value; }
        }

        public Goods Goods {
            get { return goods; }
            set { goods = value; }
        }

        public uint Quantity {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Info {
            get {
                string result = "";
                result += $"orderDetailsId:{orderDetailsId}:  ";
                result += goods.Info + $", quantity:{quantity}"; 
                return result;
            }
        }
    }
}
