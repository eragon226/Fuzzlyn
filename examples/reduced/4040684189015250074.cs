// Generated by Fuzzlyn on 2018-07-06 15:19:34
// Seed: 4040684189015250074
// Reduced from 8.7 KiB to 0.4 KiB
// Debug: Outputs -54
// Release: Outputs -24630
struct S0
{
    public short F1;
    public ushort F2;
    public ushort F3;
    public sbyte F5;
    public ushort F6;
    public S0(short f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    public static void Main()
    {
        S0 vr17 = new S0(-24630);
        sbyte vr18 = (sbyte)vr17.F1;
        int vr20 = vr18;
        System.Console.WriteLine(vr20);
    }
}