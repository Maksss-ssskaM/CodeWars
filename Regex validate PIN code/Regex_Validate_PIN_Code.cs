using System;
using System.Linq;
public class Kata
{
    public static bool ValidatePin(string pin)
    {
        return pin.All(el => Char.IsDigit(el)) && (pin.Length == 4 || pin.Length == 6);
    }
}