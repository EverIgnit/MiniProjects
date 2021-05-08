using SupportClasses;
using static System.Console;
public static class Ext
{
    public static string GenerateName(this string s)
    {
        System.Random rand = new();
        var am = rand.Next(3, 10);
        s += (char)rand.Next('A', 'Z' + 1);
        for (int i = 0; i < am; i++)
            s += (char)rand.Next('a', 'z' + 1);
        return s;
    }
    public static string Reverse(this string s)
    {
        var res = string.Empty;
        for (int i = s.Length; i >= 0; i--)
            res += s[i];
        return res;
    }
    public static void Swap(this ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    public static void Inp(this int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i] = Methods.Inp();
    }
    public static void Inp(this int[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            WriteLine($"Введите элементы подмассива {i + 1}:\n> ");
            Inp(arr[i]);
        }
    }
    public static void Outp(this in int el) => Write(el);
    public static void Outp<T>(this T[] arr)
    {
        foreach (var el in arr)
            Write($"{el} ");
        WriteLine();
    }
    public static void Outp<T>(this T[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
                Write(arr[i, j] + " ");
            WriteLine();
        }
    }
    public static void Outp<T>(this T[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i].Outp();
        WriteLine();
    }
    public static void RandFill(this int[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i].RandFill();
    }
    public static void RandFill(this int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
                arr[i, j] = new System.Random().Next(-50, 50);
    }
    public static void RandFill(this int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i] = Methods.Rand();
    }
    public static void Init(this int[][] arr, int n)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i] = new int[n];
    }
    public static void MoveRight(this int[] arr)
    {
        for (int i = arr.Length - 1; i > 0; i--)
            arr[i].Swap(ref arr[i - 1]);
    }
    public static void MoveRight(this int[] arr, int ElAm)
    {
        for (int i = 0; i < arr.Length - ElAm * 2; i += ElAm)
            for (int j = i; j < i + ElAm; j++)
                arr[j].Swap(ref arr[j + ElAm]);
    }
    public static void MoveDown(this int[][] arr)
    {
        for (int i = arr.Length - 1; i >0; i--)
            Methods.Swap(arr[i], arr[i - 1]);
    }
    public static void BubbleSort(this int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
            for (int j = i + 1; j < arr.Length; j++)
                if (arr[i] > arr[j])
                    arr[i].Swap(ref arr[j]);
    }
    public static void RandInit(this int[][] arr, int n)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i] = new int[n];
    }
}