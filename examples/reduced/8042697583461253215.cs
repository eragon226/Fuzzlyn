// Generated by Fuzzlyn on 2018-07-30 15:21:18
// Seed: 8042697583461253215
// Reduced from 5.4 KiB to 0.5 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public int F0;
    public ulong F1;
}

class C1
{
    public C1(C0 f1, C0 f2)
    {
    }
}

public class Program
{
    static C0 s_1 = new C0();
    public static void Main()
    {
        M1();
    }

    static bool M1()
    {
        byte var0 = default(byte);
        var vr1 = (var0 * ((char)s_1.F1 * s_1.F0)) + (long)s_1.F0;
        M2(vr1);
        return true;
    }

    static bool M2(long arg0)
    {
        C1 var0 = new C1(new C0(), new C0());
        return false;
    }
}