namespace a_conversion;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        byte a= 10;
       // float b=a; //implecit
        float b = (float)a; //explicit i.e type casting
        Console.WriteLine("Byte value =" + a);
        Console.WriteLine("Float value =" + b);
    }
}
