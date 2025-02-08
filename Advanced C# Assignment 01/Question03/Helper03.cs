using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__Assignment_01.Question03
{
    internal class Helper03
    {
        public static int[] GetEvenNumbers(int[] Arr)
        {
            int count = 0, j = 0; 
            foreach (int i in Arr) if(i%2 == 0) count++;

            int[] EvenArr = new int[count];
            foreach (int i in Arr)
            {
                if (i%2 ==0)
                {
                    EvenArr[j] = i;
                    j++;
                }
            }
            return EvenArr;
        }
    }
}
