// Generated by Fuzzlyn v1.1 on 2018-09-29 08:44:14
// Seed: 8923282765798224077
// Reduced from 164.6 KiB to 0.7 KiB in 00:04:43
// Debug: Outputs -1
// Release: Outputs -65519
public class Program
{
    static sbyte[][] s_8 = new sbyte[][]{new sbyte[]{0}};
    static ulong s_73;
    static short s_90;
    static long s_92;
    public static void Main()
    {
        s_8[0] = new sbyte[]{-1};
        s_90 = s_8[0][0];
        long vr9 = default(long);
        var vr8 = (short)vr9;
        M74(vr8);
        System.Console.WriteLine(s_92);
    }

    static void M74(short arg0)
    {
        ulong var1 = default(ulong);
        arg0 = s_90;
        var1 >>= (int)(0 % (var1 | 1));
        s_92 = (arg0 % 34);
        try
        {
            var1 = s_73;
        }
        finally
        {
            arg0 *= arg0;
        }
    }
}