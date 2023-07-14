using static System.Console;
namespace SimpleProject
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Vector() { }
        public Vector(Point begin, Point end)
        {
            X = end.X - begin.X;
            Y = end.Y - begin.Y;
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector
            {
                X = v1.X + v2.X,
                Y = v1.Y + v2.Y
            };
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector
            {
                X = v1.X - v2.X,
                Y = v1.Y - v2.Y
            };
        }
        public static Vector operator *(Vector v, int n)
        {
            v.X *= n;
            v.Y *= n;
            return v;
        }
        public override string ToString()
        {
            return $"Vector: X = {X}, Y = {Y}";
        }
    }
    class Program
    {
        static void Main()
        {
            Point p1 = new Point { X = 2, Y = 3 };
            Point p2 = new Point { X = 3, Y = 1 };
            Vector v1 = new Vector(p1, p2);
            Vector v2 = new Vector { X = 2, Y = 3 };
            WriteLine($"\tВектора\n{v1}\n{v2}");
            WriteLine($"\n\tСложение векторов\n{v1 + v2}\n"); // x=3, y=1
            WriteLine($"\tРазность векторов\n{v1 - v2}\n"); // x=-1, y=-5
            Write("Введите целое число\t");
            int n = int.Parse(ReadLine());
            v1 *= n;
            WriteLine($"\n\tУмножение вектора на число { n}\n{v1}\n");
        }
    }
}
