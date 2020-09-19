using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apple
{
    class CountLetter
    {
       public Dictionary<char, int> Count(string input)
        {
            var dictionary = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if(dictionary.ContainsKey(input[i]))
                {
                    dictionary[input[i]]++;
                }
                else
                {
                    dictionary.Add(input[i], 1);
                }
            }
            return dictionary;
        }
    }
}
