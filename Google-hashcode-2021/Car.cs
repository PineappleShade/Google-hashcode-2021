using System;
using System.Collections.Generic;
using System.Text;

namespace Google_hashcode_2021
{
    class Car
    {
        private int id;
        private string[] path;
        private int currentLocationIndex = 0;

        public int Id {
            get => id;
            set => id = value;
        }

        public string[] Path
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
