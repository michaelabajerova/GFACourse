using System;
using System.Collections.Generic;

namespace MapIntroduction2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mapIntro = new Dictionary<string, string>();
            mapIntro.Add("978-1-60309-452-8", "A Letter to Jo");
            mapIntro.Add("978-1-60309-459-7", "Lupus");
            mapIntro.Add("978-1-60309-444-3", "Red Panda and Moon Bear");
            mapIntro.Add("978-1-60309-461-0", "The Lab");

            mapIntro.Remove("978-1-60309-444-3");
            mapIntro.Remove("978-1-60309-461-0");

            foreach (var finish in mapIntro)
            {
                Console.WriteLine(finish);
            }

            mapIntro.Add("978-1-60309-450-4", "They Called Us Enemy");
            mapIntro.Add("978-1-60309-453-5", "Why Did We Trust Him?");

            if (mapIntro.ContainsKey("478-0-61159-424-8"))
            {
                Console.WriteLine("nothing");
            }
            if (mapIntro.ContainsKey("978-1-60309-453-5"))
            {
                Console.WriteLine(mapIntro["978-1-60309-453-5"]);
            }
            Console.ReadLine();
        }
    }
}
