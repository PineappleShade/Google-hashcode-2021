using System;
using System.Collections;
using System.IO;

namespace Google_hashcode_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hey br");

            string path = Path.Combine(Directory.GetCurrentDirectory(), "\\a_example.txt");

            Console.WriteLine(path);

            ArrayList fileContent = ReadFile(path);

            // Console.WriteLine(fileContent.ToString());

        }


        static ArrayList ReadFile(string filePath)
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);

            ArrayList tabString = new ArrayList();

            foreach (string line in lines)
            {
                string[] words = line.Split(' ');
                tabString.Add(words);

            }

            return tabString;
        }
    }
}
