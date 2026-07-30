namespace a_delegate;
#nullable disable

public delegate void MyDel(string name0);
class Program
{
    public static void displayName(string name)
    {
        Console.WriteLine("Hello" + name);
    }
    static void Main(string[] args)
    {
        MyDel di= new MyDel(displayName);
        di("Sanothimi");
    }
}
