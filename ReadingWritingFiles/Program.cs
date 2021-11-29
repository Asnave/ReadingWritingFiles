using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingWritingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey(true);

            // Reading Files - story.txt file

            string file;
            // Apsolute (full) Path
            file = System.IO.File.ReadAllText(@"C:\Users\W0434838\Desktop\ReadingWritingFiles\Story.txt");
            Console.WriteLine(file);
            Console.ReadKey(true);
            // relative Path
            string[] fileLines;
            fileLines = System.IO.File.ReadAllLines(@"C:\Users\W0434838\Desktop\ReadingWritingFiles\Story.txt");
            Console.WriteLine(fileLines[0]);
            Console.WriteLine(fileLines[1]);
            Console.ReadKey(true);

            // Writing Files

            // Adding Files to Cisual Studio Solution (project)
        }
    }
}
