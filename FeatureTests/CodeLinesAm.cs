using System.IO;
class CodeLinesAm
{
    static void CodeLinesAmMain()
    {
        System.Collections.Generic.List<string> filenames = new(16);
        var linesAm = 0L;
        SearchForCS(@"D:\Downloads\MinecraftClone3-master");
        foreach (var filename in filenames)
            linesAm += File.ReadAllLines(filename).Length;
        System.Console.WriteLine(linesAm);

        void SearchForCS(string dirPath)
        {
            foreach (var filename in Directory.GetFiles(dirPath))
                if (filename.EndsWith(".cs"))
                    filenames.Add(filename);
            foreach (var directory in Directory.GetDirectories(dirPath))
                SearchForCS(directory);
        }
    }
}