using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace FastFoodSimulator.Models
{
    public class Cook 
    {
        private readonly List<Orders> toCook;
        private readonly List<Orders> cookedOrders;

        private Orders current;
        public int CookTime { get; set; }

        public Cook(List<Orders> ToCook, List<Orders> CookedOrders, int cookTime)
        {
            toCook = ToCook;
            cookedOrders = CookedOrders;
            CookTime = cookTime;
        }

        public Orders Current
        {
            get { return current; }
        }

        public void CookOrder()
        {
            toCook.IndexOf(current);
            Thread.Sleep((int)CookTime);
            toCook.Remove(current);
            cookedOrders.Add(current);
        }
    }
}
