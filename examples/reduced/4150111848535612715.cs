// Generated by Fuzzlyn v1.1 on 2018-09-01 11:22:37
// Seed: 4150111848535612715
// Reduced from 0.6 KiB to 0.2 KiB
// Debug: Outputs 2
// Release: Outputs -65534
public class Program
{
    public static void Main()
    {
        ushort[] vr0 = new ushort[]{0};
        vr0[0] = 65534;
        int vr1 = (byte)(0 - vr0[0]);
        System.Console.WriteLine(vr1);
    }
}
