// Generated by Fuzzlyn v1.1 on 2018-08-20 19:04:29
// Seed: 7066519464349755567
// Reduced from 8.0 KiB to 0.7 KiB in 00:00:39
// Debug: Prints 6 line(s)
// Release: Prints 7 line(s)
public class Program
{
    static long[] s_2;
    public static void Main()
    {
        var vr15 = M2(0);
        if (vr15 > 0)
        {
            System.Console.WriteLine(0);
        }
    }

    static short M2(short arg0)
    {
        try
        {
            System.Console.WriteLine(0);
        }
        finally
        {
            System.Console.WriteLine(47);
            s_2 = new long[]{1};
            System.Console.WriteLine(0);
            System.Console.WriteLine(0);
            System.Console.WriteLine(0);
            arg0 = (short)M5();
            arg0 %= 20961;
        }

        return arg0;
    }

    static long M5()
    {
        System.Console.WriteLine(0);
        return -1;
    }
}
