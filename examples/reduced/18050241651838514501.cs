// Generated by Fuzzlyn on 2018-07-25 08:09:01
// Seed: 18050241651838514501
// Reduced from 66.0 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    public static void Main()
    {
        var vr7 = new int[][, ]{new int[, ]{{0}}};
        var vr10 = (ushort)(vr7[0][0, 0] & 0);
        var vr11 = vr7[0][0, 0];
        vr7[0] = M3(0, vr10);
    }

    static int[, ] M3(ushort arg0, ushort arg2)
    {
        System.Console.WriteLine(arg0);
        return new int[, ]{{0}};
    }
}
