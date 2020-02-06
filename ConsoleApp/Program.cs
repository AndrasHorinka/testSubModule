using System;
using System.IO;
using ConsoleApp.Modules;
using FancyLibrary;

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
            else
            {
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
            }
            
            Console.WriteLine("\n\nLet's test Submodule Functions");
            var fancy = new FancyService();
            fancy.FirstFancyMessage();

            Console.ReadKey();
        }
    }
}