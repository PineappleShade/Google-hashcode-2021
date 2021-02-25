using System;
using System.Collections.Generic;
using System.Text;

namespace Google_hashcode_2021
{
    class Path
    {
        private int nbrOfStreetToTravel;
        private string[] streetsPath;

        public int NbrOfStreetToTravel
        {
            get => nbrOfStreetToTravel;
            set => nbrOfStreetToTravel = value;
        }

        public string[] StreetsPath
        {
            get => streetsPath;
            set => streetsPath = value;
        }
    }
}
