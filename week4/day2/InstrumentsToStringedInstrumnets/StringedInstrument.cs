using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstrumnets
{
    abstract class StringedInstrument : Instrument
    {
        protected int NumberOfStrings { get; set; }

        public void Introduce(int numberOfStrings)
        {
            NumberOfStrings = numberOfStrings;
        }
        protected abstract void Sound();

        public override void Play()
        {
            Sound();
        }

    }
}
