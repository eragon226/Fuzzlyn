// Generated by Fuzzlyn on 2018-06-20 00:45:26
// Seed: 17999061870156393243
// Reduced from 103.9 KiB to 0.5 KiB
// Debug: Outputs 107
// Release: Outputs -62
struct S0
{
    public ulong F0;
    public sbyte F1;
    public int F4;
    public char F5;
    public sbyte F9;
    public S0(int f4): this()
    {
        F4 = f4;
    }
}

struct S1
{
    public S0 F7;
}

public class Program
{
    static S1 s_14;
    public static void Main()
    {
        S0 vr16 = new S0(1407772573);
        uint vr17 = (uint)(15781423030932714560UL % (ushort)vr16.F4);
        s_14.F7.F9 = (sbyte)vr17;
        System.Console.WriteLine(s_14.F7.F9);
    }
}
