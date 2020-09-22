using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstrumnets
{
    abstract class Instrument
    {
        protected string Name { get; set; }

        public virtual void Play()
        {
        }
    }
}
