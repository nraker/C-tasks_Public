using System;
using System.Collections.Generic;

namespace stack_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<double> numbers = new Stack<double>();
            double result = 0;
            string operation;
            
           
            Console.WriteLine("Enter first operand");
            numbers.Push(Convert.ToDouble(Console.ReadLine()));
            
            Console.WriteLine("Enter second operand");
            numbers.Push(Convert.ToDouble(Console.ReadLine()));
            
            Console.WriteLine("Enter operation (-, +, /, *)");
            operation = Console.ReadLine();
            switch(operation)
            {
                case "-":
                    result  = numbers.Pop() - numbers.Pop();
                    break;
                case "+":
                    result = numbers.Pop() + numbers.Pop();
                    break;
                case "*":
                    result = numbers.Pop() * numbers.Pop();
                    break;
                case "/":
                    result = numbers.Pop() / numbers.Pop();
                    break;
            }

            Console.WriteLine("Result: " + result);

            
           
            Console.ReadKey();
        }
    }
}
