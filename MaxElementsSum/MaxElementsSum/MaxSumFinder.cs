namespace MaxElementsSum
{
    public class MaxSumFinder
    {
        public HashSet<int> FailedLines { get; set; } = new HashSet<int>();

        public (int Line, double Sum) MaxSumPair = (-1, 0);
        

        public (int Line, double Sum) CalculateMaxSum(string filePath)
        {
            if (!File.Exists(filePath))
            { 
                Console.WriteLine($"Provided file {filePath} can not be found");
                return (-1, 0);
            }

            FailedLines.Clear();
            var numbersSums = new List<(int Line, double Sum)>();

            var lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                string? line = lines[i];
                var lineNumbers = line.Split(',')
                    .Select(d =>
                    {
                        if (!double.TryParse(d, out var number))
                            FailedLines.Add(i);

                        return number;
                    }).Sum();

                if (!FailedLines.Contains(i))
                    numbersSums.Add((i, lineNumbers));
            }

            return numbersSums.OrderByDescending(kv => kv.Sum).First();
        }
    }
}
