// Generated by Fuzzlyn on 2018-07-03 01:39:20
// Seed: 14017801134979057155
// Reduced from 9.7 KiB to 0.3 KiB
// Debug: Outputs 1
// Release: Outputs 0
public class Program
{
    static short s_2;
    public static void Main()
    {
        sbyte vr12 = (sbyte)(0 % (((0 & (0 / (M1() | 1))) * s_2) | 1));
        s_2 = s_2;
        System.Console.WriteLine(s_2);
    }

    static sbyte M1()
    {
        var vr11 = s_2++;
        return 0;
    }
}