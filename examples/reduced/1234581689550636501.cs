// Generated by Fuzzlyn on 2018-07-10 08:39:00
// Seed: 1234581689550636501
// Reduced from 123.4 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ulong[, ] s_1 = new ulong[, ]{{0}};
    public static void Main()
    {
        ulong vr16 = 0 / ((0 & s_1[0, 0]) | 1);
        short vr17 = (short)s_1[0, 0];
    }
}
