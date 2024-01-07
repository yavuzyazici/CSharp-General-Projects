using IntegerBinarySum;

//Project:Write a console application that takes the sum of n integer binary numbers entered from the screen, prints the sum if the numbers are different from each other, and prints the square of the sum if the numbers are the same.
Start:
Controller controller = new Controller();

Console.WriteLine("Enter numbers with a space between them and an even number (Example: 2 3 1 5 2 5 3 3)");

string input = Console.ReadLine();

if (!controller.PcsPair(input))
{
    controller.Clean();
    goto Start;
}

controller.BinarySum(input);