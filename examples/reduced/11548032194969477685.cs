// Generated by Fuzzlyn v1.1 on 2018-09-24 23:31:16
// Seed: 11548032194969477685
// Reduced from 17.1 KiB to 0.4 KiB in 00:00:19
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public uint F1;
}

class C1
{
    public C0 F0;
    public C0 F1;
    public C1(C0 f0, C0 f1)
    {
        F0 = f0;
        F1 = f1;
    }
}

public class Program
{
    static C1 s_1 = new C1(new C0(), new C0());
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        if (0 < (s_1.F0.F1 ^ (0 & s_1.F1.F1)))
        {
            s_1.F1.F1 = 0;
        }
    }
}