using System;

namespace ConsoleApp1
{

    public class FibonacciCalc
    {
        public static void Main(string[] args)
        {
            string iterations;
            int i = Convert.ToInt32(iterations = Console.ReadLine());
            Int64 num1 = 1, num2 = 1, temp;
            for(int x = 0; x != i; x++)
            {
                temp = num2;
                num2 = num1 + num2;
                num1 = temp;
                Console.WriteLine(num1);
            }
        }
    }
}