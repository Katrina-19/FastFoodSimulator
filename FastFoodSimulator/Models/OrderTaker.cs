using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace FastFoodSimulator.Models
{
    public class OrderTaker 
    {
        private List<Orders> orders;
        private Orders current;
        public int _time;
        public int Time { get { return Time; }
            set { _time = value; }
        }
        public Orders Current
        {
            get { return current; }
            set
            {
                current = value;
            }
        }
        public OrderTaker(List<Orders> toCook, int time=300)
        {
            orders =toCook;
            Time = time;
        }

        public void Receive(Customer customer)
        {
            Current = customer.Order();
            Thread.Sleep((int)Time);
            Put();
        }

        private void Put()
        {
            orders.Add(Current);
        }

    }
}
