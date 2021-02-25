using System;
using System.Collections.Generic;
using System.Text;

namespace Google_hashcode_2021
{
    class Street
    {
        private int startingIntersection;
        private int endIntersection;
        private string streetName;
        private int travelTimeFromBeginningToEnd;
        private Queue<Car> carQueue;

        public Street()
        {
            
        }

        public Street(int startingIntersection, int endIntersection, string streetName, int travelTimeFromBeginningToEnd)
        {
            this.startingIntersection = startingIntersection;
            this.endIntersection = endIntersection;
            this.streetName = streetName;
            this.travelTimeFromBeginningToEnd = travelTimeFromBeginningToEnd;
        }

        public int StartingIntersection
        {
            get => startingIntersection;
            set => startingIntersection = value;
        }

        public int EndIntersection
        {
            get => endIntersection;
            set => endIntersection = value;
        }

        public string StreetName
        {
            get => streetName;
            set => streetName = value;
        }

        public int TravelTimeFromBeginningToEnd
        {
            get => travelTimeFromBeginningToEnd;
            set => travelTimeFromBeginningToEnd = value;
        }

        public Queue<Car> CarQueue
        {
            get => carQueue;
        }

        public void addToQueue(Car car)
        {
            carQueue.Enqueue(car);
        }
        public void removeFromQueue(Car car)
        {
            Console.WriteLine("Dequeuing '{0}'", carQueue.Dequeue());
            Console.WriteLine(carQueue);
        }
    }
}
