using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
const string className = "Creature";
Action[] funcs = {
    () => Console.WriteLine(Reflector.AssemblyOf(className)) ,
    () => Console.WriteLine(Reflector.HasPublicCnstr(className)),
    () => Reflector.GetPublicMethods(className).ToList().ForEach(Console.WriteLine),
    () => Reflector.GetImplementedInterfaces(className).ToList().ForEach(Console.WriteLine),
    () => Reflector.GetMethodsWithType(className, TaskGInputData()).ToList().ForEach(Console.WriteLine),
    () => Reflector.Invoke(new Print(), "Print", "Number", 10)
};
foreach (var func in funcs)
{
    TryF(func);
    Console.WriteLine();
}

static void TryF(Action func)
{
    try
    {
        func();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
static string TaskGInputData()
{
    Console.Write("Enter a parameter type name\nE.g. System.Int32:\n> ");
    var res = Console.ReadLine();
    Console.WriteLine();
    return res;
}
static class Reflector
{
    static readonly System.IO.StreamWriter file = new("file.txt");
    static Type GetTypeByName(in string className)
    {
        try
        {
            return Type.GetType(className ?? string.Empty, false, true);
        }
        catch (ArgumentNullException)
        {
            throw new ArgumentException("No class found with the given name");
        }
    }
    public static Assembly AssemblyOf(in string className)
        => Assembly.GetAssembly(GetTypeByName(className));
    public static bool HasPublicCnstr(in string className)
    {
        var constructors = GetTypeByName(className)?.GetConstructors();
        foreach (var constructor in constructors)
            if (constructor.IsPublic)
                return true;
        return false;
    }
    public static IEnumerable<string> GetPublicMethods(string className)
    {
        var methodsInfo = GetTypeByName(className)?.GetMethods();
        foreach (var methodinfo in methodsInfo)
            yield return methodinfo.ToString();
    }
    public static IEnumerable<string> GetImplementedInterfaces(string className)
    {
        var interfaces = GetTypeByName(className)?.GetInterfaces();
        foreach (var interf in interfaces)
            yield return interf.FullName;
    }
    public static IEnumerable<string> GetMethodsWithType(string className, string searchTypeName)
    {
        var searchType = GetTypeByName(searchTypeName);
        var methods = GetTypeByName(className)?.GetMethods();
        foreach (var method in methods)
        {
            var parameters = method.GetParameters();
            foreach (var parameter in parameters)
                if (parameter.ParameterType == searchType)
                    yield return method.ToString();
        }
    }
    public static object Invoke(object obj, string className, string methodName, params object[] parameters)
        => GetTypeByName(className)?.GetMethods().Where(method => method.Name == methodName).First().Invoke(obj, parameters);
    /*public static IEnumerable<string> GetFieldsAndProps(string className)
    {
        var fields = GetTypeByName(className).getf
    }*/
}
abstract internal class Creature : IComparable
{
    delegate void DisplayMsg(string text);
    event DisplayMsg Notify = Console.WriteLine;
    public Creature(string name = "creature", int maxHp = 100, int hpLost = 0, int phDmg = 10, int mDmg = 10, int speed = 4)
    {
        Name = name;
        PhDmg = phDmg;
        MDmg = mDmg;
        MaxHp = maxHp;
        Hp = MaxHp - hpLost;
        Speed = speed;
    }
    public readonly string Name;
    int phDmg;
    public int PhDmg { get => phDmg; protected set => phDmg = value < 0 ? 0 : value; }
    int mDmg;
    public int MDmg { get => mDmg; protected set => mDmg = value < 0 ? 0 : value; }
    int maxhp;
    public int MaxHp { get => maxhp; protected set => maxhp = value <= 0 ? 1 : value; }
    public int hp;
    public virtual int Hp
    {
        get => hp;
        protected set
        {
            if (!IsAlive) return;
            hp = value < 0 ? 0 : value <= MaxHp ? value : MaxHp;
            if (hp <= 0)
                IsAlive = false;
        }
    }
    int speed;
    RPG.Items.Weapons.Weapon weapon;
    public RPG.Items.Weapons.Weapon Weapon
    {
        get => weapon;
        set
        {
            if (weapon != null)
                PhDmg -= Weapon.PhDmg;
            weapon = value;
            PhDmg += Weapon.PhDmg;
        }
    }
    public int Speed { get => speed; protected set => speed = value < 0 ? 0 : value; }
    public bool IsAlive { get; protected set; } = true;
    public virtual void RcvDmg(int value, Creature creature = null)
    {
        Hp -= value;
        Notify?.Invoke($"{Name} получил {value} урона{(creature is not null ? $" от {creature.Name}" : "")}");
    }
    public virtual void Hit(Creature creature)
    {
        if (creature.IsAlive)
            creature.RcvDmg(PhDmg, this);
        else
            Notify?.Invoke($"{Name} не может нанести урон - он мёртв");
    }
    public virtual void Heal(int value) => Hp += value;
    protected virtual string Info() => $"{Name}: { (!IsAlive ? "Dead" : $"Hp: {Hp}/{MaxHp}, PhDmg: {PhDmg}, MDmg: {MDmg}, Speed: {Speed}")}";
    public override string ToString() => $"Creature [{Info()}]";
    public int CompareTo(object obj) => Name.CompareTo((obj as Creature)?.Name);
}
class Print
{
    public static void Number(int a) => Console.WriteLine(a);
}
