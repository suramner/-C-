using System;

namespace Parabola
{
    class Program
    {
        struct Point
        {
            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public double x;
            public double y;
        }

        static Point Extremum(long x1, long y1, long x2, long y2, long x3, long y3)
        {
            var delta = x1 * x1 * (x2 - x3) - x1 * (x2 * x2 - x3 * x3) + (x2 * x2 * x3 - x2 * x3 * x3);
            var delta1 = y1 * (x2 - x3) - x1 * (y2 - y3) + (y2 * x3 - x2 * y3);
            var delta2 = x1 * x1 * (y2 - y3) - y1 * (x2 * x2 - x3 * x3) + (x2 * x2 * y3 - y2 * x3 * x3);
            var delta3 = x1 * x1 * (x2 * y3 - x3 * y2) - x1 * (x2 * x2 * y3 - x3 * x3 * y2) +
                         y1 * (x2 * x2 * x3 - x2 * x3 * x3);

            var a = delta1 / delta;
            var b = delta2 / delta;
            var c = delta3 / delta;

            return new Point(-b / (2.0 * a), c - b * b / (4.0 * a));
        }
        
        static void Main(string[] args)
        {
            var input = Console.ReadLine()?.Split();
            var x1 = long.Parse(input[0]);
            var y1 = long.Parse(input[1]);
            input = Console.ReadLine()?.Split();
            var x2 = long.Parse(input[0]);
            var y2 = long.Parse(input[1]);
            input = Console.ReadLine()?.Split();
            var x3 = long.Parse(input[0]);
            var y3 = long.Parse(input[1]);
            var point = Extremum(x1, y1, x2, y2, x3, y3);
            Console.WriteLine(String.Format("{0} {1}", point.x, point.y));
        }
    }
}
