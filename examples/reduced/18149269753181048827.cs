// Generated by Fuzzlyn v1.1 on 2018-09-14 16:08:54
// Seed: 18149269753181048827
// Reduced from 277.5 KiB to 0.8 KiB in 00:03:41
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public sbyte F0;
    public int F2;
    public short F3;
    public ulong F6;
    public S0(sbyte f0): this()
    {
        F0 = f0;
    }
}

struct S1
{
    public S0 F0;
    public S1(S0 f0): this()
    {
        F0 = f0;
    }
}

struct S2
{
    public S1 F0;
    public S2(S1 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S1 s_34;
    static S2 s_37 = new S2(new S1(new S0(1)));
    static bool[] s_51;
    public static void Main()
    {
        var vr6 = s_34.F0;
        S1 vr11 = s_37.F0;
        M33(vr6, M51(vr11));
    }

    static void M33(S0 arg0, S1 arg1)
    {
        System.Console.WriteLine(arg0.F0);
    }

    static ref S1 M51(S1 arg0)
    {
        s_51 = new bool[]{true};
        return ref s_37.F0;
    }
}