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
        functions.PrintIsEqual(x, y, isEqual);
    }
}