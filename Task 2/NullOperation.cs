// NullOperations.cs
public class NullOperations
{
    public void PerformNullChecks()
    {
        // Step 1: Declare username and assign null
        string username = null;

        // Step 2: Ternary Operator check
        string message = (username == null) ? "Username is not available" : username;
        Console.WriteLine(message);

        // Step 3: Null-Coalescing Operator
        Console.WriteLine(username ?? "Username is not available");

        // Step 4: Null-Coalescing Assignment Operator
        username ??= "DefaultUser";
        Console.WriteLine("Updated username: " + username);
    }
}
