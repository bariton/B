using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace ConsoleApplication7
{
    class ReadFromFile
    {
        static void Main()
        {
            string lines = File.ReadAllText(@"C:\Retsenzia.txt");
            Console.WriteLine(lines);



            int a = Regex.Matches(lines, @"\n").Count + 1;
            Console.WriteLine("\nколичество абзацев:" + a);

            int d = Regex.Matches(lines, @".[.?!]").Count;
            Console.WriteLine("количество предложений:" + d);

            int b = Regex.Matches(lines, @"\b[A-Z|a-z]").Count;
            Console.WriteLine("количество слов:" + b);

            int c = Regex.Matches(lines, @".[-,.!?:;]").Count;
            Console.WriteLine("количество знаков препинания:" + c);

            int e = Regex.Matches(lines, @"\b\w{6}\b").Count;
            Console.WriteLine("количество слов состоящих из 6 букв:" + e);

            int f = Regex.Matches(lines, @"\b[A-Z]{2,}\b").Count;
            Console.WriteLine("количество аббревиатур:" + f);


            Console.ReadKey();
        }
    }
}


