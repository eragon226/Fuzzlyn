// Generated by Fuzzlyn on 2018-07-13 18:31:34
// Seed: 10940293586596198812
// Reduced from 89.2 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S1
{
    public ushort F4;
    public char F9;
}

public class Program
{
    static S1 s_15;
    static S1[, ] s_17 = new S1[, ]{{new S1()}};
    public static void Main()
    {
        sbyte vr5 = (sbyte)(0 & s_17[0, 0].F9);
        s_17[0, 0].F4 = s_15.F4;
        System.Console.WriteLine(vr5);
    }
}