// Generated by Fuzzlyn v1.1 on 2018-09-18 03:17:18
// Seed: 273782871947620846
// Reduced from 119.7 KiB to 0.5 KiB in 00:01:22
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public uint F0;
    public long F3;
    public long F4;
    public S0(uint f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0[] s_3 = new S0[]{new S0(1)};
    public static void Main()
    {
        var vr6 = new S0(0);
        S0 vr14 = s_3[0];
        var vr10 = new S0(0);
        M5(vr6, M5(vr14, vr10));
    }

    static ref S0 M5(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_3[0];
    }
}