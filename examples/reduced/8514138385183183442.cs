// Generated by Fuzzlyn v1.1 on 2018-09-27 21:59:27
// Seed: 8514138385183183442
// Reduced from 272.5 KiB to 0.6 KiB in 00:05:27
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public ushort F0;
    public long F1;
    public bool F6;
}

struct S1
{
    public byte F0;
    public long F3;
    public uint F4;
    public S1(byte f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_8;
    static byte s_16;
    public static void Main()
    {
        var vr2 = new S1(1);
        S1 vr4 = default(S1);
        M58(vr2, M76(vr4, ref s_16));
    }

    static void M58(S1 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
    }

    static ref S0 M76(S1 arg2, ref byte arg3)
    {
        arg2.F0 &= arg3;
        return ref s_8;
    }
}
