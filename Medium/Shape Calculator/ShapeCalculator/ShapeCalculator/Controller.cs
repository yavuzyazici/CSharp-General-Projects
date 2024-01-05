using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AreaCalculator.IController;

namespace AreaCalculator
{
    public class IController
    {
        public IController() { }

        public class ICircle : IController
        {
            public ICircle() { }

            public void Circle()
            {
            Back:
                Console.WriteLine("Enter the radius of the circle");
                string radius = Console.ReadLine();

                if (!IsChar(radius))
                {
                    Console.WriteLine("Wrong input");
                    Clear();
                    goto Back;
                }

                Console.WriteLine("Enter the operation you want to perform. For area calculation(1) For perimeter calculation(2)");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Area of the circle: " + CircleArea(radius));
                        break;
                    case "2":
                        Console.WriteLine("Perimeter of the circle: " + CirclePerimeter(radius));
                        break;
                    default:
                        Clear();
                        goto Back;
                }
            }

            public double CircleArea(string radius)
            {
                return Math.PI * (Convert.ToInt32(radius) * Convert.ToInt32(radius));
            }

            public double CirclePerimeter(string radius)
            {
                return 2 * Math.PI * Convert.ToInt32(radius);
            }

        }

        public class ITriangle : IController
        {
            public ITriangle() { }

            public void Triangle()
            {
            Back:
                Console.WriteLine("Enter the base of the triangle");
                string floor = Console.ReadLine();

                Console.WriteLine("Enter the height of the triangle");
                string height = Console.ReadLine();

                if (!IsChar(floor) || !IsChar(height))
                {
                    Console.WriteLine("Wrong input");
                    Clear();
                    goto Back;
                }

                Console.WriteLine("Enter the operation you want to perform. For area calculation(1)");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Area of the triangle: " + TriangleArea(floor, height));
                        break;
                    default:
                        Clear();
                        goto Back;
                }
            }

            public double TriangleArea(string floor, string height)
            {
                return (Convert.ToInt32(floor) * Convert.ToInt32(height)) / 2;
            }

        }

        public class ISquare : IController
        {
            public ISquare() { }

            public void Square()
            {
            Back:
                Console.WriteLine("Enter the side of the square");
                string side = Console.ReadLine();

                if (!IsChar(side))
                {
                    Console.WriteLine("Wrong input");
                    Clear();
                    goto Back;
                }

                Console.WriteLine("Enter the operation you want to perform. For area calculation(1) For perimeter calculation(2)");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Area of the square: " + SquareArea(side));
                        break;
                    case "2":
                        Console.WriteLine("Perimeter of the square: " + SquarePerimeter(side));
                        break;
                    default:
                        Clear();
                        goto Back;
                }
            }

            public double SquareArea(string side)
            {
                return Convert.ToInt32(side) * Convert.ToInt32(side);
            }

            public double SquarePerimeter(string side)
            {
                return Convert.ToInt32(side) * 4;
            }

        }

        public class IRectangle : IController
        {
            public IRectangle() { }

            public void Rectangle()
            {
            Back:
                Console.WriteLine("Enter the first side of the rectangle");
                string fside = Console.ReadLine();

                Console.WriteLine("Enter the second side of the rectangle");
                string sside = Console.ReadLine();

                if (!IsChar(fside) || !IsChar(sside))
                {
                    Console.WriteLine("Wrong input");
                    Clear();
                    goto Back;
                }

                Console.WriteLine("Enter the operation you want to perform. For area calculation(1) For perimeter calculation(2)");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Area of the rectangle: " + RectangleArea(fside,sside));
                        break;
                    case "2":
                        Console.WriteLine("Perimeter of the rectangle: " + RectanglePerimeter(fside,sside));
                        break;
                    default:
                        Clear();
                        goto Back;
                }
            }

            public double RectangleArea(string fside,string sside)
            {
                return Convert.ToInt32(fside) * Convert.ToInt32(sside);
            }

            public double RectanglePerimeter(string fside, string sside)
            {
                return (Convert.ToInt32(fside) * 2)+(Convert.ToInt32(sside)*2);
            }

        }

        public bool IsChar(string word)
        {
            foreach (char c in word)
            {
                if (Char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        public void Clear()
        {
            Thread.Sleep(500);
            Console.Clear();
        }
    }
}
