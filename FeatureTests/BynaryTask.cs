using System;
using System.IO;
using System.Collections.Generic;
public static class Task
{
    class Student
    {
        static readonly string[] surnames = { "Белькевич", "Мбеляев", "Атрашкевич", "Дегалевич", "Климято", "Струков", "Ачивось"};
        static int last_num = 1901002010;
        public string surname;
        public int index_num;
        public int group_num;
        public int mark;
        public Student()
        {
            Random r = new();
            surname = surnames[r.Next(surnames.Length)];
            index_num = last_num;
            last_num++;
            group_num = r.Next(11, 49);
            mark = r.Next(3, 11);
        }
        public Student(string surname, int index_num, int group_num, int mark)
        {
            this.surname = surname;
            this.index_num = index_num;
            this.group_num = group_num;
            this.mark = mark;
        }
    }
    static readonly List<Student> students = new();
    public static void RandomFill()
    {
        students.Clear();
        for (int i = 0; i < new Random().Next(3,7); i++)
            students.Add(new());
    }
    public static void WriteToFile()
    {
        using BinaryWriter writer = new(File.Open("file.dat", FileMode.OpenOrCreate));
        writer.Flush();
        foreach (var student in students)
            Write(writer, student);
        writer.Close();
        static void Write(BinaryWriter writer, Student student)
        {
            writer.Write(student.surname);
            writer.Write(student.index_num);
            writer.Write(student.group_num);
            writer.Write(student.mark);
        }
    }
    public static void OutFromFile()
    {
        try
        {
            using BinaryReader reader = new(File.Open("file.dat", FileMode.Open));
            while (reader.PeekChar() > -1)
                Console.WriteLine($"Студент: {reader.ReadString()}\t({reader.ReadInt32()}), {reader.ReadInt32()} - {reader.ReadInt32()}");
            reader.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
