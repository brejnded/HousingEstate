using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HousingEstate
{
    public class Flat
    {
        private int numberOfFlat;
        private int areaOfFlat;
        private int numberOfRooms;

        private List<Person> inhabitantsList = new List<Person>();
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
        public void AddHabitant(Person person)
        {
            inhabitantsList.Add(person);
        }
        public override string ToString()
        {
            return String.Format($"\nNumber of flat: {numberOfFlat}\nArea of flat: {areaOfFlat}\nNumber of rooms: {numberOfRooms}");
        }

     /*   public void GetInfoAboutAllHabitants(Person p, Flat f)
        {
            foreach (Person person in inhabitantsList)
            {
                Console.WriteLine();
            }*/
        }
    }
