// Generated by Fuzzlyn on 2018-07-13 15:34:37
// Seed: 4129712600728399822
// Reduced from 131.5 KiB to 0.3 KiB
// Debug: Outputs 65512
// Release: Outputs 4294967272
public class Program
{
    static char[, ] s_1 = new char[, ]{{'d'}};
    static sbyte s_3 = -116;
    public static void Main()
    {
        ushort vr54 = (ushort)(s_1[0, 0] ^ s_3);
        ulong vr55 = vr54;
        System.Console.WriteLine(vr55);
    }
}