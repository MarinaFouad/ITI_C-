namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            point<int> P01 = new point<int>(2, 2);
            point<int> P02 = new point<int> (10,5);

            Square Sq1 = new Square(P01, P02);
            Rect Rect1 = new Rect(P01, P02);

            Console.WriteLine($"Area of the Square = {Sq1.squareArea()}");
            Console.WriteLine($"Area of the Rect = {Rect1.RectArea()}");

            Square Sq2 = new Square(10);
            Rect Rect2 = new Rect(5,10);

            Console.WriteLine($"Area of the Square = {Sq2.squareArea()}");
            Console.WriteLine($"Area of the Rect = {Rect2.RectArea()}");

        }
    }
}
