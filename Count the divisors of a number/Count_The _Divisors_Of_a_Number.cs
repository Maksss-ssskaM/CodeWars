using System.Linq;
public class Kata
{
    public static int Divisors(int n)
    {
        return Enumerable.Range(1, n).Where(x => n % x == 0).ToArray().Length;
    }
}
