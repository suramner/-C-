using System;

public class BankerPlan
{
    public static Boolean Fortune(int f0, double p, int c0, int n, double i)
    {
        for (; n > 1; n--)
        {
            f0 += (int) (f0 * p / 100) - c0;
            c0 += (int) (c0 * i / 100);
        }

        return f0 >= 0;
    }
}