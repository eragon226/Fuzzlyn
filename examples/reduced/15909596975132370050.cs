// Generated by Fuzzlyn on 2018-07-20 22:22:59
// Seed: 15909596975132370050
// Reduced from 8.9 KiB to 0.3 KiB
// Debug: Outputs 4294967169
// Release: Outputs 129
public class Program
{
    static sbyte s_2;
    static long[, ] s_3 = new long[, ]{{0}};
    public static void Main()
    {
        var vr8 = s_3[0, 0] ^ (uint)M4();
        System.Console.WriteLine(vr8);
    }

    static sbyte M4()
    {
        s_2 = -127;
        return s_2;
    }
}