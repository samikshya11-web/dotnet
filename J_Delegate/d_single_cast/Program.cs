using System;

namespace d_single_cast
{
    public class Program
    {
        public delegate void Delegatemethod();

        class Myclass
        {
            public static void display()
            {
                Console.WriteLine("Hello Sanothimi");
            }

            public static void show()
            {
                Console.WriteLine("Hi Nepal");
            }

            public static void print()
            {
                Console.WriteLine("Good Morning");
            }
        }

        static void Main(string[] args)
        {
            // Method 1
            Delegatemethod d1 = Myclass.display;
            d1();

            // Method 2
            Delegatemethod d2 = new Delegatemethod(Myclass.show);
            d2();

            // Method 3
            Delegatemethod d3 = Myclass.print;
            d3.Invoke();
        }
    }
}