namespace Assignment1._1._2;

public class UserInput
{
    Functions functions = new();
    int x;
    int y;
    bool isEqual;

    public void CompareTwoNumbers()
    {
        Console.WriteLine("Hello, please enter your first number: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Hello, please enter your second number: ");
        y = int.Parse(Console.ReadLine());
        isEqual = Functions.IsEqual(x, y);
        PrintIsEqual(x, y, isEqual);
    }
    public void PrintAdditionSum()
    {
        Console.WriteLine("Please enter your first number: ");
        x = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter your second number: ");
        y = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"The sum of {x} and {y} is {functions.Addition(x, y)}");
    }

    public void PrintSubtractionSum()
    {
        Console.WriteLine("Please enter your first number: ");
        x = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter your second number: ");
        y = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"The sum of {x} and {y} is {functions.Subtraction(x, y)}");
    }

    public void PrintMultiplicationSum()
    {
        Console.WriteLine("Please enter your first number: ");
        x = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter your second number: ");
        y = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"The product of {x} and {y} is {functions.Multiplication(x, y)}");
    }

    public void PrintDivisionSum()
    {
        Console.WriteLine("Please enter your first number: ");
        x = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter your second number: ");
        y = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"The result of {x} divided by {y} is {functions.Division(x, y):F2}");
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

    public void CloseApplication()
    {
        Console.WriteLine("Thank you for using this application");
    }
}