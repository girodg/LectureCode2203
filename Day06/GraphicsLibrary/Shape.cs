using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLibrary
{
    public class Shape : IShape
    {
        #region Fields
        private List<Point> _pts = new List<Point>();
        #endregion
        #region Properties

        public ShapeTypes MyShape { get; set; } = ShapeTypes.Unknown;
        public List<Point> Points
        {
            //accessor
            //public List<Point> GetPoints() {return _pts;}
            get { return _pts; }

            //mutator
            //public void SetPoints(List<Point> value) {_pts = value;}
            set
            {
                if (value != null)
                    this._pts = value;
            }
        }
        #endregion
        #region Constructors
        //public Shape()//default constructor. no parameters
        //{
        //    //initialize the data
        //    Points = new List<Point>();
        //}
        public Shape(List<Point> points)
        {
            Points = points;//assign the parameter to the property/field
            //points = Points;//backwards!!!! do NOT DO this!
        }
        #endregion

        #region Methods
        //an instance method
        //there is a HIDDEN parameter called 'Shape this'
        public virtual void Draw(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            foreach (var pt in Points)
            {
                Console.SetCursorPosition(pt.X, pt.Y);
                Console.Write(' ');
            }
            Console.ResetColor();
        }
        #endregion
    }
}
