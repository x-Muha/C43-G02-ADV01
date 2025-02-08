using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__Assignment_01.Question04
{
    internal class FixedSizeList<T>
    {
        private int length;
        private int i;
        public T[] Arr {  get; set; }
        public int Length { get { return length; } }
        public FixedSizeList(int len)
        {
            length = len;
            Arr = new T[len];
            i = 0;
        }
        public void Add(T item)
        {
            if (i >= Length) throw new Exception("List Is Full!");
            Arr[i++] = item;
        }
        public T Get(int k)
        {
            if (k >= 0 && k <= i) return Arr[k];
            else throw new Exception("Invalid Index");
        }

        public void Print()
        {
            foreach (var item in Arr)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
        
    }
}
