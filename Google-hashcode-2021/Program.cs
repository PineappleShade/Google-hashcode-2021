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

            string path = "./a_example.txt";

            ArrayList fileContent = ReadFile(path);

            foreach(string line in fileContent){
                Console.WriteLine(line);
            }

        }


        static ArrayList ReadFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            ArrayList tabString = new ArrayList();

            Array.ForEach(lines, i => { tabString.Add(i); });


            return tabString;
        }
    }
}
