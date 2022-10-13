using System;
using System.Text;

namespace ComputingTest1 // Note: actual namespace depends on the project name.
{
    internal class ComputingTest1
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(IntDivide(num));

        }

        public static string IntDivide(double num)
        {
            double cur = num;
            StringBuilder str = new StringBuilder();
            
            
            while (cur != 0)
            {
                str.Append(cur % 2);
                cur = Math.Floor(cur / 2);
            }

            StringBuilder realStr = new StringBuilder();

            for (int i = str.ToString().Length - 1; i >= 0; i--)
            {
                realStr.Append(str.ToString()[i]);
            }

            return realStr.ToString();
        }
    }
}