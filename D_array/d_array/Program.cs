namespace d_array;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        string[] myarray = {Hari,Sita,Gita,Ram};
        Console.WriteLine("Array before sorting");
        foreach(var item in myarray)
        {
            Console.WriteLine(item);
        }
        Array.Sort(myarray );
        Array.Reverse(myarray);
        Console.WriteLine("Array after sorting");
        foreach(var item in myarray)
        {
            Console.WriteLine(item);
        }
        
    }
}