using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLibrary
{
    public class Polygon : Shape
    {
        public Polygon(List<Point> pts) : base(pts) { }

        public override void Draw(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            for (int i = 1; i < Points.Count; i++)
                Graphics.PlotLine(Points[i - 1].X, Points[i - 1].Y, Points[i].X, Points[i].Y);

            Point p1 = Points[0], p2 = Points[Points.Count - 1];
            Graphics.PlotLine(p1.X, p1.Y, p2.X, p2.Y);

            base.Draw(ConsoleColor.Yellow);
        }
    }
}
