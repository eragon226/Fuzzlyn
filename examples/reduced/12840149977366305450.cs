// Generated by Fuzzlyn v1.1 on 2018-09-14 01:08:32
// Seed: 12840149977366305450
// Reduced from 299.6 KiB to 0.4 KiB in 00:06:47
// Debug: Outputs 0
// Release: Outputs 25
public class Program
{
    static sbyte s_48 = -1;
    static sbyte s_136;
    public static void Main()
    {
        M36(ref s_136, s_48);
    }

    static void M36(ref sbyte arg0, sbyte arg1)
    {
        try
        {
            arg1 = arg0;
            arg1 /= 50;
        }
        finally
        {
            arg1 *= arg1;
        }

        System.Console.WriteLine(arg1);
    }
}