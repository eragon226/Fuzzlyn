// Generated by Fuzzlyn on 2018-07-11 04:26:16
// Seed: 7066981279521501179
// Reduced from 142.4 KiB to 0.3 KiB
// Debug: Outputs 58
// Release: Outputs -198
public class Program
{
    public static void Main()
    {
        var vr37 = new sbyte[, ]{{-59}};
        int vr44 = (int)((uint)vr37[0, 0] ^ 9223372036854775807L);
        short vr38 = (short)vr44;
        System.Console.WriteLine((int)vr38);
    }
}