using System;
using System.IO;

namespace ConsoleApp.Modules
{
    public class MainConverter
    {
        private readonly FileInfo _FileToConvert;
        
        public MainConverter(FileInfo fileToConvert)
        {
            _FileToConvert = fileToConvert;
        }

        public void DoSomeStuffWithTheFile()
        {
            Console.WriteLine($"Fully qualified path: {_FileToConvert.FullName}");
            Console.WriteLine($"Exists: {_FileToConvert.Exists}");
            Console.WriteLine($"Length: {_FileToConvert.Length}");
            Console.WriteLine($"Attributes: {_FileToConvert.Attributes}");
        }
    }
}