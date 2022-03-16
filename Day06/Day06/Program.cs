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

            Shape box = new Shape(Graphics.GetRandomPoints(5));//calling the default constructor
            box.Points = new List<Point>();//calls the set

            Shape line = new Shape(Graphics.GetRandomPoints(2));
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

                        //Upcasting: from derived to base
                        //ALWAYS safe
                        Shape myShape = l1;//copies the memory address of the object in the heap
                        myShape = shape;

                        //Downcasting: from base to derived
                        //NOT SAFE! must cast to safety!
                        //1. explicit cast
                        try
                        {
                            Line l2 = (Line)myShape;
                        }
                        catch (Exception)
                        {
                        }
                        //2. use the 'as' keyword
                        //if myShape is NOT a line, will store NULL in l3
                        Line l3 = myShape as Line;
                        if(l3 != null)
                        { }

                        //3. use pattern matching
                        if(myShape is Line l4)
                        { }

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
