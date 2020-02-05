using System;
using System.IO;
using ConsoleApp.Modules;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("I need an argument!");
            }
            
            // get File
            var fileInfo = new FileInfo(args[0]);
            if (!fileInfo.Exists)
            {
                Console.WriteLine("No such file found");
            }
            else
            {
                var mainConverter = new MainConverter(fileInfo);
                mainConverter.DoSomeStuffWithTheFile();
            }

            Console.ReadKey();
        }
    }
}