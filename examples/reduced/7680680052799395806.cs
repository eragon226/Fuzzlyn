// Generated by Fuzzlyn v1.1 on 2018-08-25 03:20:10
// Seed: 7680680052799395806
// Reduced from 213.8 KiB to 0.3 KiB
// Debug: Outputs -32767
// Release: Outputs 32769
public class Program
{
    static short s_3 = -32767;
    static int s_11;
    public static void Main()
    {
        var vr37 = new int[, ]{{0}};
        vr37[0, 0] = (int)(s_11 + (uint)M26());
        System.Console.WriteLine(vr37[0, 0]);
    }

    static short M26()
    {
        return s_3;
    }
}