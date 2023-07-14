using static System.Console;
namespace SimpleProject
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        //перегрузка инкремента
        public static Point operator ++(Point s)
        {
            s.X++;
            s.Y++;
            return s;
        }
        //перегрузка декремента
        public static Point operator --(Point s)
        {
            s.X--;
            s.Y--;
            return s;
        }
        //перегрузка оператора -
        public static Point operator -(Point s)
        {
            return new Point { X = -s.X, Y = -s.Y };
        }
        public override string ToString()
        {
            return $"Point: X = {X}, Y = {Y}";
        }
    }
    class Program
    {
        static void Main()
        {
            Point point = new Point { X = 10, Y = 10 };
            WriteLine($"Исходная точка\n" +
                $"{point}");
            WriteLine("Префиксная и постфиксная формы " +
                "инкремента выполняются одинаково");
            WriteLine(++point); // x=11, y=11
            WriteLine(point++); // x=12, y=12

            WriteLine($"Префиксная форма декремента\n " +
                $"{ --point}");
            WriteLine($"Выполнение оператора –\n" +
                $"{ -point}");
            WriteLine($"не изменило исходную точку\n" +
                $"{ point}");
        }
    }
}