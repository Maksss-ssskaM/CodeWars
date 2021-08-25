using System;
public class Sum
{
    public int GetSum(int a, int b)
    {
        int sum = 0;
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);
        for (int i = min; i <= max; i++)
        {
            sum = sum + i;
        }
        return sum;
    }
}
