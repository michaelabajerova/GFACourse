using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstrumnets
{
    class Violin : StringedInstrument
    {
        public void Sound(string sound)
        {
            sound = "Screech";
        }
        public void Play(int str)
        {
            str = 4;
        }
    }
}
