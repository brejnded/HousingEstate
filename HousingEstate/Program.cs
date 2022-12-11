using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Janko_Kolenik = new Person("Janko", "Kolenik", 43 );
            Console.WriteLine(Janko_Kolenik);

            

            Flat naKycerke = new Flat(420, 69, 4);
            Console.WriteLine(naKycerke);
            
        }
    }
}
