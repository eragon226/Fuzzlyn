// Generated by Fuzzlyn on 2018-07-06 01:31:49
// Seed: 950980949091071317
// Reduced from 74.0 KiB to 0.2 KiB
// Debug: Outputs 65434
// Release: Outputs 4294967194
public class Program
{
    static sbyte[] s_1;
    public static void Main()
    {
        s_1 = new sbyte[]{-102};
        var vr17 = (ushort)(s_1[0] ^ 0L);
        uint vr21 = vr17;
        System.Console.WriteLine(vr21);
    }
}
