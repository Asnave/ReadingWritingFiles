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
            // Apsolute (full) Path *HARD CODING*
            file = System.IO.File.ReadAllText(@"C:\Users\W0434838\Desktop\ReadingWritingFiles\Story.txt");
            Console.WriteLine(file);
            Console.ReadKey(true);

            // making it to an array
            string[] fileLines;
            fileLines = System.IO.File.ReadAllLines(@"C:\Users\W0434838\Desktop\ReadingWritingFiles\Story.txt");
            Console.WriteLine(fileLines[0]);
            Console.WriteLine(fileLines[1]);
            Console.ReadKey(true);

            // *NOT HARD CODING* -
            // DO : Make txt file and drag it in Solution Explorer under Parent with C#, box icon and title of visual studio project 
            // THEN : Under file name within the Solution Explorer TURN ON COPY TO OUTPUT DIRECTORY then ALWAYS COPY.
            string [] storyFile;
            storyFile = System.IO.File.ReadAllLines(@"Story.txt");
            Console.WriteLine(storyFile[0]);
            Console.WriteLine(storyFile[1]);
            Console.WriteLine(storyFile[2]);
            Console.WriteLine(storyFile[3]);
            Console.ReadKey(true);

            // Writing lines - SAVING 
            System.IO.File.WriteAllLines(@"savefile.txt", storyFile);
            Console.ReadKey(true);

            
        }
    }
}
