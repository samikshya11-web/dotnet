namespace a_exception;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
       
        int dividend = 12, divisor =0, quotient;
        try
        {
            quotient = dividend/divisor;
            Console.WriteLine("The result =" + quotient);
            
        }
        catch( Exception e)
        {
            Console.WriteLine("Exception detected:" + e);
        } 
    }
}
