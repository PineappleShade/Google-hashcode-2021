using System;
using System.Collections.Generic;
using System.Text;

namespace Google_hashcode_2021
{
    class Car
    {
        

        private int id;
        private Path path;
        private int currentLocationIndex = 0;

        public Car()
        {
        }
        public Car(int id, Path path, int currentLocationIndex)
        {
            this.id = id;
            this.path = path;
            this.currentLocationIndex = currentLocationIndex;
        }

        public int Id {
            get => id;
            set => id = value;
        }

        public Path Path
        {
            get => path;
            set => path = value;
        }

        public int CurrentLocationIndex
        {
            get => currentLocationIndex;
            set => currentLocationIndex = value;
        }

        public void AddOneToIndex()
        {
            currentLocationIndex++;
        }
    }
}
