using System;
using System.Collections.Generic;
using System.Text;

namespace TurntablTowers
{
    class GrandApartment : Apartment
    {
        //private string butler;
        public GrandApartment(int floorNumber, int doorNumber, string residentName) : base(floorNumber, doorNumber, residentName)
        {
            //Butler = butler_;
        }

        //public string Butler { get => butler; set => butler = value; }

        public override void RingDoorbell()
        {
            Console.WriteLine("Grand Apartment: Hey there");
        }

        public override string ToString()
        {
            return ($"floorNumber: {floorNumber} \nndoorNumber: {doorNumber}: residentName: {residentName}");
        }
    }
}
