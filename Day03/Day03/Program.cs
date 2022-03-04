using System;
using System.Collections.Generic;

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
            foreach (var menuItem in menu)
            {
                Console.WriteLine($"{menuItem.Value,10:C2} {menuItem.Key}");
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
