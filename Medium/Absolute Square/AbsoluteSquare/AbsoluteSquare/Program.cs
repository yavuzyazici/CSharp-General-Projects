using AbsoluteSquare;
using System;

Start:
Controller controller = new Controller();

Console.WriteLine("Enter numbers with a space between (Example: 52 43 61 15)");

string input = Console.ReadLine();

if (!controller.Check(input))
{
    controller.Clear();
    goto Start;
}

controller.Algorithm(input);