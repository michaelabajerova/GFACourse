using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apple
{
    class Sum
    {
        public int Summon(List<int> list)
        {
            int sum = 0;
            for(int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            return sum;
        }
    }
}
