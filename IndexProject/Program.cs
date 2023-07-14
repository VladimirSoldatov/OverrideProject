using System;
using static System.Console;
namespace SimpleProject
{
    public class Laptop
    {
        public string Vendor { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Vendor} {Price}";
        }
    }
    public class Shop
    {
        Laptop[] laptopArr;
        public Shop(int size)
        {
            laptopArr = new Laptop[size];
        }
        public int Length
        {
            get { return laptopArr.Length; }
        }
        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index <
                laptopArr.Length)
                {
                    return laptopArr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                laptopArr[index] = value;
            }
        }
}
public class Program
{
    public static void Main()
    {
        Shop laptops = new Shop(3);
        laptops[0] = new Laptop
        {
            Vendor =
        "Samsung",
            Price = 5200
        };
        laptops[1] = new Laptop
        {
            Vendor =
        "Asus",
            Price = 4700
        };
            laptops[2] = new Laptop
            {
                Vendor = "LG",
                Price = 4300
            };
            try
            {
                for (int i = 0; i < laptops.Length; i++)
                {
                    WriteLine(laptops[i]);
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
