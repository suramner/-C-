using System;

public class Braking
{
    public static double Dist(double v, double mu)
    {
        v /= 3.6;
        return v * v / (2 * mu * 9.81) + v * 1;
    }

    public static double Speed(double d, double mu)
    {
        double a = mu * 9.81;
        return (Math.Sqrt(a * a + 2 * a * d) - a) * 3.6;
    }
}