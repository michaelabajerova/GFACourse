using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolStation
{
    class Station
    {
        public int GasAmount { get; set; }
        public int Car { get; set; }

        public Station(int gasAmount)
        {
            GasAmount = gasAmount;
        }
        public int ReFill(Car car)
        {
            car.GasAmount += car.Capacity;
            GasAmount -= car.Capacity;

            return GasAmount;
        }
    }
}
