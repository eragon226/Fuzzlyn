// Generated by Fuzzlyn on 2018-07-25 07:37:10
// Seed: 7644739558243068209
// Reduced from 26.2 KiB to 0.4 KiB
// Debug: Outputs 65493
// Release: Outputs 4294967253
struct S0
{
    public long F1;
    public sbyte F4;
    public S0(sbyte f4): this()
    {
        F4 = f4;
    }
}

public class Program
{
    static S0[] s_2 = new S0[]{new S0(1)};
    public static void Main()
    {
        s_2[0].F4 *= -43;
        ulong vr9 = (ushort)((s_2[0].F4 ^ s_2[0].F1) ^ 0);
        System.Console.WriteLine(vr9);
    }
}