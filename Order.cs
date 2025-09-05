using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public enum OrderStatus
    {
        Pending,
        Served,
        Cancelled
    }

    class Order
    {
        private List<Dish> orderedDishes = new List<Dish>();
        public OrderStatus Status { get; private set; } = OrderStatus.Pending;

        public void AddDish(Dish dish) => orderedDishes.Add(dish);

        public decimal CalculateTotal() => orderedDishes.Sum(d => d.Price);

        public void Serving()
        {
            Status = OrderStatus.Served;
            Console.WriteLine("Order has been successfully served.");
            Console.WriteLine($"Total amount: {CalculateTotal():F2}");
        }

        public void Cancel() => Status = OrderStatus.Cancelled;
    }
}
