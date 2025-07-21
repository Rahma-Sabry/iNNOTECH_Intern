namespace Task1_2_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            var stopwatchforLOOP = System.Diagnostics.Stopwatch.StartNew();
            int sumForLoop = SumFromOneToNWithForLoop(n);
            stopwatchforLOOP.Stop();

            var stopwatchFormula = System.Diagnostics.Stopwatch.StartNew();
            int sumFormula = n * (n + 1) / 2;
            stopwatchforLOOP.Stop();

            Console.WriteLine($"Sum from 1 to {n} is {sumForLoop}");
            long nanoseconds = stopwatchforLOOP.ElapsedTicks * 1_000_000_000 / System.Diagnostics.Stopwatch.Frequency;
            Console.WriteLine($"Running time for For Loop: {nanoseconds} ns");

            Console.WriteLine($"Sum from 1 to {n} is {sumFormula}");
            long nanosecondsFormula = stopwatchFormula.ElapsedTicks * 1_000_000_000 / System.Diagnostics.Stopwatch.Frequency;
            Console.WriteLine($"Running time for Formula: {nanosecondsFormula} ns");
        }

        static int SumFromOneToNWithForLoop(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
