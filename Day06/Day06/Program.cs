using GraphicsLibrary;
using System;
using System.Collections.Generic;

namespace Day06
{
    internal class Program
    {
        //an INSTANCE field.
        public int _count = 10;

        //static means there is no instance. Tied to the class.
        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.WriteLine(prog._count);

            string[] options = { "1. Draw Crosshairs", "2. Draw Diagonals", "3. Draw Random", "4. Draw Shapes", "5. Exit" };

            Shape box = new Shape();//calling the default constructor
            box.Points = new List<Point>();//calls the set

            Shape line = new Shape();
            line.Points = new List<Point>();
            Console.WriteLine($"# of points in my shape: {box.Points.Count}");//calls the get

            int selection;
            do
            {
                Input.ReadChoice("Choice: ", options, out selection);
                Console.Clear();
                switch (selection)
                {
                    case 1:
                        Graphics.DrawCrosshairs();
                        Console.ReadKey();
                        break;
                    case 2:
                        Graphics.DrawDiagonals();
                        Console.ReadKey();
                        break;
                    case 3:
                        Graphics.DrawRandom();
                        Console.ReadKey();
                        break;
                    case 4:
                        //Classes Lecture:
                        //Point: x,y
                        //Shape (base): list of pts, Color. Draw(): only draws pts
                        List<Point> points = Graphics.GetRandomPoints(15);
                        Shape shape = new Shape(points);
                        shape.Draw(ConsoleColor.Green);

                        Line l1 = new Line(Graphics.GetRandomPoints(2));

                        //Inheritance/Polymorphism Lectures:
                        //Line: 2 pts. throw exception if not 2. Draw(): draws 1 line then calls base
                        //Rectangle: IsClosed. 4 pts if not closed (throw exception). 3pts if closed (throw exception). Draw(): draws shape then calls base
                        //Polygon: n pts
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (selection != 5);
        }
    }
}
