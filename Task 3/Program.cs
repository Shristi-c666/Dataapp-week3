// Program.cs
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        // Using if-else-if
        if (age < 13)
        {
            Console.WriteLine("Child");
        }
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("Teenager");
        }
        else
        {
            Console.WriteLine("Adult");
        }

        // Using switch expression
        switch (age)
        {
            case < 13:
                Console.WriteLine("Switch result: Child");
                break;
            case >= 13 and <= 19:
                Console.WriteLine("Switch result: Teenager");
                break;
            default:
                Console.WriteLine("Switch result: Adult");
                break;
        }
    }
}
