using System;

namespace Google_hashcode_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hey br");

            Console.WriteLine(ReadFile(a_example.txt));


        }


        public ArrayList ReadFile(string filePath)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            ArrayList tabString = new ArrayList();
            int counter = 0;


            while ((line = file.ReadLine()) != null)
            {
                tabString.add(line);

                counter++;
            }

            return tabString;
        }
    }
}
