// Generated by Fuzzlyn v1.1 on 2018-08-12 23:14:23
// Seed: 11104361664744409791
// Reduced from 90.8 KiB to 0.6 KiB
// Debug: Outputs 1862273820
// Release: Outputs 0
class C0
{
}

struct S0
{
    public uint F0;
    public bool F1;
    public C0 F2;
    public long F4;
    public S0(uint f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_10;
    public static void Main()
    {
        var vr11 = new S0(0);
        var vr12 = new S0(1862273820U);
        bool vr13 = M10(vr12, M18(vr11));
    }

    static bool M10(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return arg0.F1;
    }

    static ref S0 M18(S0 arg0)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_10;
    }
}
