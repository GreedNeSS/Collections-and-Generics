using System;

namespace Generic_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> point1 = new Point<int>(10, 10);

            Console.WriteLine($"point1.ToString(): {point1.ToString()}");
            point1.ResetPoint();
            Console.WriteLine($"point1.ToString(): {point1.ToString()}");
            
            Point<decimal> point2 = new Point<decimal>(0.434m, 10.54m);

            Console.WriteLine($"point2.ToString(): {point2.ToString()}");
            point2.ResetPoint();
            Console.WriteLine($"point2.ToString(): {point2.ToString()}");
        }
    }
}
