using System;

public class Circles
{
    static int IntersectionCount(double x1, double y1, double r1, double x2, double y2, double r2)
    {
        if (Math.Abs(x1 - x2) < 0.0001 && Math.Abs(y1 - y2) < 0.0001
                                       && Math.Abs(r1 - r2) < 0.0001)
        {
            return -1;
        }
        
        var distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        var minDistance = Math.Abs(r1 - r2);
        var maxDistance = r1 + r2;

        if (Math.Abs(distance - maxDistance) < 0.0001 || Math.Abs(distance - minDistance) < 0.0001)
        {
            return 1;
        }

        if (distance > maxDistance || distance < minDistance)
        {
            return 0;
        }
        
        return 2;
    }
    
    static void Main(string[] args)
    {
        String[] input = Console.ReadLine().Split();
        double x1 = double.Parse(input[0]);
        double y1 = double.Parse(input[1]);
        double r1 = double.Parse(input[2]);
        double x2 = double.Parse(input[3]);
        double y2 = double.Parse(input[4]);
        double r2 = double.Parse(input[5]);
        Console.WriteLine(IntersectionCount(x1, y1, r1, x2, y2, r2));
    }
}