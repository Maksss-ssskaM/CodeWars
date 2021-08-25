using System.Linq;

namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq)
        {
            for (int i = 0; i < seq.Length; i++)
            {
                if (seq.Count(el => el == seq[i]) % 2 == 1)
                {
                    return seq[i];
                }
            }
            return -1;
        }

    }
}
