using System;
using System.Collections.Generic;
using System.Text;

namespace TurntablTowers
{
    class SilverApartment : Apartment
    {
        public SilverApartment(int floorNumber, int doorNumber, string residentName) : base(floorNumber, doorNumber, residentName)
        {
        }

        public override void RingDoorbell()
        {
            Random random = new Random();

            int randomNumber = random.Next(0, 100);
            if (randomNumber < 80)
            {
                Console.WriteLine("Silver Apartment: Hey there");
            }
            else
            {
                throw new NobodyHomeException("Silver Apartment: Nobody home!");
            }
        }

        public override string ToString()
        {
            return ($"floorNumber: {floorNumber} \nndoorNumber: {doorNumber}: residentName: {residentName}");
        }
    }
}
