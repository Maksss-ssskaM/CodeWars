using System.Linq;
using System;
public static class Kata
{
    public static bool XO(string input)
    {
        return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
    }
}
