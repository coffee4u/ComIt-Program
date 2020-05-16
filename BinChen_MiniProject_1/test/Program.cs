//Created by BC 2020-05-10
using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int num1, num2, operation;

                Console.WriteLine("Please enter a number:");
                string input1 = Console.ReadLine();
                bool r1 = validationNumber(input1, out num1);

                Console.WriteLine("Please enter a number:");
                string input2 = Console.ReadLine();
                bool r2 = validationNumber(input2, out num2);

                Console.WriteLine("Please specify a math operation (1 - Add, 2 - Subtract, 3 - Multiply, 4 - Divide)");
                string input3 = Console.ReadLine();
                bool r3 = validationOperation(input3, out operation);

                bool isSuccess = r1 && r2 && r3;
                if (isSuccess)
                {
                    long result = 0;
                    switch (operation)
                    {
                        case 1://add
                            result = num1 + num2;
                            break;
                        case 2://subtract
                            result = num1 - num2;
                            break;
                        case 3://multiply
                            result = num1 * num2;
                            break;
                        case 4://divide
                            result = num1 / num2;
                            break;
                    }
                    Console.WriteLine("The result:" + result);
                    break;
                }
                else
                {
                    Console.WriteLine("Input error, try again.");
                }
            }

            static bool validationNumber(string input, out int num)
            {
                return int.TryParse(input, out num);
            }

            static bool validationOperation(string input, out int operation)
            {
                int.TryParse(input, out operation);
                return (operation >= 1 && operation <= 4);
            }


        }
    }
}
