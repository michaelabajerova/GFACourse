using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Michaela Bajerova");
            Console.WriteLine(25);
            Console.WriteLine(1.72);

            Console.WriteLine(13 + 22);
            Console.WriteLine(13 - 22);
            Console.WriteLine(22 * 13);
            Console.WriteLine(22 / 1.3);
            int a = 22;
            int b = 13;
            Console.WriteLine(a - b);
            Console.WriteLine(9 / 13);

            int c = 17 * 7;
            int d = 17 * 5;
            int e = c - d;
            Console.WriteLine(e);

            int f = 52 * 17;
            int g = 17 * 5;
            int h = g % f;
            Console.WriteLine(h);


            ///fav number //
           var num = 7;
            string text = "my favorite number is: ";
            Console.WriteLine(text + num);

            /// define basics ///
            string name = "misa";
            Console.WriteLine(name);
            int i = 25;
            Console.WriteLine(i);
            double m = 1.73;
            Console.WriteLine(m);
            bool iamtaken = true;
            Console.WriteLine(iamtaken);


            /// variable mutations ///
            int j = 3;
            j += 10;
            Console.WriteLine(j);
            
            int k = 100;
            k -= 7;
            Console.WriteLine(k);
           
            int l = 44;
            l *= 2;
            Console.WriteLine(l);
            
            int m1 = 125;
            m1 /= 5;
            Console.WriteLine(m1);
            
            int n = 8;
            n = n*n*n;
            Console.WriteLine(n);
            
            int o = 123;
            int p = 345;
            Console.WriteLine(o > p);

            int q = 350;
            int r = 200;
            Console.WriteLine(r*2 > q*2);

            int s = 10;
            int t = 3;
            Console.WriteLine(s > t * t);
            Console.WriteLine(s < t*t*t);

            long u = 1357988018575474;
            Console.WriteLine($"is 11 divisor of {u}?");
            bool isDivisor = h % 11 == 0 ? true : false;
            Console.WriteLine(isDivisor);









        }
    }
}
