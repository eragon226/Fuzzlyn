// Generated by Fuzzlyn on 2018-07-21 16:46:47
// Seed: 5886185199415407924
// Reduced from 120.2 KiB to 0.2 KiB
// Debug: Outputs 0
// Release: Outputs 65535
public class Program
{
    static ushort[] s_7 = new ushort[]{0};
    public static void Main()
    {
        s_7[0] = 65535;
        s_7[0] >>= -1;
        ushort vr13 = s_7[0];
        System.Console.WriteLine(vr13);
    }
}