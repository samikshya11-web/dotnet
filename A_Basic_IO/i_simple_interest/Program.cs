namespace i_simple_interest;

class Program
{
    static void Main(string[] args)
    {
        int p = 11000;
        int t = 3;
        double r = 5;
        double si = (p*t*r)/100;
        Console.WriteLine("Si = " + si);
    }
}
