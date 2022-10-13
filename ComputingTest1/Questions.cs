using System;
using System.Text;

namespace ComputingTest1 // Note: actual namespace depends on the project name.
{
    internal class Questions
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(IntDivide(num));

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int gcf = GCF(num1, num2);
            Console.WriteLine("{0} is GCF of {1} and {2}", gcf, num1, num2);

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

        public static int GCF(int num1, int num2)
        {
            int temp1 = num1;
            int temp2 = num2;

            while (temp1 != temp2)
            {
                if (temp1 > temp2)
                {
                    temp1 -= temp2;
                }

                else
                {
                    temp2 -= temp1;
                }
            }

            int result = temp1;
            return result;

        }

        // the variables Number1 and Number2 are later used in the output string
        // if they were used in the algorithm they would have been changed 
        // and thus the final output would not use the correct user input numbers
    }
}