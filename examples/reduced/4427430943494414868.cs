// Generated by Fuzzlyn on 2018-07-13 02:46:30
// Seed: 4427430943494414868
// Reduced from 6.8 KiB to 0.2 KiB
// Debug: Outputs 50752
// Release: Outputs 64
public class Program
{
    public static void Main()
    {
        ushort[] vr4 = new ushort[]{50752};
        bool vr5 = (0 % (sbyte)vr4[0]) != 'u';
        vr4[0] = vr4[0];
        System.Console.WriteLine(vr4[0]);
    }
}