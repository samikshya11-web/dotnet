namespace b_exception;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[5];
        try
        {
           nums[10] = 90;
           Console.WriteLine(nums[10]); 
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine("Index out of bounds:" + e);
        }
        
    }
}
