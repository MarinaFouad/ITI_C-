
using System;
namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            
            try
            {
                Console.WriteLine("Enter first number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int num2 = int.Parse(Console.ReadLine());
                int result = 0;
                result = divide(num1, num2);
                Console.WriteLine($"Result = {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You are trying to divide by zero");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter small number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter another number");
            }


             int divide(int num1, int num2)
            {
                return num1 / num2;

            }
        }




    }

}