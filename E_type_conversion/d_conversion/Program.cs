namespace d_conversion;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        string a = "123";
       
        int b = int.Parse(a); 
        int c = 345;
        int sum = b+c;
        Console.WriteLine("Sum =" + sum);
        
    }
}
