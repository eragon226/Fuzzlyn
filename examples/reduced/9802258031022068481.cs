// Generated by Fuzzlyn v1.1 on 2018-10-03 20:37:01
// Seed: 9802258031022068481
// Reduced from 253.9 KiB to 0.7 KiB in 00:05:13
// Debug: Outputs 0
// Release: Outputs 2
struct S0
{
    public ushort F3;
}

public class Program
{
    static long s_50;
    static S0 s_67;
    public static void Main()
    {
        M74(-1);
    }

    static void M74(short arg0)
    {
        var vr3 = (short)s_50;
        arg0 = (short)M80(vr3);
        arg0 /= -31863;
        System.Console.WriteLine(arg0);
        try
        {
            var vr2 = s_67.F3;
            int vr13 = vr2;
        }
        finally
        {
            arg0 = arg0--;
        }
    }

    static ushort M80(short arg4)
    {
        S0 var0 = default(S0);
        System.Console.WriteLine(arg4);
        return var0.F3;
    }
}
