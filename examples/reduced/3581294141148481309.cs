// Generated by Fuzzlyn on 2018-06-27 04:47:10
// Seed: 3581294141148481309
// Reduced from 364.0 KiB to 0.4 KiB
// Debug: Outputs 71
// Release: Outputs 0
struct S0
{
    public bool F0;
}

struct S1
{
    public S0 F5;
    public S0 F7;
    public byte F8;
    public S1(byte f8): this()
    {
        F8 = f8;
    }
}

public class Program
{
    static S1[] s_17 = new S1[]{new S1(71)};
    public static void Main()
    {
        S1 vr9 = s_17[0];
        vr9.F7 = M44();
        System.Console.WriteLine(vr9.F8);
    }

    static S0 M44()
    {
        return s_17[0].F5;
    }
}
