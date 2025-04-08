namespace Assignment1._1._2;


public class Functions
{
    
    public static double[] CumulativeSumMethod(double[] array)
    {
        double[] cumSum = new double[array.Length];
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            cumSum[i] = sum;
        }
        return cumSum;
    }

    public static bool IsEqual(int x, int y)
    {
        bool isEqual = x == y;
        return isEqual;
    }
    
    public void PrintIsEqual(int x, int y, bool isEqual)
    {
        if (isEqual)
        {
            Console.WriteLine($"Hello, your numbers ({x}, and {y}) are equal");
        }
        else
        {
            Console.WriteLine($"Hello, your numbers ({x}, and {y}) are not equal");
        }
    }
    
    static double[] _data = { 1, 2, 3, 4 };
    double[] _cumSum = CumulativeSumMethod(_data); // {1, 3, 6, 10}

    public void PrintCumulativeSum()
    {
        Console.WriteLine($"Here is the running total: {string.Join(", ", _cumSum)}");
        Console.WriteLine($"Here is the total only: {_cumSum[_cumSum.Length - 1]}");
    }
}