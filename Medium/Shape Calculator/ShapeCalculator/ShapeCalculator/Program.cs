using AreaCalculator;

Start:

IController controller = new IController();
IController.ICircle circle = new IController.ICircle();
IController.ITriangle triangle = new IController.ITriangle();
IController.ISquare square = new IController.ISquare();
IController.IRectangle rectangle = new IController.IRectangle();

Console.WriteLine("Select the shape you want to process:");
Console.WriteLine("For circle (1)");
Console.WriteLine("For triangle (2)");
Console.WriteLine("For square (3)");
Console.WriteLine("For rectangle (4)");

string input = Console.ReadLine();

switch (input)
{
    case "1":
        circle.Circle();
        break;
    case "2":
        triangle.Triangle();
        break;
    case "3":
        square.Square();
        break;
    case "4":
        rectangle.Rectangle();
        break;
    default:
        Console.WriteLine("Wrong input");
        controller.Clear();
        goto Start;
}