namespace a_array;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        int[] myarray = {128,12,34,56,78,89,11};
        Console.WriteLine("Minimun value " + myarray.Min());
        Console.WriteLine("Maximun value " + myarray.Max());
        Console.WriteLine("Sum value " + myarray.Sum());
        Console.WriteLine("Average value " + myarray.Average());
    }
}