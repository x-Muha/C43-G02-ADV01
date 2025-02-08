using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__Assignment_01.Question02
{
    internal class Helper02 /*: IComparable*/
    {
        public static void Reverse<T>(T[] Arr)
        {
            for (int i = 0; i < Arr.Length/2; i++)
            {
                Swap(ref Arr[i],ref Arr[Arr.Length - 1 - i]);
            }
        }

        public static void Swap<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void Print<T>(T[] Arr)
        {
            foreach (T i in Arr)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}
