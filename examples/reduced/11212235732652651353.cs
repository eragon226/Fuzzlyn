// Generated by Fuzzlyn on 2018-07-16 10:43:21
// Seed: 11212235732652651353
// Reduced from 35.9 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs 4294967295
public class Program
{
    static sbyte s_1 = -1;
    public static void Main()
    {
        var vr20 = (ushort)(2U | s_1);
        long vr21 = vr20;
        System.Console.WriteLine(vr21);
    }
}
