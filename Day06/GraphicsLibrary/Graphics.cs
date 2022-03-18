using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLibrary
{
    public static class Graphics
    {

        public static IShape GenerateShape(ShapeTypes typeOfShape)
        {
            switch (typeOfShape)
            {
                case ShapeTypes.Unknown:
                    return new Shape(Graphics.GetRandomPoints(10));
                case ShapeTypes.Linear:
                    return new Line(Graphics.GetRandomPoints(2));
                case ShapeTypes.Boxy:
                    return new Rectangle(Graphics.GetRandomBox());
                case ShapeTypes.Triangular:
                    return null;
                case ShapeTypes.Poly:
                    return new Polygon(Graphics.GetRandomPoints(10));
                default:
                    break;
            }
            return null;
        }

        public static void DrawCrosshairs()
        {
            int x0 = 0, x1 = Console.WindowWidth / 2, x2 = Console.WindowWidth - 1;
            int y0 = 0, y1 = Console.WindowHeight / 2, y2 = Console.WindowHeight - 1;

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Graphics.PlotLine(x0, y1, x2, y1);
            Graphics.PlotLine(x1, y0, x1, y2);
            Console.ResetColor();
        }

        public static void DrawDiagonals()
        {
            int x0 = 0, x1 = Console.WindowWidth - 1;
            int y0 = 0, y1 = Console.WindowHeight - 1;

            Console.BackgroundColor = ConsoleColor.Yellow;
            Graphics.PlotLine(x0, y0, x1, y1);
            Graphics.PlotLine(x1, y0, x0, y1);
            Console.ResetColor();
        }

        public static void DrawRandom()
        {
            int x0 = 0, x1 = Console.WindowWidth - 1;
            int y0 = 0, y1 = Console.WindowHeight - 1;
            Random randy = new Random();

            for (int i = 0; i < 300; i++)
            {
                Console.BackgroundColor = (ConsoleColor)randy.Next(16);
                x0 = randy.Next(Console.WindowWidth);
                x1 = randy.Next(Console.WindowWidth);
                y1 = randy.Next(Console.WindowHeight);
                y0 = randy.Next(Console.WindowHeight);

                Graphics.PlotLine(x0, y0, x1, y1);
            }
            Console.ResetColor();
        }

        public static void PlotLine(int x0, int y0, int x1, int y1)
        {
            if (Math.Abs(y1 - y0) < Math.Abs(x1 - x0))
            {
                if (x0 > x1)
                    PlotLineLow(x1, y1, x0, y0);
                else
                    PlotLineLow(x0, y0, x1, y1);
            }
            else
            {
                if (y0 > y1)
                    PlotLineHigh(x1, y1, x0, y0);
                else
                    PlotLineHigh(x0, y0, x1, y1);
            }
        }

        public static List<Point> GetRandomPoints(int numberOfPoints)
        {
            List<Point> pts = new List<Point>();
            Random randy = new Random();
            for (int i = 0; i < numberOfPoints; i++)
            {
                pts.Add(new Point() { X = randy.Next(Console.WindowWidth), Y = randy.Next(Console.WindowHeight) });
            }
            return pts;
        }

        public static List<Point> GetRandomBox()
        {
            List<Point> pts = new List<Point>();
            Random randy = new Random();
            Point p1 = new Point() { X=randy.Next(Console.WindowWidth), Y = randy.Next(Console.WindowHeight) };
            pts.Add(p1);
            int width = randy.Next(1,Console.WindowWidth - p1.X);
            int height = randy.Next(1,Console.WindowHeight - p1.Y);
            pts.Add(new Point() { X = p1.X + width, Y = p1.Y });
            pts.Add(new Point() { X = p1.X + width, Y = p1.Y + height });
            pts.Add(new Point() { X = p1.X, Y = p1.Y + height });
            return pts;
        }

        private static void PlotLineLow(int x0, int y0, int x1, int y1)
        {
            int dx = x1 - x0;
            int dy = y1 - y0;
            int yi = 1;
            if (dy < 0)
            {
                yi = -1;
                dy = -dy;
            }
            int D = 2 * dy - dx;
            int y = y0;
            for (int x = x0; x <= x1; x++)
            {
                plot(x, y);
                if (D > 0)
                {
                    y = y + yi;
                    D = D - 2 * dx;
                }
                D = D + 2 * dy;
            }
        }
        private static void PlotLineHigh(int x0, int y0, int x1, int y1)
        {
            int dx = x1 - x0;
            int dy = y1 - y0;
            int xi = 1;
            if (dx < 0)
            {
                xi = -1;
                dx = -dx;
            }
            int D = 2 * dx - dy;
            int x = x0;
            for (int y = y0; y <= y1; y++)
            {
                plot(x, y);
                if (D > 0)
                {
                    x = x + xi;
                    D = D - 2 * dy;
                }
                D = D + 2 * dx;
            }
        }

        private static void plot(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }
    }
}
