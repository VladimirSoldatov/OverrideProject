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
    enum Vendors { Samsung, Asus, LG };
    public class Shop
    {
        private Laptop[] laptopArr;
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
    public Laptop this[string name]
    {
        get
        {
            if (Enum.IsDefined(typeof(Vendors), name))
            {
                return laptopArr[(int)Enum.
                Parse(typeof(Vendors), name)];
            }
            else
            {
                return new Laptop();
            }
        }
        set
        {
            if (Enum.IsDefined(typeof(Vendors), name))
            {
                laptopArr[(int)Enum.
                Parse(typeof(Vendors), name)] =
                value;
            }
        }
    }
    public int FindByPrice(double price)
    {
        for (int i = 0; i < laptopArr.Length; i++)
        {
            if (laptopArr[i].Price == price)
            {
                return i;
            }
        }
        return -1;
    }
    public Laptop this[double price]
    {
        get
        {
            if (FindByPrice(price) >= 0)
            {
                return this[FindByPrice(price)];
            }
            throw new Exception("Недопустимая стоимость.");
        }
        set
        {
            if (FindByPrice(price) >= 0)
            {
                this[FindByPrice(price)] = value;
            }
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
                Vendor = "Samsung",
                Price = 5200
            };
            laptops[1] = new Laptop
            {
                Vendor = "Asus",
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
                WriteLine();
                WriteLine($"Производитель Asus:{ laptops["Asus"]}.");
                WriteLine($"Производитель HP:{ laptops["HP"]}.");
                // игнорирование
                laptops["HP"] = new Laptop();
                WriteLine($"Стоимость 4300:{ laptops[4300.0]}.");
                    // недопустимая стоимость
                WriteLine($"Стоимость 10500:{ laptops[10500.0]}.");
                // игнорирование
                laptops[10500.0] = new Laptop();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}