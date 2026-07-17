namespace c_classobj;
#nullable disable
class Student
{
    public int roll;
    public void displayRoll(int r)
    {
        

    roll = r;
    Console.WriteLine("Roll number = " + roll);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.roll = 430;
        s1.displayRoll(s1.roll);
        
    }
}
