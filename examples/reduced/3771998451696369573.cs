// Generated by Fuzzlyn on 2018-07-13 02:33:42
// Seed: 3771998451696369573
// Reduced from 11.5 KiB to 0.6 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public char F0;
    public int F1;
    public uint F2;
    public ulong F3;
    public C0(uint f2)
    {
        F2 = f2;
    }
}

class C1
{
    public short F3;
}

public class Program
{
    static C0 s_1;
    public static void Main()
    {
        C1 vr14 = new C1();
        s_1 = new C0(0);
        var vr15 = new bool[]{false};
        var vr16 = (ushort)(s_1.F0 - (s_1.F2 * vr14.F3));
        var vr17 = new C0(0);
        M1(vr15, vr16, 0, vr17);
    }

    static C1 M1(bool[] arg0, ushort arg1, ushort arg2, C0 arg3)
    {
        s_1.F1 = arg3.F1;
        return new C1();
    }
}