using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
class Collections
{
    static void CollMain()
    {
        List<User> users = new();
        for (int i = 0; i < 10; i++)
            users.Add(new());
        users.ForEach(el => Console.WriteLine($"({el.Id}) {el.Name} "));
        Console.WriteLine("=-=-=-=");
        List<Mark> marks = new();
        for (int i = 0; i < users.Count; i++)
            marks.Add(new());
        marks.ForEach(el => Console.WriteLine($"({el.UserId}) {el.DisciplineName} - {el.Value}"));
        Console.WriteLine("=-=-=-=");
        users.Join(marks,
            u => u.Id,
            m => m.UserId,
            (u, m) => new { u.Id, m.UserId, u.Name, m.DisciplineName, m.Value })
            .ToList().ForEach(el
            => Console.WriteLine($"({el.Id}<=>{el.UserId}) {el.Name}: {el.DisciplineName} - {el.Value}"));
        Console.WriteLine("=-=-=-=");
        // Geners
        new List<int>(RandEls(20)).ForEach(el => Console.Write($"{el} "));
        Console.WriteLine("\n=-=-=-=");

        // Custom lab task

        Services<Service> firstCollection = new()
        {
            new("cleaning", 12, 5),
            new("medicine", 13, 6),
            new("the beauty", 14, 7),
            new("food", 15, 8)
        };

        firstCollection.Add(new Service("sport", 17, 9));
        foreach (var i in firstCollection)
            Console.WriteLine($"Servis-> {i.NameServ} -> {i.code} -> {i.ServNumver} \n");
        firstCollection.RemoveAt(2);
        Console.WriteLine($"Index Servis(dog walking) is {firstCollection.IndexOf(new("dog walking", 56, 9))}\n");

        List<Service> secondCollection = new();
        foreach (var el in firstCollection)
            secondCollection.Add(el);
        Console.WriteLine(secondCollection.FindIndex(el => el.code == 15));

        ObservableCollection<Service> observableServiss = new()
        {
            new("washing", 223, 654),
            new("ironing ", 7654, 1234),
            new("hairdresser", 123, 09),
            new("barber", 8765, 23),
            new("barista", 98, 655)
        };

        observableServiss.CollectionChanged += ObservableServiss_CollectionChanged;
        observableServiss.Add(new("cook", 456, 765));
        observableServiss.RemoveAt(0);
        observableServiss[0] = new("food", 898, 345);
    }
    static IEnumerable<int> RandEls(int am)
    {
        for (int i = 0; ; i++)
            if (i >= am)
                yield break;
            else
                yield return new Random().Next(20);
    }
    static void ObservableServiss_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) =>
        Console.WriteLine(e.Action switch
        {
            NotifyCollectionChangedAction.Add => $"Добавлен: {e.NewItems[0] as Service}",
            NotifyCollectionChangedAction.Remove => $"Удален: {e.OldItems[0] as Service}",
            NotifyCollectionChangedAction.Replace => $"{e.OldItems[0] as Service} заменен на {e.NewItems[0] as Service}",
            _ => throw new NotImplementedException()
        });
    class Service
    {
        public string NameServ;
        public int code;
        public int ServNumver;
        public Service() => code++;
        public Service(string name, int Code, int num)
        {
            NameServ = name;
            code = Code;
            ServNumver = num;
        }
        public override string ToString() => $"Servis {NameServ}";
    }
    class Services<T> : IList<T> where T : Service
    {
        public List<T> list = new();
        public void ForEach(Action<T> action) => list.ForEach(action);
        public int IndexOf(T value)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i] == value)
                    return i;
            return -1;
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < list.Count)
                    return list[index];
                throw new IndexOutOfRangeException();
            }
            set => list[index] = value;
        }
        public int Count { get => list.Count; }
        public bool IsReadOnly { get => false; }
        public void Add(T item) => list.Add(item);
        public void Clear() => list.Clear();
        public bool Contains(T item)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i] == item)
                    return true;
            return false;
        }
        public void CopyTo(T[] array, int arrayIndex) => list.CopyTo(array, arrayIndex);
        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)list).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<T>)list).GetEnumerator();
        public override int GetHashCode() => base.GetHashCode();
        public void Insert(int index, T item) => list.Insert(index, item);
        public bool Remove(T item)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i] == item)
                {
                    list.RemoveAt(i);
                    return true;
                }
            return false;
        }
        public void RemoveAt(int index)
        {
            for (int i = 0; i < list.Count; i++)
                if (i == index)
                    list.RemoveAt(index);
        }
    }
    class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public static int Am = 0;
        readonly string[] names = "Коля, Вася, Игорь, Петя, Настя, Аня".Split(", ");
        public User()
        {
            Am++;
            Id = Am;
            Name = names[new Random().Next(names.Length)];
        }
    }
    class Mark
    {
        public int UserId { get; set; }
        public string DisciplineName { get; set; }
        public int Value { get; set; }
        readonly string[] disciplineNames = "Матан, Прога, Англ, Физра, Философия".Split(", ");
        public static int Am = 0;
        public Mark()
        {
            UserId = new Random().Next(User.Am);
            Value = new Random().Next(3, 11);
            DisciplineName = disciplineNames[new Random().Next(disciplineNames.Length)];
        }
    }
}