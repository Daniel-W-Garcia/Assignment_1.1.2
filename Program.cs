using Assignment1._1._2;

Functions functions = new();
UserInput userInput = new();

Console.WriteLine("Hello User, Welcome to Assignment 1.1.2");
Console.WriteLine("""
                  Please select an option:
                  1. Compare Two Numbers
                  2. Print Cumulative Sum
                  3. Add 2 Numbers
                  4. Subtract 2 Numbers
                  5. Multiply 2 Numbers
                  6. Divide 2 Numbers
                  """);

int userChoice = int.Parse(Console.ReadLine());

switch (userChoice)
{
    case 1:
        userInput.CompareTwoNumbers();
        break;
    case 2:
        functions.PrintCumulativeSum();
        break;
    case 3:
        userInput.PrintAdditionSum();
        break;
    case 4:
        userInput.PrintSubtractionSum();
        break;
    case 5:
        userInput.PrintMultiplicationSum();
        break;
    case 6:
        userInput.PrintDivisionSum();
        break;
    default:
        Console.WriteLine("Invalid Choice");
        break;
}