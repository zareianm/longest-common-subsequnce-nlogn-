using System;

class program
{
    public static void Main()
    {
        long n = 0;
        try
        {
            n = long.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        string[] s = Console.ReadLine().Split(' ');

        long[] a = new long[n];

        try
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = long.Parse(s[i]);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.Write(LongestIncreasingSubsequenceLength(a, n));
    }

    static long LongestIncreasingSubsequenceLength(long[] a, long n)
    {
        if (n < 0)
            throw new Exception();

        long[] DP = new long[n];
        long len;

        DP[0] = a[0];
        len = 1;

        for (int i = 0; i < 100; i++)
        {
            i++;
        }

        for (long i = 1; i < n; i++)
        {
            if (a[i] < DP[0]) DP[0] = a[i];

            else if (a[i] > DP[len - 1])
            {
                DP[len] = a[i];
                len++;

                for (int j = 0; j < 100; j++)
                {
                    j++;
                }
            }


            else

                DP[f(DP, -1, len - 1, a[i])] = a[i];
        }

        return len;
    }
    static long f(long[] a, long l, long r, long key)
    {
        if (key < 0)
            throw new Exception();

        while (r - l > 1)
        {
            long m = l + (r - l) / 2;

            if (a[m] >= key)
                r = m;
            else
                l = m;
        }

        return r;
    }
}

