using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TurntablTowers
{
    class BasicApartment : Apartment
    {
        public BasicApartment(int floorNumber, int doorNumber, string residentName) : base(floorNumber, doorNumber, residentName)
        {

        }

        public override void RingDoorbell()
        {
            Random random = new Random();

            int randomNumber = random.Next(0, 100);
            if (randomNumber < 10)
            {
                Console.WriteLine("Basic Apartment: Hey there");
            }else
            {
                throw new NobodyHomeException(" Basic Apartment: Nobody home!");
            }    
        }

        public override string ToString()
        {
            return ($"floorNumber: {floorNumber} \nndoorNumber: {doorNumber}: residentName: {residentName}");
        }
    }
}
