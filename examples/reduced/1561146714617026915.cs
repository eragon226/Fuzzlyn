// Generated by Fuzzlyn v1.1 on 2018-09-04 15:02:54
// Seed: 1561146714617026915
// Reduced from 344.8 KiB to 0.5 KiB in 00:08:49
// Debug: Outputs -1
// Release: Outputs 3223
public class Program
{
    static short[, ][] s_8 = new short[, ][]{{new short[]{-1}}};
    static short s_56;
    public static void Main()
    {
        M75(s_56);
        System.Console.WriteLine(s_56);
    }

    static void M75(short arg0)
    {
        try
        {
            arg0 = 0;
        }
        finally
        {
            arg0 &= 1;
        }

        arg0 = s_8[0, 0][0];
        arg0 %= 7789;
        s_56 = arg0;
    }
}
