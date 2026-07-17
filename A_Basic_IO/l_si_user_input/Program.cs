namespace l_si_user_input;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of p : ");
        int p = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the value of t : ");
        int t = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the value of r : ");
        int r = Convert.ToInt32(Console.ReadLine());

        int si = (p*t*r) / 100;

        Console.WriteLine("Simple interest = " + si);
    }
}
