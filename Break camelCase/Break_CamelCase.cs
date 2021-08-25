﻿using System.Linq;
public class Kata
{
    public static string BreakCamelCase(string str)
    {
        return string.Join("", str.Select(x => char.IsUpper(x) ? " " + x : x.ToString()));
    }
}
