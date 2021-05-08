using System;
class Lesson
{
    static void MainConvertations()
    {
        var min = new Minutes() { value = 10 };
        Seconds seconds = (Seconds)min;
        Console.WriteLine(seconds.value);
    }
}
class Minutes
{
    public int value = 0;
}
class Seconds
{
    public int value = 0;
    public static explicit operator Seconds(Minutes min)=> new(){ value = min.value * 60 };
}