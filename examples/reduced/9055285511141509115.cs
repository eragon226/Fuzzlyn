// Generated by Fuzzlyn v1.1 on 2018-09-06 17:30:37
// Seed: 9055285511141509115
// Reduced from 129.8 KiB to 0.5 KiB in 00:02:32
// Debug: Outputs 0
// Release: Outputs -2
public class Program
{
    static long s_1 = -1;
    static int s_37;
    public static void Main()
    {
        bool vr10 = M9(s_37, 0, 0);
    }

    static bool M9(int arg2, sbyte arg3, short arg4)
    {
        try
        {
            System.Console.WriteLine(0);
        }
        finally
        {
            System.Console.WriteLine(arg4);
        }

        ulong vr18 = (ulong)s_1;
        arg4 = (short)vr18;
        arg4 /= -32768;
        System.Console.WriteLine(arg4);
        return arg2 == arg3;
    }
}
