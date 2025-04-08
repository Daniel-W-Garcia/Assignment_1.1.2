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
    
    double[] _cumSum = CumulativeSumMethod(naturalNumberArray);
    
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

    public double Addition(int x, int y)
    {
        return (double) x + y;
    }
    
    public double Subtraction(int x, int y)
    {
        return (double) x - y;
    }

    public double Multiplication(int x, int y)
    {
        return (double) x * y;
    }

    public double Division(int x, int y)
    {
        return (double)x / y;
    }

    public static bool IsEqual(int x, int y)
    {
        bool isEqual = x == y;
        return isEqual;
    }
    public void PrintCumulativeSum()
    {
        Console.WriteLine($"Hello, here are the 1st 10 natural numbers {string.Join(", ", naturalNumberArray)}");
        
        Console.WriteLine($"Here is the running total: {string.Join(", ", _cumSum)}");
        
        Console.WriteLine($"Here is the total only: {_cumSum[_cumSum.Length - 1]}");
    }
}