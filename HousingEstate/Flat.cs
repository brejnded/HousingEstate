using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HousingEstate
{
    internal class Flat
    {
        private int numberOfFlat;
        private int areaOfFlat;
        private int numberOfRooms;

        private static List<Person> inhabitantsList = new List<Person>();
        public List<Person> InhabitantsList
        {
            get { return inhabitantsList; }
            set { InhabitantsList = value; }
        }
        public Flat(int numberOfFlat, int areaOfFlat, int numberOfRooms)
        {
            this.numberOfFlat = numberOfFlat;
            this.areaOfFlat = areaOfFlat;
            this.numberOfRooms = numberOfRooms;
        }
        public override string ToString()
        {
            return String.Format($"\n{numberOfFlat}\n{areaOfFlat}\n{numberOfRooms}");
        }

    }
}
