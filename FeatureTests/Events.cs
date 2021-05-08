using System;
class StockExample
{
    static void StockMain()
    {
        Stock stock = new("Kit-Kat");
        stock.Price = 0.56M;
        // Зарегистрировать с событием PriceChanged
        stock.PriceChanged += PriceChangedConsoleNotification;
        stock.PriceChanged += PriceChangedFileNotification;
        stock.Price = 0.45M;
        stock.Price = 0.79M;
    }
    static void PriceChangedConsoleNotification(object sender, PriceChangedEventArgs e)
        => Console.WriteLine("Цена {0}, {1} на {2}({3}%)",
            (sender as Stock)?.Symbol,
        (e.NewPrice > e.LastPrice ? "увеличилась" : "уменьшилась"),
        Math.Abs(e.NewPrice - e.LastPrice),
        Math.Round(Math.Abs(e.NewPrice - e.LastPrice) / e.LastPrice * 100, 2));
    static void PriceChangedFileNotification(object sender, PriceChangedEventArgs e)
    {
        // var a = System.IO.File.OpenWrite("file.txt");
        Console.WriteLine("// Выведено в файл");
    }
    class PriceChangedEventArgs : EventArgs
    {
        public decimal LastPrice { get; set; }
        public decimal NewPrice { get; set; }
    }
    class Stock
    {
        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
          => PriceChanged?.Invoke(this, e);
        public string Symbol { get; set; }
        decimal price;
        public decimal Price
        {
            get => price;
            set
            {
                if (price == value) return;
                var oldPrice = price;
                price = value;
                OnPriceChanged(new() { LastPrice = oldPrice, NewPrice = price });
            }
        }
        public Stock(string symbol) => Symbol = symbol;
        public event EventHandler<PriceChangedEventArgs> PriceChanged;
    }
}
class ArkanoidExample
{
    class Program
    {
        static void ArkanoidMain()
        {
            StartGame += Platform.OnStart;
            StartGame += Ball.OnStart;
            StartGame += Blocks.OnStart;
            StartGame();
        }
        static event Action StartGame;
    }
    class Platform
    {
        public static void OnStart() => Console.WriteLine("The platorm started moving...");
    }
    class Ball
    {
        public static void OnStart() => Console.WriteLine("The ball startsed moving...");
    }
    class Blocks
    {
        public static void OnStart() => Console.WriteLine("The blocks are spawning...");
    }
}

class WorkersExample
{
    class Program
    {
        static void WorkersMain()
        {
            Employee e = new(20);
            Trainee t = new(10);
            Director dir = new();
            dir.Raise += e.OnRaise;
            dir.Raise += t.OnRaise;
            dir.MakeRaise(3);
            Console.WriteLine($"e.salary - {e.salary}, t.salary - {t.salary}");
        }
    }

    class Employee
    {
        public int salary;
        public Employee(ushort salary) => this.salary = salary;
        public void OnRaise(ushort value) => salary += value;
    }

    class Trainee : Employee
    {
        public Trainee(ushort salary) : base(salary) { }
    }
    class Director
    {
        public void MakeRaise(ushort value) => Raise(value);
        public event Action<ushort> Raise;
        public event Action<ushort> Fine; // Штраф
    }
}
