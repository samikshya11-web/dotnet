namespace a_virtual;
#nullable disable

class SuperClass
{
    public virtual int calc(int a , int b)
    {
        return (a+b);
    }
}
class SubClass : SuperClass
{
    public override int calc(int a , int b)
    {
        return(a+b+5);
    }
}
class Program
{
    static void Main(string[] args)
    {
        SubClass obj = new SubClass();
        Console.WriteLine("ReDefined result = " + obj.calc(10,20));
    }
}
