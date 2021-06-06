//<PackageReference Include="System.Text.Encoding.CodePages" Version="5.0.0" />
namespace VkDeletionTools
{

    using System;
    using System.Linq;
    using System.IO;
    using System.Text;
    public class VkDeletedReader
    {
        public VkDeletedReader()
        {
            var s = Console.ReadLine();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            const string DIR_NAME = @"D:/Documents/MyDocs/Сохранения/Accounts/Archive/messages";
            Directory.GetFiles(DIR_NAME, string.Empty, SearchOption.AllDirectories)
                .Select(fileName => (fileName, text: Encoding.GetEncoding(1251).GetString(File.ReadAllBytes(fileName))))
                .Where(filePair => filePair.text.ToLower().Contains(s))
                .GroupBy(filePair => Path.GetDirectoryName(filePair.fileName))
                .Select(group => group.Key)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}