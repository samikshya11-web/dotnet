namespace c_user_define_exception;
#nullable disable
class InValidVoter : Exception
{
    public InValidVoter(string str) : base(message) {}
}
class Program
{
    static void ageValidator(int age)
    {
        if(age <18)
        {
            throw new InValidVoter("You are  not eligible to get your voter Id by age");
        }
        else
        {
            throw new InValidVoter("You are eligible to get your voter Id by age");
        }
    }
     }
          public static void Main(string[] args)
    {
        Console.WriteLine("Enter your age :");
        int a = Convert.ToInt32(Console.ReadLine());
        try
        {
            ageValidator(a);
        }catch (InValidVoter a)
        {
            Console.WriteLine(a);
        }
    }
