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
        public int Time { 
            get;
            set;
        }
        public Orders Current
        {
            get { return current; }
            set
            {
                current = value;
            }
        }
        public OrderTaker(List<Orders> toCook, int time)
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
