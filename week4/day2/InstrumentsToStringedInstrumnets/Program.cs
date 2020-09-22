using System;

namespace InstrumentsToStringedInstrumnets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test 1 Play,\nElectric Guitar, a 6-stringed instrument that twangs \nBass Guitar, a 4-stringed instrument " +
                "that Duum-duum-duum \nViolin, a 4-stringed instrument that screeches");
            Instrument guitar = new ElectricGuitar();
            Instrument bassGuitar = new BassGuitar();
            Instrument violin = new Violin();

            guitar.Play();
            bassGuitar.Play();
            violin.Play();

            Console.WriteLine("Test 2, create Electric Guitar, Bass Guitar with 7 and 5 strings .");
            ElectricGuitar guitar2 = new ElectricGuitar();
            BassGuitar bassGuitar2 = new BassGuitar();

            Console.WriteLine("Test 2 Play");
            guitar2.Play();
            bassGuitar2.Play();

            Console.WriteLine("Electric Guitar, a 7-stringed instrument that twangs \nBass Guitar, a 5-stringed instrument that Duum-duum-duum");
            ElectricGuitar guitar3 = new ElectricGuitar();
            BassGuitar bassGuitar3 = new BassGuitar();
        }
    }
}
