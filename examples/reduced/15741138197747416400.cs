// Generated by Fuzzlyn v1.1 on 2018-09-19 12:14:13
// Seed: 15741138197747416400
// Reduced from 180.4 KiB to 0.4 KiB in 00:03:38
// Debug: Outputs 0
// Release: Outputs -25
public class Program
{
    static uint s_28;
    static ulong s_42;
    static sbyte s_65 = -1;
    public static void Main()
    {
        M7(0, 0);
    }

    static void M7(sbyte arg0, sbyte arg1)
    {
        try
        {
            s_42 = s_28;
        }
        finally
        {
            arg1 = arg0;
            arg0 = s_65;
            var vr1 = arg0 / -10;
            System.Console.WriteLine(vr1);
        }
    }
}
