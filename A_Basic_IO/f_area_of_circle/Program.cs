namespace f_area_of_circle;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.WriteLine($"Area of circle = {area:F2}");
    }
}
 