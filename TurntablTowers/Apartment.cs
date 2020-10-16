using System;
using System.Collections.Generic;
using System.Text;

namespace TurntablTowers
{
    abstract class Apartment
    {
        public int apartmentNumber;
        public int floorNumber;
        public string doorNumber;
        public string residentName;

        public Apartment(int apartmentNumber, int floorNumber, string residentName)
        {
            this.apartmentNumber = apartmentNumber;
            this.floorNumber = floorNumber;
            this.doorNumber = floorNumber + "0" + apartmentNumber;
            this.residentName = residentName;
        }

        public abstract void RingDoorbell();
        public abstract string ToString();
    }


}
