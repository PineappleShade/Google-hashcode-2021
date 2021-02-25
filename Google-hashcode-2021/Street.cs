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
        private int L;

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
            get => L;
            set => L = value;
        }
    }
}
