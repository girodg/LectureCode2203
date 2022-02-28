using System;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMessage();
            string msg = GetMessage();
            PrintMessage(msg);
            TimeStamp(ref msg);
            PrintMessage(msg);
            int num1 = 10, num2 = 50;
            int result = Sum(num1, num2);

            int salary = 10000;
            Factor(ref salary, (float)1.05);
            Console.WriteLine(salary);

            Console.WriteLine(DateTime.Now);
            int grade = 59;
            Factor(ref grade, 1.05F);

            CurveGrade(grade, 5, out int newGrade);
            Console.WriteLine($"{grade} was curved to {newGrade}.");

            MyFavoriteNumber(out int myFave);
            Console.WriteLine($"Your favorite number is {myFave}. Weird.");
            Console.ReadKey();
        }

        static void MyFavoriteNumber(out int myNum)
        {
            Console.Write("What is your favorite number? ");
            string numberStr = Console.ReadLine();
            //try
            //{
            //    myNum = int.Parse(numberStr);//can throw an exception
            //}
            //catch (Exception)
            //{
            //    myNum = 0;
            //}

            //OR use int.TryParse which does NOT throw exception
            bool isNumber = int.TryParse(numberStr, out myNum);
            if (isNumber)
            {
                Console.WriteLine("Thank you for entering a number.");
            }
            else
            {
                Console.WriteLine("Thanks a lot Steev!");
            }
        }

        static void CurveGrade(int grade, int curve, out int curvedGrade)
        {
            //curvedGrade = grade + curve;
            //if (curvedGrade > 100) curvedGrade = 100;

            //ternary operator -- shorthand for if-else
            curvedGrade = (grade + curve > 100) ? 100 : grade + curve;
        }

        static void TimeStamp(ref string messageToTimestamp)
        {
            //$ - interpolated string
            messageToTimestamp = $"{DateTime.Now}: {messageToTimestamp}";
        }

        static void Factor(ref int numberToChange, float factor)
        {
            numberToChange = (int)(numberToChange * factor);
        }

        static int Sum(int n1, int n2)
        {
            n1 += 10;//will this change num1? NO. it's just a copy.
            return n1 + n2;
        }

        static void PrintMessage()
        {
            string myMessage = "Batman is the best! Spider-who?";
            Console.WriteLine(myMessage);
        }

        static void PrintMessage(string myMessage)
        {
            Console.WriteLine(myMessage);
        }

        static string GetMessage()
        {
            Console.Write("Please enter your favorite superhero? ");
            string message = Console.ReadLine();
            return message;
        }

    }
}
