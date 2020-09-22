using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstrumnets
{
    class ElectricGuitar : StringedInstrument
    {
        public void Sound(string sound)
        {
            sound = "Twang";
        }
        public void Play(int str)
        {
            str = 6;
        }
    }
}
