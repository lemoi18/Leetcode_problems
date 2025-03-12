

public static class PrintHelper
{
    public static void PrintHeader(string problem)
    {
        Console.WriteLine($"{problem} {new string('-', 10)}");
        Console.WriteLine("\n");

    }

        public static void Print(string message)
    {
        Console.WriteLine(message);
    }
}
