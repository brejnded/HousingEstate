using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    public class Program
    {
        static void Main(string[] args)
        {

            Person janko_Kolenik = new Person("Janko", "Kolenik", 43);
            Person oliver_Krkoska = new Person("Oliver", "Krska", 16);
            Person jakub_Hanz = new Person("Jakub", "Hanz", 34);
            Person pan_chalupka = new Person("Jakub", "Chalupka", 16);

            Flat naKycerke = new Flat(420, 69, 4);
            Flat naLuniku = new Flat(69, 240, 27);
            Flat vZaskove = new Flat(134, 24, 312);

            naKycerke.AddHabitant(jakub_Hanz);
            naLuniku.AddHabitant(janko_Kolenik);
            naLuniku.AddHabitant(pan_chalupka);
            vZaskove.AddHabitant(oliver_Krkoska);

            Console.WriteLine(naKycerke);
            Console.WriteLine(naLuniku);
            Console.WriteLine(vZaskove);

            Console.WriteLine(janko_Kolenik);
            Console.WriteLine(oliver_Krkoska);
            Console.WriteLine(jakub_Hanz);
            Console.WriteLine(pan_chalupka);

        }
    }
}