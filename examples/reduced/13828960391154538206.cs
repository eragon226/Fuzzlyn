// Generated by Fuzzlyn v1.1 on 2018-08-02 19:17:30
// Seed: 13828960391154538206
// Reduced from 23.1 KiB to 0.6 KiB
// Debug: Outputs 13075062753800813877
// Release: Outputs 0
struct S0
{
}

struct S2
{
    public ulong F1;
    public S0 F4;
    public S2(ulong f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    static S2 s_2 = new S2(13075062753800813877UL);
    public static void Main()
    {
        S2[] vr17 = new S2[]{new S2(0)};
        ref S2 vr41 = ref s_2;
        var vr21 = new S2(0);
        var vr22 = vr17[0];
        ref S2 vr38 = ref s_2;
        vr38 = M6(vr41, M6(vr22, vr21));
    }

    static ref S2 M6(S2 arg0, S2 arg1)
    {
        System.Console.WriteLine(arg0.F1);
        return ref s_2;
    }
}
