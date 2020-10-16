using System;
using System.Collections.Generic;

namespace TurntablTowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartment appartment1 = new GrandApartment(1, 1, "Afi");
            Apartment appartment2 = new SilverApartment(2, 2, "Khay");
            Apartment appartment3 = new BasicApartment(3, 3, "Baa");
            Apartment appartment4 = new SilverApartment(4, 4, "Saa");
            Apartment appartment5 = new BasicApartment(5, 5, "Maa");
            Apartment appartment6 = new SilverApartment(6, 6, "Lee");

            List<Apartment> turntabl = new List<Apartment>();
            turntabl.Add(appartment1);
            turntabl.Add(appartment2);
            turntabl.Add(appartment3);
            turntabl.Add(appartment4);
            turntabl.Add(appartment5);
            turntabl.Add(appartment6);

            TurnTablTowers ttt = new TurnTablTowers(turntabl);

            //Console.WriteLine(appartment1.doorNumber);
            //try {
            //    appartment.RingDoorbell();
            //} catch (NobodyHomeException e) {
            //    Console.Error.WriteLine(e.Message);
            //}
            

        }
    }
}
