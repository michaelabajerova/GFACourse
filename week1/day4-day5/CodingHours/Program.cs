using System;
using System.Xml.Schema;

namespace CodingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52

            int hours = 6;
            int weeks = 17;
            int average = 52;
            
            int a = weeks * 5 * hours;
            Console.WriteLine("Attendee spends " + a + " hours with coding in one semester");

            double b = average * weeks;
            int c = Convert.ToInt32((a / b) * 100);
            Console.WriteLine("Attendee spends on average " + c + "%  time on coding");

            Console.ReadLine();

        }
    }
}
