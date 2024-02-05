using System.Linq;

namespace Lab3_2
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            var NameStr = Console.ReadLine();

            Console.WriteLine($"{NameStr.Reverse()}");
        }
    }
}
