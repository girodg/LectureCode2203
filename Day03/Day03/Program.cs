using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Day03
{
    internal class Program
    {

        static Random randy = new Random();

        static void Main(string[] args)
        {
            #region Arrays
            float cheeseburgerPrice = 1.99F;
            string cheeseBurger = "Cheesy Burger";

            float[] menuPrices = { 1.99F, 0.99F, 1.50F };
            string[] menuItems = { "Cheesy Burger", "Frenchy Fries", "Shaky Shake" };
            string item = menuItems[0];
            #endregion

            #region Creating and Adding
            Dictionary<string, float> menu = new Dictionary<string, float>()
            {
                //key-value pair
                {"Cheesy Burger", 1.99F }
            };
            //Add method. may throw an exception
            menu.Add("Frenchy Fries", 0.99F);

            //[ ]. will not throw an exception
            menu["Shaky Shake"] = 1.50F;

            #endregion

            #region Looping
            foreach (var menuitem in menu)
            {
                Console.WriteLine($"{menuitem.Value,10:C2} {menuitem.Key}");
            }
            #endregion

            #region Challenge 1
            Dictionary<string, double> pg2 = new()
            {
                { "John", GetGrade() },
                { "Agustin", GetGrade() },
                { "Tevin", GetGrade() },
                { "Micah", GetGrade() },
                { "Glenn", GetGrade() },
                { "Vargas", GetGrade() },
                { "Jonathan", GetGrade() },
                { "Michael", GetGrade() }
            };
            pg2.Add("Martin", GetGrade());
            pg2.Add("Alexander", GetGrade());
            pg2.Add("Darius", GetGrade());
            pg2.Add("Sashka", GetGrade());
            pg2["Joyce"] = GetGrade();
            pg2["Brandon"] = GetGrade();
            pg2["Connor"] = GetGrade();
            pg2["Jesse"] = GetGrade();
            pg2["Miguel"] = GetGrade();
            pg2["Isobel"] = GetGrade();
            pg2["Japhet"] = GetGrade();
            pg2["Tyler"] = GetGrade();

            #endregion

            #region Challenge 2

            PrintGrades(pg2);
            #endregion

            #region Removing
            Console.WriteLine("-------REMOVING ITEMS--------");
            string itemToRemove = "Chicken Nuggets";
            bool wasRemoved = menu.Remove(itemToRemove);
            if(wasRemoved)
                Console.WriteLine($"{itemToRemove} was removed.");
            else
                Console.WriteLine($"{itemToRemove} was not found.");
            #endregion

            #region Challenge 3
            DropStudent(pg2);
            #endregion

            #region Checking Keys, Getting Values
            string menuItem = "Frenchy Fries";
            if (menu.ContainsKey(menuItem))
            {
                float price = menu[menuItem];
                Console.WriteLine($"{menuItem} costs {price}");
            }
            //OR use TryGetValue
            if (menu.TryGetValue(menuItem, out float menuPrice))
            {
                menu[menuItem] = menuPrice + 2;
                Console.WriteLine($"{menuItem} now costs {menu[menuItem]}. Thanks Canada.");
            }
            #endregion
            #region Challenge 4
            CurveStudent(pg2);

            PrintGrades(new Dictionary<string,double>(pg2.OrderByDescending(k => k.Value)));
            #endregion
        }

        private static void CurveStudent(Dictionary<string, double> pg2)
        {
            Console.WriteLine("-----------CURVING STUDENT------------");
            Console.Write("Enter the student's name: ");
            string student = Console.ReadLine();
            if (pg2.TryGetValue(student, out double grade))
            {
                //? - ternary operator
                grade = (grade < 95) ? grade + 5 : 100;
                pg2[student] = grade;//overwrite the old value
                Console.WriteLine($"{student} was curved to {grade}.");
            }
            else
                Console.WriteLine($"{student} evaded correction.");
        }

        private static void DropStudent(Dictionary<string, double> pg2)
        {
            Console.WriteLine("-----------DROPPING STUDENT------------");
            Console.Write("Enter the student's name: ");
            string student = Console.ReadLine();
            bool wasDropped = pg2.Remove(student);
            if(wasDropped)
                Console.WriteLine($"{student} was eliminated.");
            else
                Console.WriteLine($"{student} evaded detection.");
        }

        static void PrintGrades(Dictionary<string, double> grades)
        {
            Console.ReadKey();
            Console.WriteLine("-------------GRADES-----------");
            foreach (var student in grades)
            {
                double grade = student.Value;
                if (grade < 59.5)      Console.BackgroundColor = ConsoleColor.Red;
                else if (grade < 69.5) Console.ForegroundColor = ConsoleColor.DarkYellow;
                else if (grade < 79.5) Console.ForegroundColor = ConsoleColor.Yellow;
                else if (grade < 89.5) Console.ForegroundColor = ConsoleColor.DarkCyan;
                else                   Console.ForegroundColor = ConsoleColor.Green;

                Console.Write($"{student.Value,10:N2}");
                Console.ResetColor();
                Console.WriteLine($" {student.Key}");
            }
        }

        static double GetGrade()
        {
            return randy.NextDouble() * 100;
        }
    }
}
