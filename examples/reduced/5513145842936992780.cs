// Generated by Fuzzlyn v1.1 on 2018-09-10 07:11:15
// Seed: 5513145842936992780
// Reduced from 185.4 KiB to 0.5 KiB in 00:06:13
// Debug: Outputs 0
// Release: Outputs -2
public class Program
{
    static ulong s_32;
    static short s_45;
    public static void Main()
    {
        ulong vr7 = M50(-1);
        System.Console.WriteLine(s_45);
    }

    static ref ulong M50(short arg0)
    {
        bool var0 = default(bool);
        try
        {
            System.Console.WriteLine(var0);
        }
        finally
        {
            arg0 = arg0++;
        }

        arg0++;
        arg0 %= (-32768 | 1);
        s_45 = arg0;
        return ref s_32;
    }
}