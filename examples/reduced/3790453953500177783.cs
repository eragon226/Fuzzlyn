// Generated by Fuzzlyn v1.1 on 2018-09-06 08:17:17
// Seed: 3790453953500177783
// Reduced from 127.0 KiB to 0.5 KiB in 00:02:39
// Debug: Outputs 1
// Release: Outputs 247
public class Program
{
    static sbyte s_17;
    static sbyte s_26 = -1;
    public static void Main()
    {
        var vr5 = M47(s_26);
    }

    static int M47(sbyte arg2)
    {
        try
        {
            arg2 = s_17;
        }
        finally
        {
            sbyte var16 = arg2++;
            ulong var18 = (ulong)(arg2 % 123);
            System.Console.WriteLine(var18);
        }

        uint vr8 = default(uint);
        return (int)vr8;
    }
}
