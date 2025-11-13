// Program.cs
class Program
{
    static void Main(string[] args)
    {
        // 1. Try-Catch-Finally for number conversion
        try
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + number);
        }
        catch
        {
            Console.WriteLine("Invalid number format");
        }
        finally
        {
            Console.WriteLine("Program Executed");
        }

        // 2. Password validation with throw
        try
        {
            Console.WriteLine("\nEnter your password:");
            string password = Console.ReadLine();

            if (password.Length < 6)
            {
                throw new Exception("Password must be at least 6 characters.");
            }
            else
            {
                Console.WriteLine("Password satisfied the requirement");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
