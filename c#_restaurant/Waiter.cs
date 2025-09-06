using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Waiter : Restorant
    {
        public string Name { get; }
        public Restorant Restorant;

        public Waiter(string name, Restorant resturant)
        {
            Name = name;
            this.Restorant = resturant;
        }

        public Order TakeOrder(List<Dish> orderedDishes)
        {
            Order order = new Order();
            foreach (var name in orderedDishes)
            {
                var dish = restaurant.Menu.GetDishByName(name);

                if (dish != null) order.AddDish(dish);
                else Console.WriteLine($"Dish '{name}' not found in menu.");
            }
            restaurant.AddOrder(order);
            return order;
        }

        public void ServeOrder(Order order) => order.Serving();
    }
}
