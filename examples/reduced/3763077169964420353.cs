// Generated by Fuzzlyn on 2018-07-21 05:59:21
// Seed: 3763077169964420353
// Reduced from 4.5 KiB to 0.5 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public uint F0;
    public uint F4;
    public long F5;
    public C0(uint f0)
    {
        F0 = f0;
    }
}

class C1
{
    public C0 F0;
    public C1(C0 f0)
    {
        F0 = f0;
    }
}

struct S0
{
    public C1 F4;
    public char F5;
    public S0(C1 f4): this()
    {
        F4 = f4;
    }
}

public class Program
{
    public static void Main()
    {
        S0 vr1 = new S0(new C1(new C0(0)));
        vr1.F5 = (char)((short)((vr1.F4.F0.F4 | -10973) ^ vr1.F4.F0.F0) / 7541);
    }
}
