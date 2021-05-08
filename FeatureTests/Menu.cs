using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
class Menu
{
    static void startMenu()
    {
        CreateMenu(out IEnumerable<Action> methods, out string menutext);
        PrintMenu();
        void PrintMenu()
        {
            Console.WriteLine(menutext);
            var choise = (int)Console.ReadKey().Key - (int)ConsoleKey.D0;
            if (choise < 1 || choise > methods.Count())
                Environment.Exit(0);
            Console.Clear();
            methods.ElementAt(choise - 1)();
            PrintMenu();
        }
        static void CreateMenu(out IEnumerable<Action> methods, out string menutext)
        {
            methods = typeof(Task)
                .GetMethods()
                .Where(m => !IsBaseMethod(m.Name))
                .Select(method => 
                    (Action)method.CreateDelegate(typeof(Action))
                )
                .ToList();
            menutext = "Choose an Action:\n";
            for (int i = 0; i < methods.Count(); i++)
                menutext += $"{i + 1} - {methods.ElementAt(i).GetMethodInfo().Name}\n";
            static bool IsBaseMethod(string name)
            {
                string[] baseMethods = { "Equals", "GetType", "GetHashCode", "ToString" };
                foreach (var baseMethod in baseMethods)
                    if (name == baseMethod)
                        return true;
                return false;
            }
        }
    }
}