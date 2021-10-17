using System.Collections.Generic;
using System.Threading;

namespace FastFoodSimulator.Models
{
    public class Server
    {
        private readonly List<Orders> ready;

        public Server(List<Orders> Ready)
        {
            ready = Ready;
        }

        public void DeliverOrder(Orders order)
        {
            Thread.Sleep(600);
            ready.Add(order);
        }
    }
}
