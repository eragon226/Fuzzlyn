// Generated by Fuzzlyn on 2018-07-24 04:39:09
// Seed: 16717636433723723766
// Reduced from 42.5 KiB to 0.4 KiB
// Debug: Outputs 3697707954
// Release: Outputs 35762
class C0
{
    public uint F0;
    public C0(uint f0)
    {
        F0 = f0;
    }
}

public class Program
{
    static C0 s_1;
    public static void Main()
    {
        long vr1;
        s_1 = new C0(3697707954U);
        long vr2 = (ushort)s_1.F0;
        if (false)
        {
            vr1 = vr2;
        }
        else
        {
            s_1.F0 = s_1.F0;
        }

        System.Console.WriteLine(s_1.F0);
    }
}
