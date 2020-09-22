using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class Carrier
    {
        protected List<Aircraft> Craft;
        public int StoredAmmo { get; set; }
        protected int Health { get; set; }
        protected int InitialAmmo { get; set; }
    }
}
