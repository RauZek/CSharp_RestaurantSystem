namespace Task01;
    class Restaurant
    {
        public string Name { get; }

        public Menu menu { get; } = new Menu();

        private List<Waiter> waiters = new List<Waiter>();

        private List<Order> orders = new List<Order>();

        public Restaurant(string name) { Name = name; }

        public void AddWaiter(Waiter waiter) => waiters.Add(waiter);

        public void AddOrder(Order order) => orders.Add(order);
    }
