// Generated by Fuzzlyn v1.1 on 2018-09-17 07:52:03
// Seed: 12445489756591583746
// Reduced from 279.9 KiB to 0.5 KiB in 00:05:11
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public uint F0;
    public long F3;
    public ushort F7;
    public S0(uint f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_12;
    public static void Main()
    {
        var vr3 = new S0(1);
        var vr5 = new S0(0);
        var vr6 = new S0(0);
        M93(vr3, M93(vr5, vr6));
    }

    static ref S0 M93(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_12;
    }
}