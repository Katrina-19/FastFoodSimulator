using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using FastFoodSimulator.Models;
using System.Windows.Forms;

namespace FastFoodSimulator.Business
{
    public class Simulator
    {
        private readonly List<Customer> listToOrderTaker;

        private readonly List<Customer> listToServer;

        private readonly List<Orders> toCook;

        private readonly List<Orders> cookreadyOrders;

        private readonly List<Orders> serverReadyOrders;

        private readonly OrderTaker orderTaker;

        private readonly Cook cook;

        private readonly Server server;

        public int ArrivalTime;

        public int CookTime;
        private Form1 form = new Form1();

        public Simulator(int cookTime, int orderTakerOrderingTime, int customerArrivalTime)
        {
            List<Customer> listToOrderTaker = new List<Customer>();
            List<Customer> listToServer = new List<Customer>();
            List<Orders> toCook = new List<Orders>();
            List<Orders> cookreadyOrders = new List<Orders>();
            List<Orders> serverReadyOrders = new List<Orders>();

            OrderTaker orderTaker = new OrderTaker(toCook, orderTakerOrderingTime);
            Cook cook = new Cook(toCook, cookreadyOrders, cookTime);
            Server server = new Server(serverReadyOrders);

            CookTime = cookTime;
            ArrivalTime = customerArrivalTime;
            OrderTakerOrderingTime = orderTakerOrderingTime;
        }

        public int CustomerArrivalTime
        {
            get
            {
                return ArrivalTime;
            }
            set
            {
                ArrivalTime = value;
            }
        }

        public int CookTime0
        {
            get { return CookTime; }
            set
            {
                CookTime = value;
            }
        }

        public int OrderTakerOrderingTime
        {
            get { return orderTaker.Time; }
            set
            {
                orderTaker.Time = value;
            }
        }

        public bool IsSimulatorWorking { get; set; } = true;

       /* public int NumberOfCustomersWaitingToPlaceOrder => listToOrderTaker.Count;

        public string CurrentOrder => cook.Current == null ? "null" : cook.Current.CustomerId.ToString();

        public int CountOfWaitingOrders => toCook.Count;

        public int ContOfCurrentlyAvailableOrders => serverReadyOrders.Count;

        public int CountOfWaitingCustomers => listToServer.Count;*/

        public string OrdersReadyToCook
        {
            get
            {
                string answer = "";
                foreach (var order in toCook)
                {
                    answer += order.CustomerId + " ";
                }

                return answer;
            }
        }

        public string CurrentOrderTakerOrder =>
            orderTaker.Current == null ? "null" : orderTaker.Current.CustomerId.ToString();

        public void StartFastFoodSimulator()
        {
            IsSimulatorWorking = true;
            Task.Run(GenerateCustomers);
            Task.Run(OrderTakerWork);
            Task.Run(CookWork);
            Task.Run(ServerWork);
            Task.Run(QueueToServerWork);
        }

        private void GenerateCustomers()
        {
            while (IsSimulatorWorking)
            {
                Thread.Sleep((int)CustomerArrivalTime);
                listToOrderTaker.Add(new Customer());
                form.buyerId.Text = listToOrderTaker.Last().ToString();
            }
        }

        private void OrderTakerWork()
        {
            while (IsSimulatorWorking)
            {
                if (listToOrderTaker.Count > 0 )
                {
                    orderTaker.Receive(listToOrderTaker.First());

                    listToServer.Add(listToOrderTaker.First());
                    form.orderId.Text = listToServer.First().ToString();
                }
            }
        }

        private void CookWork()
        {
            while (IsSimulatorWorking)
            {
                if (toCook.Count > 0)
                {
                    cook.CookOrder();
                }
                form.cookedId.Text = toCook.First().ToString();
            }
        }

        private void ServerWork()
        {
            while (IsSimulatorWorking)
            {
                if (serverReadyOrders.Count > 0)
                {
                    server.DeliverOrder(serverReadyOrders.First());
                }
                form.cookedId.Text = cookreadyOrders.First().ToString();
            }
        }

        private void QueueToServerWork()
        {
            while (IsSimulatorWorking)
            {
                if (listToServer.Count > 0 && serverReadyOrders.Count > 0)
                {
                    Thread.Sleep(600);
                    serverReadyOrders.Remove(serverReadyOrders.First());
                    listToServer.Remove(listToServer.First());
                    form.readyId.Text = serverReadyOrders.First().ToString();
                }
            }
        }
    }
}
