using System;
using Microsoft.VisualBasic;

public class MouseAndGrains
{

    private static String solve(int[,] map)
    {
        int[,] dynamic = new int[map.GetLength(0) + 1, map.GetLength(1) + 1];

        for (int i = dynamic.GetLength(0) - 2; i >= 0; i--)
        {
            for (int j = 1; j < dynamic.GetLength(1); j++)
            {
                dynamic[i, j] = Math.Max(dynamic[i + 1, j], dynamic[i, j - 1]) + map[i, j - 1];
            }
        }
        
        char[] result = new char[map.GetLength(0) + map.GetLength(1) - 2];

        int itY = 0;
        int itX = dynamic.GetLength(1) - 1;
        int it = result.Length - 1;

        while (it >= 0)
        {
            if (itY + 1 < dynamic.GetLength(0) - 1 && dynamic[itY + 1, itX] >= dynamic[itY, itX - 1])
            {
                result[it--] = 'F';
                ++itY;
            }
            else
            {
                result[it--] = 'R';
                --itX;
            }
        }
        
        return new String(result);
    }
    
    public static void Main()
    {
        String[] input = Console.ReadLine()?.Split();
        int ySize = int.Parse(input[0]);
        int xSize = int.Parse(input[1]);
        
        int[,] map = new int[ySize,xSize];

        for (int i = 0; i < ySize; i++)
        {
            input = Console.ReadLine()?.Split();
            for (int j = 0; j < xSize; j++)
            {
                if (input != null) map[i, j] = int.Parse(input[j]);
            }
        }
        
        Console.WriteLine(solve(map));
    }
}