using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Apple
{
    class Anagram
    {
        public bool IsAnagramm(string str1, string str2)
        {
            char[] first = str1.ToCharArray();
            char[] second = str2.ToCharArray();
            Array.Sort(first);
            Array.Sort(second);

            for(int i = 0; i < first.Length; i++)
            {
                if (first[i] == second[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
