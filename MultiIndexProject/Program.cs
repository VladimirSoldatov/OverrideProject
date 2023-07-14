using static System.Console;
namespace SimpleProject
{
    public class MultArray
    {
        private int[,] array;
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public MultArray(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            array = new int[rows, cols];
        }
        public int this[int r, int c]
        {
            get { return array[r, c]; }
            set { array[r, c] = value; }
        }
    }
    public class Program
    {
        static void Main()
        {
            MultArray multArray = new MultArray(2, 3);
            for (int i = 0; i < multArray.Rows; i++)
            {
                for (int j = 0; j < multArray.Cols; j++)
                {
                    multArray[i, j] = i + j;
                    Write($"{multArray[i, j]} ");
                }
                WriteLine();
            }
        }
    }
}