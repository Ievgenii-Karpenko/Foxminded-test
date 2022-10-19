using MaxElementsSum;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath;
            if (args.Length > 0)
                filePath = args[0];
            else
            {
                Console.WriteLine("Provide file to file with data:");
                filePath = Console.ReadLine();
            }

            var maxSumFinder = new MaxSumFinder();
            var max = maxSumFinder.CalculateMaxSum(filePath);

            var failedLines = string.Join(", ", maxSumFinder.FailedLines.Select(l => l.ToString()));

            Console.WriteLine($"Muximum sum of elements is {max.Sum} in line {max.Line}");
            Console.WriteLine($"Failed lines: {failedLines}");
        }
    }
}



