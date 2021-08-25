public class Kata
{
    public static int FindShort(string s)
    {
        string[] words = s.Split(' ');
        int R = 100000000;
        foreach (string el in words)
        {
            if (el.Length < R)
            {
                R = el.Length;
            }
        }
        return R;
    }
}