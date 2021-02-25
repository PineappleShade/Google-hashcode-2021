using System;
using System.Collections.Generic;
using System.Text;

namespace Google_hashcode_2021
{
    class Intersection
    {
        private int id;
        private List<Street> streetsInput;
        private List<Street> streetsOutput;

        public Intersection(int id)
        {
            this.id = id;
        }

        public int getID()
        {
            return id;
        }

        public List<Street> getStreetsInput()
        {
            return streetsInput;
        }

        public List<Street> getStreetsOutput()
        {
            return streetsOutput;
        }

        public void addStreetToInput(Street s)
        {
            streetsInput.Add(s);
        }

        public void addStreetToOutput(Street s)
        {
            streetsInput.Add(s);
        }

    }
}
