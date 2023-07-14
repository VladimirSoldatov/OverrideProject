using System;
using static System.Console;
namespace SimpleProject
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        // переопределение метода Equals
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        // необходимо также переопределить метод
        // GetHashCode
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }
        public static bool operator >(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) >
            Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }
        public static bool operator <(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) <
            Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }
        public override string ToString()
        {
            return $"Point: X = {X}, Y = {Y}.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point { X = 10, Y = 10 };
            Point point2 = new Point { X = 20, Y = 20 };
            WriteLine($"point1: {point1}");
            WriteLine($"point2: {point2}\n");
            WriteLine($"point1 == point2:{ point1 == point2}"); // false
            WriteLine($"point1 != point2: {point1 != point2}\n"); // true
            WriteLine($"point1 > point2: {point1 > point2}"); // false

        }
    }
}