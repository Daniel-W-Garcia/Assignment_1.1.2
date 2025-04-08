namespace Assignment1._1._2;


public class Functions
{
    private static double[] CumulativeSumMethod(double[] array)
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

    private static double[] CreateNaturalNumbers()
    {
        double[] naturalNumbers = new double[10];
        for (int i = 0; i < naturalNumbers.Length; i++)
        {
            naturalNumbers[i] = i + 1;
        }
        return naturalNumbers;
    }
    private static double[] naturalNumberArray = CreateNaturalNumbers();

    double[] _cumSum = CumulativeSumMethod(naturalNumberArray);

    public void PrintCumulativeSum()
    {
        Console.WriteLine($"Hello, here are the 1st 10 natural numbers {string.Join(", ", naturalNumberArray)}");
        
        Console.WriteLine($"Here is the running total: {string.Join(", ", _cumSum)}");
        
        Console.WriteLine($"Here is the total only: {_cumSum[_cumSum.Length - 1]}");
    }
}