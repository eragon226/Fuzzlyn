// Generated by Fuzzlyn on 2018-06-29 12:20:49
// Seed: 4408123394336947238
// Reduced from 27.5 KiB to 0.2 KiB
// Debug: Outputs 195
// Release: Outputs 4294967235
public class Program
{
    static sbyte s_6 = -61;
    public static void Main()
    {
        byte vr28 = (byte)(s_6 | 1U);
        ulong vr30 = vr28;
        System.Console.WriteLine(vr30);
    }
}
