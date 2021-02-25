using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Google_hashcode_2021
{
    class Program
    {
        static int SIMULATION_TIME;
        static int NUM_INTERSECTIONS;
        static int NUM_STREETS;
        static int NUM_CARS;
        static int POINTS_ON_SUCCESS;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hey br");

            string path = "./a.txt";

            List<string> fileContent = ReadFile(path);

            foreach(string line in fileContent){
                Console.WriteLine(line);
            }


            // Test
            parseInputDoc(fileContent);

            Console.WriteLine("SIMULATION_TIME=" + SIMULATION_TIME);
            Console.WriteLine("# INTERSECTIONS=" + NUM_INTERSECTIONS);
            Console.WriteLine("# STREETS=" + NUM_STREETS);
            Console.WriteLine("# CARS=" + NUM_CARS);
            Console.WriteLine("POINTS ON CAR REACHING DESTINATION=" + POINTS_ON_SUCCESS);

        }


        static void parseInputDoc(List<string> content)
        {
            for(int i = 0; i < content.Count; i++)
            {
                string[] firstValuesSplit = content[i].Split(' ');

                if (i == 0) // Read first line values
                {
                    SIMULATION_TIME = Int32.Parse(firstValuesSplit[0]);
                    NUM_INTERSECTIONS = Int32.Parse(firstValuesSplit[1]);
                    NUM_STREETS = Int32.Parse(firstValuesSplit[2]);
                    NUM_CARS = Int32.Parse(firstValuesSplit[3]);
                    POINTS_ON_SUCCESS = Int32.Parse(firstValuesSplit[4]);
                }

                else // Read Streets and intersections
                {

                }
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
