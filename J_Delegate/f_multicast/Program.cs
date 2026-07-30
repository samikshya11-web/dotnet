namespace f_multicast;
#nullable disable

public delegate void Mydel(int a, int b);

class Calc
{
    public static void add(int a, int b)
    {
        Console.WriteLine("The sum = " + (a + b));
    }

    public static void mul(int a, int b)
    {
        Console.WriteLine("The product = " + (a * b));
    }

    static void Main(string[] args)
    {
        Mydel d1 = new Mydel(Calc.add);
        Mydel d2 = new Mydel(Calc.mul);

        d1 = d1 + d2;      // Combine delegates

        d1(10, 20);    // Invoke both methods
    }
}