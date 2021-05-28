using System.IO;
using System.Linq;
class DebugClearer
{
    public DebugClearer(string dirName)
    {
        Directory.GetDirectories(dirName,
            string.Empty, SearchOption.AllDirectories)
            .Where(dirName =>
            ".vs bin obj Debug x64 x86 Release"
            .Split(' ').Contains(dirName[(dirName
            .LastIndexOf(Path.DirectorySeparatorChar) + 1)..]))
            .ToList()
            .ForEach(dirName =>
            {
                if (!dirName.Contains("Lesson"))
                    if (Directory.Exists(dirName))
                        Directory.Delete(dirName, true);
            });
    }
}