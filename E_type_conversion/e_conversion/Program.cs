namespace e_conversion;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        string a = "123";
       
        int b = Convert.ToInt32(a); 
        int c = 345;
        int sum = b+c;
        Console.WriteLine("Sum =" + sum);
        
    }
}
