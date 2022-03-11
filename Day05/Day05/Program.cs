using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Day05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 13, 7, 1, 5, 10, 42 };
            Print(numbers);
            Swap(numbers, 1, 2);
            Print(numbers);

            List<int> nums = numbers.ToList();
            Split(nums);
            int number = 42;
            int indexOf = LinearSearch(nums, number);
            if(indexOf != -1)
                Console.WriteLine($"{number} is found at index {indexOf}");
            else
                Console.WriteLine($"{number} was not found."); 
            number = 100;
            indexOf = LinearSearch(nums, number);
            if (indexOf != -1)
                Console.WriteLine($"{number} is found at index {indexOf}");
            else
                Console.WriteLine($"{number} was not found.");

            string s1 = "Batman", s2 = "Aquaman";
            int compResult = s1.CompareTo(s2);
            if (compResult == 0) Console.WriteLine($"{s1} EQUALS {s2}");
            else if(compResult > 0) Console.WriteLine($"{s1} GREATER THAN {s2}");
            else if (compResult < 0) Console.WriteLine($"{s1} LESS THAN {s2}");

            #region Recursion
            Console.ReadKey();
            Console.CursorVisible = false;
            //Method(5);
            int bound = Math.Min(Console.WindowHeight, Console.WindowWidth);
            int x1 = 0, y1 = 0;

            Boxes(x1, y1, bound - 1, bound / 2);
            #endregion

            Console.ResetColor();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Console.CursorVisible = true;
        }

        static int LinearSearch(List<int> numsToSearch, int numberToFind)
        {
            int foundIndex = -1;
            for (int i = 0; i < numsToSearch.Count; i++)
            {
                if (numberToFind == numsToSearch[i])
                {
                    foundIndex = i;
                    break;
                }
            }
            return foundIndex;
        }

        private static void Split(List<int> nums)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int mid = nums.Count / 2;
            for (int i = 0; i < nums.Count; i++)
            {
                if(i < mid) left.Add(nums[i]);
                else        right.Add(nums[i]);
            }
            Console.WriteLine("--------LEFT------");
            foreach (var item in left)
                Console.WriteLine(item);
            Console.WriteLine("--------RIGHT------");
            foreach (var item in right)
                Console.WriteLine(item);
        }

        private static void Print(int[] numbers)
        {
            foreach (var item in numbers)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        #region Sorting Methods
        static void Swap(int[] nums, int ndx1, int ndx2)
        {
            int temp = nums[ndx1];
            nums[ndx1] = nums[ndx2];
            nums[ndx2] = temp;
        }
        #endregion

        #region Recursion
        static Random randy = new Random();
        private static void Boxes(int x1, int y1, int bound,int stop)
        {
            //our exit condition (we stop looping when...
            if (x1 > stop) return;

            GetColor();
            //Debug.WriteLine($"{x1},{y1} {bound} {stop}");
            DrawBox(x1, y1, bound);

            Boxes(x1 + 1, y1 + 1, bound - 2, stop);//recursively call Boxes

            //only get here when the exit condition has happened
            Console.BackgroundColor = ConsoleColor.Black;
            DrawBox(x1, y1, bound);
        }

        private static void GetColor()
        {
            do
                Console.BackgroundColor = (ConsoleColor)randy.Next(16);
            while (Console.BackgroundColor == ConsoleColor.Black);
        }

        private static void DrawBox(int x1, int y1, int bound)
        {
            Horizontal(x1, y1, x1 + bound);
            Horizontal(x1, y1 + bound, x1 + bound);
            Vertical(x1, y1, y1 + bound);
            Vertical(x1 + bound, y1, y1 + bound);
            Thread.Sleep(50);//to slow down the drawing
        }

        private static void Vertical(int x1, int y1, int y2)
        {
            for (int i = y1; i < y2; i++)
            {
                Console.SetCursorPosition(x1, i);
                Console.Write(' ');
            }
        }

        private static void Horizontal(int x1, int y1, int x2)
        {
            Console.SetCursorPosition(x1, y1);
            for (int i = x1; i <= x2; i++)
            {
                Console.Write(' ');
            }
        }

        static void Method(int num)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        #endregion
    }
}
