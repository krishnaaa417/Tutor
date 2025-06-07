using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Leetcode
{
    internal class JewelsAndStoness
    {
        static void Main(string[] args)
        {
           JewelsAndStoness j = new JewelsAndStoness();
            Console.WriteLine(j.numJewelsInStones("aA", "aAAbbbb"));;
        }

        public int numJewelsInStones(String jewels, String stones)
        {
            char[] jewwlss = jewels.ToCharArray();
            char[] stoness = stones.ToCharArray();
            int count = 0;

            for (int i = 0; i < jewwlss.Length; i++)
            {
                for (int j = 0; j < stoness.Length; j++)
                {
                    if ( stoness[j] == jewwlss[i])
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;

        }
    }
}
