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

        public int L1
        {
            get => travelTimeFromBeginningToEnd;
            set => travelTimeFromBeginningToEnd = value;
        }
    }
}
