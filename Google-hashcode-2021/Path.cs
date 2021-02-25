using System;
using System.Collections.Generic;
using System.Text;

namespace Google_hashcode_2021
{
    class Path
    {
        private int nbrOfStreetToTravel;
        private List<Street> streetsPaths;

        public Path(int nbrOfStreetToTravel, List<Street> streetsPaths)
        {
            this.nbrOfStreetToTravel = nbrOfStreetToTravel;
            this.streetsPaths = streetsPaths;
        }

        public int NbrOfStreetToTravel
        {
            get => nbrOfStreetToTravel;
            set => nbrOfStreetToTravel = value;
        }

        public List<Street> StreetsPaths
        {
            get => streetsPaths;
            set => streetsPaths = value;
        }
    }
}
