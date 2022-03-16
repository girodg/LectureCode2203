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
    }
}
