// Generated by Fuzzlyn v1.1 on 2018-09-14 00:54:37
// Seed: 14780483728344712755
// Reduced from 436.6 KiB to 0.6 KiB in 00:13:45
// Debug: Outputs -1
// Release: Outputs 10661
public class Program
{
    static sbyte s_5;
    static byte[] s_14;
    static short s_95;
    public static void Main()
    {
        byte[] vr6 = M102(s_95);
    }

    static byte[] M102(short arg0)
    {
        uint var8 = default(uint);
        try
        {
            System.Console.WriteLine(var8);
        }
        finally
        {
            System.Console.WriteLine(arg0);
        }

        ulong vr9 = (ulong)(-1 | s_5);
        arg0 = (short)vr9;
        arg0 %= 27437;
        System.Console.WriteLine(arg0);
        return s_14;
    }
}