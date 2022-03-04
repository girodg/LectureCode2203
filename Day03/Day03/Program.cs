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
        }

        static double GetGrade()
        {
            return randy.NextDouble() * 100;
        }
    }
}
