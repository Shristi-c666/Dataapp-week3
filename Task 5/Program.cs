// Program.cs
class Program
{
    static void Main(string[] args)
    {
        // 1. For Loop — Sum from 1 to N
        Console.WriteLine("Enter a number (N):");
        int N = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= N; i++)
        {
            sum += i;
        }
        Console.WriteLine("Sum from 1 to " + N + " is: " + sum);

        // 2. While Loop — Print 1 to 20, skip multiples of 4, stop at 15
        Console.WriteLine("\nNumbers from 1 to 20 (skip multiples of 4, stop at 15):");
        int num = 1;
        while (num <= 20)
        {
            if (num == 15)
            {
                Console.WriteLine("Stopped at 15");
                break;
            }

            if (num % 4 == 0)
            {
                num++;
                continue;
            }

            Console.WriteLine(num);
            num++;
        }

        // 3. Foreach Loop — Sum of elements in an array
        int[] numbers = { 2, 4, 6, 8, 10 };
        int total = 0;

        foreach (int value in numbers)
        {
            total += value;
        }

        Console.WriteLine("\nSum of array elements: " + total);
    }
}
