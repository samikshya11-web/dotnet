namespace a_array;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        int[] myarray = {128,12,34,56,78,89,11};
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
