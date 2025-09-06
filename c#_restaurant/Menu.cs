using System.IO.Compression;

namespace Task01;
    internal class Menu
    {
        private List<Dish> dishes = new List<Dish>();

        public void AddDish(Dish dish) => dishes.Add(dish);

        public void PrintMenu()
        {
            Console.WriteLine("Menu: ");
            foreach (var dish in dishes) Console.WriteLine($"{dish}");
        }

        public Dish GetDishByName(string name) =>
            dishes.FirstOrDefault(d => d.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
