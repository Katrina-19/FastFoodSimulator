using System;

namespace FastFoodSimulator.Models
{
    public class Customer
    {
        private int customer;
        private int Id;

        public Customer()
        {
            Id = ++customer;
        }
        public Orders Order()
        {
            Orders orderId = new Orders(Id);
            return orderId;
        }
    }
}
