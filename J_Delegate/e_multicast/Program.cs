namespace e_multicast;
#nullable disable
public delegate void Mydel(int a , int b);

class Calc
{
    public  void add(int a , int b)
    {
        Console.WriteLine("The sum =" + (a+b));
    }
     public  void mul(int a , int b)
    {
        Console.WriteLine("The product =" + (a*b));
    }
    static void Main(string[] args)
    {
        Calc obj = new Calc();
        Mydel d1 = new Mydel(obj.add);
        Mydel d2 = new Mydel(obj.mul);
        d1 = d1 + d2;
        d1(10,20);
       
    }
}
