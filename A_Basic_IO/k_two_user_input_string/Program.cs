namespace k_two_user_input_string;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number :");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number :");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum is " + (a+b));
    }
}
