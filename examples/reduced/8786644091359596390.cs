// Generated by Fuzzlyn v1.1 on 2018-08-14 17:48:23
// Seed: 8786644091359596390
// Reduced from 14.2 KiB to 0.2 KiB
// Debug: Outputs 71
// Release: Outputs 185
public class Program
{
    public static void Main()
    {
        ushort[] vr7 = new ushort[]{65535};
        byte vr8 = (byte)(0 - (vr7[0] / 94));
        System.Console.WriteLine(vr8);
    }
}