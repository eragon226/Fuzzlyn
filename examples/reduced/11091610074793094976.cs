// Generated by Fuzzlyn v1.1 on 2018-08-18 22:39:02
// Seed: 11091610074793094976
// Reduced from 10.5 KiB to 0.6 KiB
// Debug: Outputs 0
// Release: Outputs 2147483647
struct S0
{
    public int F0;
    public S0(int f0): this()
    {
        F0 = f0;
    }
}

struct S1
{
    public uint F1;
    public ulong F2;
}

class C0
{
}

public class Program
{
    static S0 s_1;
    public static void Main()
    {
        var vr2 = new S1();
        M2(vr2);
        System.Console.WriteLine(s_1.F0);
    }

    static C0[] M2(S1 arg0)
    {
        arg0.F1 = 4039609409U;
        bool vr1 = (byte)arg0.F1 <= 0;
        if (vr1)
        {
            s_1 = new S0(2147483647);
        }
        else
        {
        }

        return new C0[]{new C0()};
    }
}