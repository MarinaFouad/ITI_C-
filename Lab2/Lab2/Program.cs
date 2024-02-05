using System.Security.Cryptography.X509Certificates;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("There is options to calculate please Enter the number of the operator: ");
            Console.WriteLine("1 - Sum , 2 - Sub , 3 - Div , 4 - Multiple ");
            Calculate calc1 = new Calculate();
            string option = Console.ReadLine();

            Calculate.CalcDeleg calcFirst = null;
            try
            {
                switch (option)
                {
                    case "1":
                        calcFirst = calc1.Sum;
                        break;
                    case "2":
                        calcFirst = calc1.Sub;
                        break;
                    case "3":                  
                        calcFirst = calc1.Div;
                        break; 
                    case "4":
                        calcFirst = calc1.Multi;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        return;

                }
             int result = calc1.Calculator(num1, num2, calcFirst);

            Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Trying to divide by zero");
            }
           
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format");
            }
            catch (Exception )
            {
                Console.WriteLine($"An unexpected error occurred");
            }

            

        }
    }
}
