using System;
using System.Collections;
using System.Collections.Generic;
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

            List<string> fileContent = ReadFile(path);

            foreach(string line in fileContent){
                Console.WriteLine(line);
            }

        }


        static List<string> ReadFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            // Array.ForEach(lines, i => { tabString.Add(i); });

            return new List<string>(lines);
        }
    }
}
