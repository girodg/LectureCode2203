using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLibrary
{
    public class Rectangle : Shape
    {
        public bool IsClosed { get; set; }
        public Rectangle(List<Point> pts, bool isClosed = true) : base(pts)
        {
            IsClosed = isClosed;
            //if ((IsClosed && Points.Count != 3) || (!IsClosed && Points.Count != 4))
            if(Points.Count != 4)
                throw new Exception("Rectangles can only have 4 points.");

        }
        public override void Draw(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            for (int i = 1; i < Points.Count; i++)
            {
                //if (IsClosed && i == Points.Count - 1)
                //{
                //    //draw from pt[2] to pt[0]
                //}
                //else
                //{
                //    //draw from pt[i-1] to pt[i]
                //}

                Graphics.PlotLine(Points[i-1].X, Points[i - 1].Y, Points[i].X, Points[i].Y);
            }

            if (IsClosed)
            {
                Point p1 = Points[0], p2 = Points[Points.Count-1];
                Graphics.PlotLine(p1.X, p1.Y, p2.X, p2.Y);
            }

            base.Draw(ConsoleColor.Yellow);
        }
    }
}
