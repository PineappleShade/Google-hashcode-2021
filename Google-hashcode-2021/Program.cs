using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google_hashcode_2021
{
    class Program
    {
        static int SIMULATION_TIME;
        static int NUM_INTERSECTIONS;
        static int NUM_STREETS;
        static int NUM_CARS;
        static int POINTS_ON_SUCCESS;


        static List<Intersection> allIntersections = new List<Intersection>();
        static List<Street> allStreets = new List<Street>();
        static List<Path> allPaths = new List<Path>();
        static List<Car> allCars = new List<Car>();
        static List<KeyValuePair<Street, int>> trafficPerStreetOrdered;

        static void Main(string[] args)
        {
            string path = "./a.txt";
            string path2 = "./b.txt";
            RunSimulation(path2);

            Console.WriteLine("SIMULATION_TIME=" + SIMULATION_TIME);
            Console.WriteLine("# INTERSECTIONS=" + NUM_INTERSECTIONS);
            Console.WriteLine("# STREETS=" + NUM_STREETS);
            Console.WriteLine("# CARS=" + NUM_CARS);

            // foreach (Street st in allStreets)
            // {
            //     // Console.WriteLine(st.StreetName);
            // }
            //
            // foreach (Path pt in allPaths)
            // {
            //     foreach (Street st in pt.StreetsPaths)
            //     {
            //         Console.WriteLine(st.StreetName);
            //     }
            //
            //     Console.WriteLine("");
            //
            // }

            // foreach (Intersection inter in allIntersections)
            // {
            //     Console.WriteLine(inter.Id);
            //     Console.WriteLine("Input street:");
            //     foreach (Street st in inter.StreetsInput)
            //     {
            //         Console.WriteLine("    " + st.StreetName);
            //     }
            //     Console.WriteLine("Output street:");
            //     foreach (Street st in inter.StreetsOutput)
            //     {
            //         Console.WriteLine("    " + st.StreetName);
            //     }
            // }
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


                    // Create all intersections only once
                    for (int x = 0; x < NUM_INTERSECTIONS; x++)
                    {
                        allIntersections.Add(new Intersection(x));
                    }
                }

                else if(i < NUM_STREETS + 1) // Read Streets and assign them to intersections
                {
                    Street st = new Street()
                    {
                        StartingIntersection = Int32.Parse(firstValuesSplit[0]),
                        EndIntersection = Int32.Parse(firstValuesSplit[1]),
                        StreetName = firstValuesSplit[2],
                        TravelTimeFromBeginningToEnd = Int32.Parse(firstValuesSplit[3])
                    };

                    Intersection startPoint = allIntersections[st.StartingIntersection];
                    Intersection endPoint = allIntersections[st.EndIntersection];

                    // Street is starting from this intersection so it is a intersection output
                    startPoint.addStreetToOutput(st);

                    // Street is ending at this intersection so it is an input for this intersection 
                    endPoint.addStreetToInput(st);

                    allStreets.Add(st);
                }

                else
                {
                    string[] path = new string[Int32.Parse(firstValuesSplit[0])];
                    List<Street> streetList = new List<Street>();
                    


                    for (int x = 1; x < firstValuesSplit.Length; x++)
                    {
                        foreach (Street st in allStreets)
                        {
                            if (st.StreetName == firstValuesSplit[x])
                            {
                                streetList.Add(st);
                            }
                        }
                    }

                    Path pt = new Path(Int32.Parse(firstValuesSplit[0]), streetList);
                    Car cr = new Car(( i - (NUM_STREETS + 1) ), pt, pt.StreetsPaths[0].EndIntersection);
                    pt.StreetsPaths[0].addToQueue(cr);

                    allCars.Add(cr);
                    allPaths.Add(pt);
                }

            }
        }


        static List<string> ReadFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            return new List<string>(lines);
        }

        static void RunSimulation(string filePath)
        {
            List<string> fileContent = ReadFile(filePath);
            parseInputDoc(fileContent);

            // foreach (Intersection intersection in allIntersections)
            // {
            //     
            // }
            // foreach (Car car in allCars)
            // {
            //     int totalSeconds = 0;
            //     foreach (Street street in car.Path.StreetsPaths)
            //     {
            //         totalSeconds += street.TravelTimeFromBeginningToEnd;
            //     }
            //     Console.WriteLine("Total seconds for car " + car.Id + ": "  + totalSeconds);
            // }

            getHighestRouteTraffic();
        }


        static void getHighestRouteTraffic()
        {
            IDictionary<Street,int> dict = new Dictionary<Street, int>();
            
            // Populate the dictionary
            for (int x = 0; x < allStreets.Count; x++)
            {
                dict.Add(allStreets[x], 0);
            }
            
            // Add them to the list
            for (int x = 0; x < allPaths.Count; x++)
            {
                for (int y = 0; y < allPaths[x].StreetsPaths.Count; y++)
                {
                    dict[allPaths[x].StreetsPaths[y]] += 1;
                }
            }

            // Remove all instances where the street traffic is 0
            foreach (var item in dict.Where(kvp => kvp.Value == 0).ToList())
            {
                dict.Remove(item.Key);
            }

            // Sort it by value
            trafficPerStreetOrdered = dict.ToList();
            trafficPerStreetOrdered.Sort(
                delegate (KeyValuePair<Street, int> pair1,
                KeyValuePair<Street, int> pair2)
                {
                    // Biggest to smallest
                    return pair2.Value.CompareTo(pair1.Value);
                }
            );

            // Print it all out
            foreach (KeyValuePair<Street, int> kvp in trafficPerStreetOrdered)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key.StreetName, kvp.Value);
            }

        }

    }
}
