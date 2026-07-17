namespace b_conversion;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        double a= 255.345;
       
        int b = (int)a; 
        Console.WriteLine("Double value =" + a);
        Console.WriteLine("Converted integer value =" + b);
    }
}
