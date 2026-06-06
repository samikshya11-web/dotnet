namespace c_display_user_input;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string? name = Console.ReadLine();
        Console.WriteLine("Your name is: " + name);
    }
}
