using System;
class AlgSpeed
{
    public static void AlgorithmSpeed()
    {
        var sw = new System.Diagnostics.Stopwatch();
        var n = 1000;
        var arr = new double[n][];
        sw.Start();
        for (var i = 0; i < n; i++)
        {
            arr[i] = new double[n];
            for (var j = 0; j < n; j++)
                arr[i][j] = Math.Sin(i * n + j);
        }
        for (var i = 0; i < n; i++)
            for (var j = 0; j < n; j++)
                arr[i][j] = Math.Cos(j * n + i);
        Console.WriteLine(sw.ElapsedMilliseconds / 1000.0);
    }
    static void Prime()
    {
        System.Diagnostics.Stopwatch sw = new();
        sw.Start();
        for (int i = 3; i < 100000; i += 2)
            isPrimeOptimal(i);
        Console.WriteLine(sw.ElapsedMilliseconds / 1000.0);
        sw.Restart();
        for (int i = 0; i < 100000; i++)
            isPrime(i);
        Console.WriteLine(sw.ElapsedMilliseconds / 1000.0);
        static bool isPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        static bool isPrimeOptimal(int num)
        {
            var n = System.Math.Sqrt(num);
            for (int i = 3; i <= n; i += 2)
                if (num % i == 0)
                    return false;
            return true;
        }
    }
}