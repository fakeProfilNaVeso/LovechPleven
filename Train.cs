using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Algorithms
{
    class Train
    {
        private int number; //up to 5 digits
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        private string name; //does not contain spaces
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string type; //could be P (people) or F (freight)
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private int cars; //number of cars
        public int Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        public Train(int number, string name, string type, int cars) //constructor
        {
            this.number = number;
            this.name = name;
            this.type = type;
            this.cars = cars;
        }

        public override string ToString()
        {
            return this.number + " " + this.name + " " + this.type + " " + this.cars;
        }
    }
}
