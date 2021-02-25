using System;
using System.Collections.Generic;
using System.Text;

namespace Google_hashcode_2021
{
    class Intersection
    {
        private int id;
        private List<Street> streetsInput = new List<Street>();
        private List<Street> streetsOutput = new List<Street>();
        


        public Intersection(int id)
        {
            this.id = id;
        }

        public int Id
        {
            get => id;
        }

        public List<Street> StreetsInput
        {
            get => streetsInput;
        }

        public List<Street> StreetsOutput
        {
            get => streetsOutput;
        }

        public void addStreetToInput(Street s)
        {
            streetsInput.Add(s);
        }

        public void addStreetToOutput(Street s)
        {
            streetsOutput.Add(s);
        }

        

    }
}
