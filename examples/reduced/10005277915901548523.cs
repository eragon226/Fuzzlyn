// Generated by Fuzzlyn v1.1 on 2018-08-08 06:06:27
// Seed: 10005277915901548523
// Reduced from 325.2 KiB to 0.5 KiB
// Debug: Outputs 20926
// Release: Outputs 0
struct S0
{
    public short F0;
    public long F1;
    public uint F2;
    public S0(short f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_13;
    static S0[] s_37 = new S0[]{new S0(0)};
    static S0 s_72;
    public static void Main()
    {
        var vr11 = new S0(20926);
        var vr12 = s_37[0];
        M105(vr11, M105(vr12, s_13));
    }

    static ref S0 M105(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_72;
    }
}
