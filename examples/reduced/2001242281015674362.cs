// Generated by Fuzzlyn v1.1 on 2018-08-04 06:40:29
// Seed: 2001242281015674362
// Reduced from 138.2 KiB to 0.3 KiB
// Debug: Outputs 4294967041
// Release: Outputs 1
public class Program
{
    static int s_32;
    public static void Main()
    {
        var vr11 = s_32--;
        var vr18 = new long[]{0};
        vr18[0] = (4294967295U * (byte)M60());
        System.Console.WriteLine(vr18[0]);
    }

    static ref int M60()
    {
        return ref s_32;
    }
}
