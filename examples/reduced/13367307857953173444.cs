// Generated by Fuzzlyn v1.1 on 2018-09-24 10:42:59
// Seed: 13367307857953173444
// Reduced from 35.7 KiB to 0.6 KiB in 00:00:39
// Debug: Outputs 0
// Release: Outputs 2795022080
public class Program
{
    static bool[] s_1;
    static sbyte s_11 = -1;
    public static void Main()
    {
        var vr3 = new ulong[]{0};
        M4(vr3, s_11);
    }

    static void M4(ulong[] arg1, sbyte arg3)
    {
        try
        {
            arg1 = new ulong[]{0};
        }
        finally
        {
            System.Console.WriteLine(arg3);
        }

        arg3 = (sbyte)M5();
        uint var7 = (uint)(arg3 * -5545879415376222375L);
        System.Console.WriteLine(var7);
    }

    static ushort M5()
    {
        s_1 = new bool[]{true};
        return 0;
    }
}