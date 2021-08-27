using System;
using System.Linq;
public static class Kata
{
    public static string Order(string words)
    {
        if (words != "")
            return string.Join(" ", words.Split(' ').OrderBy(x => x.ToList().Find(n => char.IsDigit(n))));
        return words;
    }
}