using System;
class Program
{
    delegate void Option();
    static void MainMeth()
    {
        Option[] options = { AddCompany, AddEmployee };
        for (var i = 0; i < options.Length; i++)
            Console.WriteLine($"{i + 1}: {options[i].Method.Name}");
        options[(int)Console.ReadKey().Key - (int)ConsoleKey.D1]();
    }
    static void AddCompany() => Console.WriteLine("AddC");
    static void AddEmployee() => Console.WriteLine("AddE");
}