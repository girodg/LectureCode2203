using System;
using System.Collections.Generic;
using System.Linq;

namespace Day02
{
    internal class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            string[] names = new string[] { "Batman", "Joker", "Superman" };
            List<string> DC = names.ToList();//1) call ToList
            DC = new List<string>(names);//2) pass the array to the list constructor

            ArrayChallenge();

            List<bool> flag = new List<bool>(10);// { true, true, false };
            try
            {
                flag[0] = true;//??
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR: The list is empty.");
            }
            //or .Add method
            flag.Add(true);
            PrintInfo(flag);
            flag.Add(false);
            PrintInfo(flag);
            flag.Add(true);
            PrintInfo(flag);
            flag.Add(true);
            PrintInfo(flag);
            flag.Add(true);//
            PrintInfo(flag);
            flag.Add(false);
            PrintInfo(flag);
            flag.Add(true);
            PrintInfo(flag);
            flag.Add(true);
            PrintInfo(flag);
            flag.Add(true);//
            PrintInfo(flag);
            flag.Add(true);
            PrintInfo(flag);
            flag.Add(true);//
            PrintInfo(flag);
            for (int i = 0; i < flag.Count; i++)
            {
                Console.WriteLine(flag[i]);
            }
            foreach (var item in flag)
            {
                Console.WriteLine(item);
            }

            flag.Remove(false);//removes the first one it finds and stops
            flag.RemoveAt(3);//4th item

            ListChallenge();
        }
        static void PrintInfo(List<bool> list)
        {
            //Count: # of items that have been added
            //Capacity: size of internal array (array.Length)
            Console.WriteLine($"Count: {list.Count}\tCapacity: {list.Capacity}");
        }

        static void ListChallenge()
        {
            List<double> grades = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                grades.Add(random.NextDouble() * 100);
            }
            PrintGrades(grades);
            int numDropped = DropFailing(grades);
            Console.WriteLine($"Number of students dropped: {numDropped}");
            PrintGrades(grades);
            List<double> newGrades = CurveGrades(grades);
            PrintGrades(newGrades);
        }

        static List<double> CurveGrades(List<double> grades)
        {
            List<double> curved = grades.ToList();//clone the original
            for (int i = 0; i < curved.Count; i++)
            {
                if (curved[i] < 95) curved[i] += 5;
                else curved[i] = 100;
            }
            return curved;
        }

        static int DropFailing(List<double> grades)
        {
            List<double> course = grades.ToList();//will this make a new list?
            course = new List<double>(grades);
            int numFailed = 0;
            //for (int i = 0; i < grades.Count; i++)
            //{
            //    if (grades[i] < 59.5)
            //    {
            //        numFailed++;
            //        grades.RemoveAt(i);//shifts items down
            //        i--;
            //    }
            //}

            //reverse for loop
            for (int i = grades.Count - 1; i >= 0; i--)
            {
                if (grades[i] < 59.5)
                {
                    numFailed++;
                    grades.RemoveAt(i);//shifts items down
                }
            }
            return numFailed;
        }

        private static void PrintGrades(List<double> grades)
        {
            Console.WriteLine("--------GRADES-------");
            //for (int i = 0; i < grades.Count; i++)
            //{
            //    Console.WriteLine(grades[i]);
            //}

            foreach (var grade in grades)
            {
                Console.WriteLine($"{grade,7:N2}");
            }

        }

        static void ArrayChallenge()
        {
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next();
            }
            foreach (var number in nums)
            {
                Console.WriteLine(number);
            }

            //expand the array
            //1) make a new array
            int[] temp = new int[13];
            //2) copy the items
            for (int i = 0; i < nums.Length; i++)
                temp[i] = nums[i];
            //3) store temp into our variable
            nums = temp;//copying the memory address
            //the original nums array is still in memory!
        }
    }
}
