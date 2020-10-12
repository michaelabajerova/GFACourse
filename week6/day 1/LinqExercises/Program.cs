using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1//
            int[] exe1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var numExe1 = exe1.Where(x => x % 2 == 0);
            foreach (var finList in numExe1)
            {
                Console.WriteLine(finList);
            }
            /*var numExe1 =
                from finList in exe1
                where finList % 2 == 0
                select finList;*/
            //Exercise 2//
            int[] exe2 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var numExe2 = exe2.Where(n => n % 2 == 1).Average();
            /*var numExe2 =
                (from sumNum in exe2
                 where sumNum % 2 == 1
                 select sumNum).Sum();*/

             Console.WriteLine(numExe2);
            //Exercise 3//
            int[] exe3 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var sumNum = exe3.Where(n => n > 0).Sum();
            var squaredNum = sumNum * sumNum;
/*            var sumNum = 
                (from number in exe3
                 where number > 0
                 select number).Sum();
                 var squaredNum = sumNum * sumNum;*/
            Console.WriteLine(sumNum);

            //Exercise 4//
            int[] exe4 = new[] { 3, 9, 2, 8, 6, 5 };

            var value = exe4.Where(n => Math.Pow(n, 2) > 20);
            /*var squaredValue = 
                from number in exe4
                where number * number > 20
                select number;*/

            foreach (var finNum in value)
            {
                Console.WriteLine(finNum);
            }
            //Exercise 5//
            int[] exe5 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequency = exe5.GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());
            /* var frequency = 
                from number in exe5
                group number by number into g
                select new { g.Key, Count = g.Count()};*/

            foreach (var numbers in frequency)
            {
                Console.WriteLine(numbers);
            }
            
            //Exercise 6//
            string text = "Caesar is considered by many historians to be one of the greatest military commanders in history.";

            var freqChar = text.GroupBy(c => c).Select(c => new { Char = c.Key, Count = c.Count() });
            /*var freqChar = 
                from character in text
                group character by character into g
                select new { g.Key, Count = g.Count()};*/
            foreach (var result in freqChar)
            {
                Console.WriteLine(result);
            }
            //Exercise 7//
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var words = cities.Where(l => l.StartsWith('A') && l.EndsWith('I'));
            /*var findCity =
                from city in cities
                where city.StartsWith('A') && city.EndsWith('I')
                select city;*/
            foreach (var city in words)
            {
                Console.WriteLine(city);
            }
            //Exercise 8//
            string text2 = "During the early days prior to the unification of Upper and Lower Egypt, the Deshret or the Red Crown," +
                "was a representation of the kingdom of Lower Egypt, while the Hedjet, the White Crown," +
                "was worn by the kings of the kingdom of Upper Egypt.";
            var upperLetter = text2.Where(c => Char.IsUpper(c));
            /*var findUpper =
                from c in upperLetter
                where char.IsUpper(c)
                select c;  */          
            foreach (var lines in upperLetter)
            {
                Console.WriteLine(lines);
            }
            //Exercise 9//
            char[] array = { 'a', 'v', 'b', 'g', 'r', 'q' };
            var newSentence = new string(array);

            var joinedSentence = string.Empty;
            array.ToList().ForEach(c => joinedSentence = joinedSentence.Insert(joinedSentence.Length, c.ToString()));
            Console.WriteLine(array);
            //Exercise 10//
            var fox1 = new Fox("Alfa","Lagopus","blue");
            var fox2 = new Fox("Beta","pallida","green");
            var fox3 = new Fox("Gamma","zerda","red");
            var fox4 = new Fox("Delta","velox","green");
            var fox5 = new Fox("Sigma","pallida","blue");

            List<Fox> foxes = new List<Fox>();
            foxes.Add(fox1);
            foxes.Add(fox2);
            foxes.Add(fox3);
            foxes.Add(fox4);
            foxes.Add(fox5);

            var greenFox = foxes.FindAll(x => x.Color == "green").ToList();
            var greenAndPallida = foxes.FindAll(x => x.Color == "green" && x.Type == "pallida").ToList();
            foreach (var green in greenFox)
            {
                Console.WriteLine(green.Name);
            }
            foreach(var gAndP in greenAndPallida)
            {
                Console.WriteLine(gAndP.Name);
            }
            //Exercise 11//
            var output = File.ReadAllText(@"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week6\day 1\LinqExercises\TiananmenSquareProtests.txt").ToLower().Split(' ').GroupBy(w => w).OrderByDescending(w => w.Count()).Take(100);
            foreach (var content in output)
            {
                Console.WriteLine(content.Key + ":" + content.Count());
            }
            //Exercise 12//
            var readFile = File.ReadAllText(@"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week6\day 1\LinqExercises\StarWarsCharacters.csv");
            
            
        }
    }
}
