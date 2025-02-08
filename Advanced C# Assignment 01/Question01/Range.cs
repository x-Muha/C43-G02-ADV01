using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__Assignment_01.Question01
{
    internal class Range<T> where T : IComparable<T> 
    {
        public T? Min { get; set; }
        public T? Max { get; set; }
        public Range(T min, T max)
        {
            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        { 
            return value.CompareTo(Min)>0 && Max?.CompareTo(value)>0;
        }

        public int Length() 
        {
            return Convert.ToInt32(Max) - Convert.ToInt32(Min);
        }
        public int Length<T>()
        {
            return Max.CompareTo(Min);
        }
    }



    internal class Point2D : IComparable<Point2D>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point2D()
        {
            
        }
        public Point2D(int x, int y)
        {
            X = x;  
            Y = y;
        }
        int IComparable<Point2D>.CompareTo(Point2D? other)
        {
            if(this.X == other.X) return (this.Y - other.Y);
            else return this.X - other.X;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

}
