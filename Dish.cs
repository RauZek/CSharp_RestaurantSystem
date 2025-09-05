namespace Task01
{
    public abstract class Dish
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        protected Dish(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
