// Generated by Fuzzlyn v1.1 on 2018-09-16 19:59:20
// Seed: 6955490362577564452
// Reduced from 269.0 KiB to 0.5 KiB in 00:05:47
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public ushort F0;
    public int F1;
    public int F2;
    public ulong F4;
    public S0(ulong f4): this()
    {
        F4 = f4;
    }
}

public class Program
{
    static S0 s_26 = new S0(1);
    public static void Main()
    {
        var vr25 = new S0(0);
        var vr26 = new S0(0);
        M31(s_26, M31(vr25, vr26));
    }

    static ref S0 M31(S0 arg0, S0 arg1)
    {
        var vr2 = arg0.F4;
        System.Console.WriteLine(vr2);
        return ref s_26;
    }
}
