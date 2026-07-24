namespace c_abstract;
#nullable disable
abstract class MyClass
{
    public abstract void calculate(double a);
}
class SubOne : MyClass
{
    public override void calculate(double a)
    {
        Console.WriteLine("Square root =" + Math.Sqrt(a));
    }
}

class SubTwo : MyClass
{
    public override void calculate(double a)
    {
        Console.WriteLine("Square  =" + (a*a));
    }
}
class SubThree : MyClass
{
    public override void calculate(double a)
    {
        Console.WriteLine("Cube = "+ (a*a*a));
    }
}

class Program
{
    static void Main(string[] args)
    {
        SubOne obj1 = new SubOne();
        SubTwo obj2 = new SubTwo();
        SubThree obj3 = new SubThree();

        obj1.calculate(9);
        obj2.calculate(9);
        obj3.calculate(9);
        
    }
}
