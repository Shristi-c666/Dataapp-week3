// Program.cs
class Program
{
    static void Main(string[] args)
    {
        Operators op = new Operators();

        // Test the methods
        op.Add(10, 5);           // Sum: 15
        op.Subtract(10, 5);      // Difference: 5
        op.Multiply(10, 5);      // Product: 50
        op.Divide(10, 5);        // Division: 2
        op.Divide(10, 0);        // Division by zero is not allowed

        op.OddEvenFinder(10);    // Even Number
        op.OddEvenFinder(7);     // Odd Number
    }
}
