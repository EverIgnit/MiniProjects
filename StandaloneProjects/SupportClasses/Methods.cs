using System;
namespace SupportClasses
{
    public static class Methods
    {
        public static int Rand() => new Random().Next(2, 10);
        public static int Inp()
        {
            Console.Write("Введите число:\n> ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static void Create(out int[] arr)
        {
            Console.WriteLine("Для автоматического заполнения нажмите Enter...");
            var key = Console.ReadKey().Key;
            Console.Clear();
            if (key == ConsoleKey.Enter)
                RandCreate(out arr); 
            else
                HandCreate(out arr);
        }
        public static void RandCreate(out int[] arr)
        {
            arr = new int[Rand()];
            arr.RandFill();
        }
        public static void HandCreate(out int[] arr)
        {
            Console.WriteLine("Размер массива");
            arr = new int[Inp()];
            arr.Inp();
        }
        public static void Create(out int[][] arr)
        {
            Console.WriteLine("Для заполнения автоматически: Enter");
            if (Console.ReadLine() == string.Empty)
            {
                Console.Clear();
                RandCreate(out arr);
            }
            else
            {
                Console.Clear();
                HandCreate(out arr);
            }
        }
        public static void RandCreate(out int[][] arr)
        {
            arr = new int[Rand()][];
            arr.RandInit(Rand());
            arr.RandFill();
        }
        public static void RandCreate(out int[,] arr)
        {
            arr = new int[Rand(), Rand()];
            arr.RandFill();
        }
        public static void Swap(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                throw new ArgumentException("Array sizes are not equal");
            for (int i = 0; i < arr1.Length; i++)
                arr1[i].Swap(ref arr2[i]);
        }
        public static void HandCreate(out int[][] arr)
        {
            Console.WriteLine("Введите количество строк:");
            arr = new int[Inp()][];
            Console.WriteLine("Введите количество элементов в каждой строке:");
            arr.Init(Inp());
            arr.Inp();
        }
    }
}