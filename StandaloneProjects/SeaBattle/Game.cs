using System;
class Game
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
    public enum GameMode
    {
        PvPC,
        PvP,
        PCvPC
    }
    const byte fieldSize = 10;
    const sbyte awaitTime = 15; // 10 <=> 1.0s
    static readonly byte[] shipSizes = { 4, 3, 3, 2, 2, 2, 1, 1, 1, 1 };
    public static void FillField(out char[,] field, bool filledByPC)
    {
        void FillPCField(out char[,] field)
        {
            static void FillEmpty(char[,] field)
            {
                for (var i = 0; i < fieldSize; i++)
                    for (var j = 0; j < fieldSize; j++)
                        field[i, j] = '-';
            }
            void FillShips(char[,] field)
            {
                static void GenerateRandomData(out bool vertical, out int tempx, out int tempy)
                {
                    Random rand = new();
                    vertical = rand.Next(2) == 1;
                    tempx = rand.Next(fieldSize);
                    tempy = rand.Next(fieldSize);
                }
                void FindPlace(in int tempx, in int tempy, ref bool vertical, out bool shipPlaceFound, int shipNum, char[,] field)
                {
                    void PlaceVertical(in int tempx, in int tempy, ref bool shipPlaceFound, char[,] field)
                    {
                        for (int j = 0; j < shipSizes[shipNum]; j++)
                        {
                            if (tempy + j >= fieldSize || field[tempx, tempy + j] != '-')
                                break;
                            else
                            if (j == shipSizes[shipNum] - 1)
                                shipPlaceFound = true;
                        }
                    }
                    void PlaceHorizontal(in int tempx, in int tempy, ref bool shipPlaceFound, ref bool vertical, char[,] field)
                    {
                        for (int j = 0; j < shipSizes[shipNum]; j++)
                            if (tempx + j >= fieldSize || field[tempx + j, tempy] != '-')
                                break;
                            else
                            if (j == shipSizes[shipNum] - 1)
                            {
                                shipPlaceFound = true;
                                vertical = false;
                            }
                    }
                    shipPlaceFound = false;
                    if (field[tempx, tempy] == '-')
                        if (vertical)
                            PlaceVertical(tempx, tempy, ref shipPlaceFound, field);
                        else if (!shipPlaceFound)
                            PlaceHorizontal(tempx, tempy, ref shipPlaceFound, ref vertical, field);
                }
                void PlaceShip(ref int shipNum, in bool vertical, in int tempx, in int tempy)
                {
                    for (int j = 0; j < shipSizes[shipNum]; j++)
                    {
                        Point temp;
                        if (vertical)
                            temp = new(tempx, tempy + j);
                        else
                            temp = new(tempx + j, tempy);
                        field[temp.X, temp.Y] = '@';
                        // Первый способ
                        for (int x = -1; x < 2; x++)
                            for (int y = -1; y < 2; y++)
                            {
                                Point point = new(temp.X + x, temp.Y + y);
                                if (point.Y < fieldSize && point.X < fieldSize && point.X >= 0 && point.Y >= 0 && field[point.X, point.Y] != '@')
                                    field[point.X, point.Y] = '=';
                            }
                    }
                    shipNum++;
                }
                void GetRidOfSupSymbs()
                {
                    for (int i = 0; i < fieldSize; i++)
                        for (int j = 0; j < fieldSize; j++)
                            if (field[i, j] == '=')
                                field[i, j] = '-';
                }
                for (int shipNum = 0; shipNum < shipSizes.Length;)
                {
                    GenerateRandomData(out bool vertical, out int tempx, out int tempy);
                    FindPlace(tempx, tempy, ref vertical, out bool shipPlaceFound, shipNum, field);
                    if (shipPlaceFound)
                        PlaceShip(ref shipNum, vertical, tempx, tempy);
                }
                GetRidOfSupSymbs();
            }
            field = new char[fieldSize, fieldSize];
            FillEmpty(field);
            FillShips(field);

        }
        static void FillPlayerField(out char[,] field)
        {
            field = new char[fieldSize, fieldSize];
        }
        if (filledByPC)
            FillPCField(out field);
        else
            FillPlayerField(out field);
    }
    public static void Start(in char[,] field1, in char[,] field2, GameMode gm)
    {
        static char[,] CreateMirror(in char[,] srcField)
        {
            var resField = new char[fieldSize, fieldSize];
            for (int i = 0; i < fieldSize; i++)
                for (int j = 0; j < fieldSize; j++)
                    resField[i, j] = srcField[i, j] == '@' ? '-' : srcField[i, j];
            return resField;
        }
        static bool MakeTurn(out int x, out int y)
        {
            Console.WriteLine("Ваш ход: Введите координаты для атаки: x y");
            var s = Console.ReadLine().Split(' ');
            x = Int32.Parse(s[0]);
            y = Int32.Parse(s[1]);
            if (x > 0 && x <= fieldSize && y > 0 && y <= fieldSize)
            {
                x--;
                y--;
                return false;
            }
            return true;
        }
        static void Shoot(in int x, in int y, char[,] srcField, char[,] mirrorField)
        {
            void HaveLost(in char[,] field)
            {
                for (int i = 0; i < fieldSize; i++)
                    for (int j = 0; j < fieldSize; j++)
                        if (field[i, j] == '@')
                            return;
                Console.WriteLine("Победа!");
                Environment.Exit(0);
            }
            srcField[x, y] = srcField[x, y] == '@' || srcField[x, y] == 'X' ? 'X' : 'о';
            mirrorField[x, y] = srcField[x, y];
            HaveLost(srcField);
        }
        static void Pause()
        {
            for (double i = awaitTime; i >= 0; i-=2.5)
            {
                System.Threading.Thread.Sleep(100);
                Console.WriteLine($"{Math.Round(i/10, 2)}...");
            }
        }
        static void PvP(char[,] field1, char[,] field2) {
            char[,] field1_For2 = CreateMirror(field1),
                field2_For1 = CreateMirror(field2);
            while (true)
            {
                int x, y;
                do
                {
                    Console.Clear();
                    field1_For2.Outp();
                    Console.WriteLine();
                    field2.Outp();
                    while (MakeTurn(out x, out y)) ;
                    Shoot(x, y, field1, field1_For2);
                    Pause();
                    Console.Clear();
                    field2_For1.Outp();
                    Console.WriteLine();
                    field1.Outp();
                    while (MakeTurn(out x, out y)) ;
                    Shoot(x, y, field2, field2_For1);
                    Pause();
                } while (true);
            }
        }
        switch (gm)
        {
            case GameMode.PvP:
                PvP(field1, field2);
                break;
           /* case GameMode.PvPC:
                PvPC();
                break;
            default:
                PCvPC();*/
        }
        
    }
}