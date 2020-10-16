using System;
using System.Collections.Generic;
using System.Text;

namespace TurntablTowers
{
    class TurnTablTowers
    {
        private List<Apartment> apartments = new List<Apartment> ();
        private const int numberofFloors = 12;
        private const int numberofApartmentPerFloor = 6;

        public TurnTablTowers(List<Apartment> apartments)
        {
            this.apartments = apartments;
        }

        public int NumberofApartmentPerFloor { get => numberofApartmentPerFloor;}
        public int NumberofFloors { get => numberofFloors;}

        //public void AddApartments() {

        //}

    }
}
