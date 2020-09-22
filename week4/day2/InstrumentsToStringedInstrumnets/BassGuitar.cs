using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstrumnets
{
    class BassGuitar : StringedInstrument
    {
        public void Sound(string sound)
        {
            sound = "Duum-duum-duum";
        }
        public void Play(int str)
        {
            str = 4;
        }
    }
}
