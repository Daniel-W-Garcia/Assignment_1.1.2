using Assignment1._1._2;

Functions functions = new();
UserInput userInput = new();

Console.WriteLine("Hello User, Welcome to Assignment 1.1.2");
Console.WriteLine("What would you like to do? \n1. Compare Two Numbers \n2. Print Cumulative Sum ");

int userChoice = int.Parse(Console.ReadLine());

switch (userChoice)
{
    case 1:
        userInput.CompareTwoNumbers();
        break;
    case 2:
        functions.PrintCumulativeSum();
        break;
    default:
        Console.WriteLine("Invalid Choice");
        break;
}