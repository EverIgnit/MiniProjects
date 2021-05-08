using System.Linq;
using System.IO;
class Directiories
{
    static void MainDirectories()
    {
        var dirpath = @"D:\Audio\Вокал";
        Directory.GetFiles(dirpath).Select(filepath => new FileChangesManager(filepath)).GroupBy(fileChangesManager => fileChangesManager.FileTempName).Where(group => group.Count() > 2).ToList().ForEach(group =>
        {
            var newpath = @$"{dirpath}\{group.Key}";
            Directory.CreateDirectory(newpath);
            group.Select(fileChangesManager => fileChangesManager.FileInfo.FullName).ToList().ForEach(filename =>
            {
                File.Copy(filename, $@"{newpath}\{filename[(dirpath.Length + 1)..]}");
                File.Delete(filename);
            });
        }
        );
    }
    class FileChangesManager
    {
        public FileInfo FileInfo { get; set; }
        public string FileTempName { get; set; }
        public FileChangesManager(string filepath)
        {
            FileInfo = new(filepath);
            FileTempName = filepath[(FileInfo.Directory.FullName.Length + 10)..^4];
            if (FileTempName[^1] - '0' is < 9 and > 1)
                FileTempName = FileTempName[..^2];
        }
    }
}