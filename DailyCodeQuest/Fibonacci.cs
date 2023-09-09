namespace DailyCodeQuest;

internal class Fibonacci
{
    public static void PrintFibonacci()
    {
        int input;
        do
        {
            Console.Write("Please enter a positive number: ");
        } while (!int.TryParse(Console.ReadLine(), out input) || input <= 0);

        var fibonacciSeries = GetFibonacci(input);

        if (fibonacciSeries != null)
        {
            for (int i = 0; i < fibonacciSeries.Count; i++)
            {
                Console.Write($"Term {i + 1} -> {fibonacciSeries[i]} , ");
            }
        }
        else
        {
            Console.WriteLine("Unable to generate Fibonacci series.");
        }
    }

    private static List<int>? GetFibonacci(int input)
    {
        try
        {
            if (input <= 0)
            {
                return new List<int>() { 0 };
            }

            List<int> fibonacciSeries = new List<int>() { 0, 1 };

            for (int i = 2; i < input; i++)
            {
                checked
                {
                    fibonacciSeries.Add(fibonacciSeries[^1] + fibonacciSeries[^2]);
                }
            }

            return fibonacciSeries;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Input is too large. Please enter a smaller number.");
            return null;
        }
    }
}
