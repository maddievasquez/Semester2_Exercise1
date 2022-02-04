using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Exercises
{
    public class Calculator_App
    {

        // Constructor
        public Calculator_App()
        {

        }

        public void Calculator()
        {
            Console.WriteLine("Hello, welcome to Maddie's basic calculator!");
            int firstNum;
            int secondNum;
            string operand;
            ConsoleKeyInfo status;
            int answer;

            while (true)
            {
                Console.Write("Please enter the first integer: ");
                firstNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the second integer: ");
                secondNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter an operand (+, -, /, *): ");
                operand = Console.ReadLine();

                switch (operand)
                {
                    case "-":
                        answer = firstNum - secondNum;
                        break;
                    case "+":
                        answer = firstNum + secondNum;
                        break;
                    case "/":
                        int result1; // quotient 
                        int result2; // remainder 
                        result1 = firstNum / secondNum;
                        result2 = firstNum % secondNum;
                        answer = result1 + (result2 / 10);
                        // 3 / 2 > 1.5 >> 3 % 2 = 0.5
                        break;
                    case "*":
                        answer = firstNum * secondNum;
                        break;
                    default:
                        answer = 0;
                        break;
                }
                Console.WriteLine($"{firstNum} {operand} {secondNum} = {answer}");
                Console.WriteLine("\n\n Do You Want To Break (Y/y)");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.Y)
                {
                    break;
                }
                Console.Clear();
            }

        }
    }
}