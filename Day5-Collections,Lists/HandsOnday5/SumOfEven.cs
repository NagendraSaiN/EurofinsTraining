using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnday5
{
    class SumOfEven
    {
        public static int EvenSum(List<int> n)
        {
            int sum = 0;
            for (int i = 0; i < n.Count; i++)
            {
                if (n[i] % 2 == 0)
                {
                    sum += n[i];
                }
            }
            return sum;
        }

    }
}
