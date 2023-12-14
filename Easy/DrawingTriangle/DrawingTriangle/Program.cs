int row;
do
{
    Console.Write("Enter the number of rows of the triangle:");
} while (!int.TryParse(Console.ReadLine(), out row) || row <= 1);

Draw draw = new Draw();

int input;
do
{
    Console.WriteLine("Press 1 for full inside and 2 for empty inside");
} while (!int.TryParse(Console.ReadLine(), out input) || (input != 1 && input != 2));

switch (input)
{
    case 1:
        draw.DrawTriangleFill(row);
        break;
    case 2:
        draw.DrawTriangleUnfill(row);
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}

public class Draw
{
    public void DrawTriangleUnfill(int row)
    {
        int gaps = row;
        int gapsin = 0;
        int stars = 1;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < gaps; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < stars; j++)
            {
                Console.Write("*");
                for (int k = 1; k < gapsin; k++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            stars = 2;
            gapsin += 2;
            gaps--;
            if (row == i+2)
            {
                stars = row*2-1;
                gapsin = 0;
            }
        }
    }
    public void DrawTriangleFill(int row)
    {
        int gaps = row;
        int stars = 1;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < gaps; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < stars; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            stars += 2;
            gaps--;
        }
    }
}
