namespace Task01;
    internal class Program
    {
        static void Main()
        {
            Restorant restaurant = new Restorant("Raul's Place");
            Console.WriteLine($"Created a resturant with the name: {restaurant}");

            restaurant.menu.AddDish(new MainCourse("Steak", 12.50m));
            restaurant.menu.AddDish(new Dessert("Icecream", 5.99m));
            restaurant.menu.AddDish(new Drink("Coca-Cola", 4.99m));

            restaurant.menu.PrintMenu();

            Waiter Raul = new Waiter("Raul", restaurant);
            restaurant.AddWaiter(Raul);

            Order customerOrder1 = Raul.TakeOrder();

            Raul.ServeOrder(customerOrder1);
        }
    }
