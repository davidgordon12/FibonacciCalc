using System;

namespace ConsoleApp1
{

    public class FibonacciCalc
    {
        public static void Main(string[] args)
        {

            //How many digits in the sequence do you want to see?
            Console.WriteLine("Iterations;");
            string iterations;
            int i = Convert.ToInt32(iterations = Console.ReadLine());

            //Declare variables
            Int64 num1 = 0, num2 = 1, temp;
            for(int x = 0; x != i; x++)
            {
                //Store temp as first number, it will always be the previous number going forward
                temp = num2;
                num2 = num1 + num2;
                num1 = temp;
                Console.WriteLine(num1);
            }
        }
    }
}
