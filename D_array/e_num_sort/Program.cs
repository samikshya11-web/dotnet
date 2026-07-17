namespace e_array;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        int[] myarray = {128,12,34,56,78,89,11};
        Console.WriteLine("Enter a nummber to search it in array:");
        int num = int.Parse(Console.ReadLine());
        bool found = false;

        for( int i= 0; i< myarray.Length; i++)
        {
            if(num == myarray[i])
            {
                found =true;
                break;
            }
        }
        if(found ==true)
        {
            Console.WriteLine("Number found.");
        }
        else
        {
            Console.WriteLine("Number not found");
        }
    }
}