using System;


namespace SBF_1
{
    class Program
    {
    static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            x1 = 12;
            x2 = 13;
            y1 = 11;
            y2 = 10;
            var distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine(distance);
        }
    }
}
