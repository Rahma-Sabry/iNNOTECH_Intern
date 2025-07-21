namespace Task1_3_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i < n)
                        Console.Write(i + " ,");
                    else
                        Console.Write(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
