using System.IO;

namespace Examples
{
    public class TextSerialisation
    {
        public TextSerialisation()
        {
            const string fileName = "file.txt";
            System.Text.StringBuilder sb = new(string.Empty);
            System.Random rand = new();
            var end = 'z' + 1;
            System.Threading.Tasks.Parallel.For(0, 5_000_000, i => sb.Append((char)rand.Next('a', end)));
            var text = sb.ToString();
            var stopWatch = System.Diagnostics.Stopwatch.StartNew();
            StreamWriter sw = new(fileName, false);
            sw.Write(text);
            System.Console.WriteLine(stopWatch.Elapsed);
            sw.Close();
            stopWatch.Restart();
            using FileStream fs = new(fileName, FileMode.Open);
            fs.Position = new FileInfo(fileName).Length;
            fs.Write(System.Text.Encoding.UTF8.GetBytes(text));
            System.Console.WriteLine(stopWatch.Elapsed);
        }
    }
}
