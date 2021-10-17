namespace FastFoodSimulator.Models
{
    public class Orders 
    {
        private int order;
        private int Id;
        public int CustomerId { get; set; }
        public Orders(int customerId)
        {
            Id = ++order;
            CustomerId = customerId;
        }
    }
}
