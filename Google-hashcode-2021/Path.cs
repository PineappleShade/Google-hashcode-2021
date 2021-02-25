﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Google_hashcode_2021
{
    class Path
    {
        private int nbrOfStreetToTravel;
        private string[] streetsPath;

        public Path(int nbrOfStreetToTravel, string[] streetsPath)
        {
            this.nbrOfStreetToTravel = nbrOfStreetToTravel;
            this.streetsPath = streetsPath;
        }

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