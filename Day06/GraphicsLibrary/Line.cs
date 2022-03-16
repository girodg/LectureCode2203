using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLibrary
{
    public class Line : Shape
    {
        public Line(List<Point> pts) : base(pts)
        {
            if (Points.Count != 2)
                throw new Exception("Lines can only have 2 points.");
        }

        public override void Draw(ConsoleColor color)
        {
            Point p1 = Points[0], p2 = Points[1];

            Console.BackgroundColor = color;
            Graphics.PlotLine(p1.X, p1.Y, p2.X, p2.Y);

            base.Draw(ConsoleColor.Green);//extending the base behavior
        }
    }
}
