using System;

namespace ConditionalVariableMutation
{
    class Program
    {
        static void Main(string[] args)
        {

            // if a is even increment out by one

            double a = 24;
            int num = 0;
           
          


            // if b is between 10 and 20 set out2 to "Sweet!"
            // if less than 10 set out2 to "Less!",
            // if more than 20 set out2 to "More!"
           
            int b = 13;
            string out2 = "";
            
            if ( b > 10 && b < 20)
            {
                Console.WriteLine("Sweet!");
            }
            if (b < 10)
            {
                Console.WriteLine("Less!");
            }
            if (b > 20)
            {
                Console.WriteLine("More!");
            }

            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same
            int c = 123;
            int credits = 100;
            bool isBonus = false;

            if (credits >=50 && !isBonus)
            {
                Console.WriteLine(c -= 2);
            }
            if (credits < 50 && !isBonus)
            {
                Console.WriteLine(c--);
            }
            if (isBonus == true)
            {
                Console.WriteLine(c);
            }
            
            

           
            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"
           
            int d = 8;
            int time = 120;
            string out3 = "";

            if (d % 4 == 0 && time <= 200)
            {
                Console.WriteLine("Check");
            }
            if (time > 200)
            {
                Console.WriteLine("Time out");
            }
            else
            {
                Console.WriteLine("Run Forest Run");
            }

            Console.ReadLine();
        }
    }
}
