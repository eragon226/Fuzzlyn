// Generated by Fuzzlyn v1.1 on 2018-09-08 19:36:05
// Seed: 17146431463195631553
// Reduced from 142.5 KiB to 0.7 KiB in 00:02:50
// Debug: Outputs 0
// Release: Outputs 204
public class Program
{
    static long[][][] s_25 = new long[][][]{new long[][]{new long[]{-1}}};
    static ulong[] s_39 = new ulong[]{1};
    public static void Main()
    {
        M56(0, -1, s_39);
    }

    static void M56(ulong arg0, sbyte arg1, ulong[] arg2)
    {
        if (arg0 != arg2[0])
        {
            arg1 = (sbyte)(-1 ^ s_25[0][0][0]);
            arg0 = (ulong)(arg1 % 68);
        }
        else
        {
            try
            {
                uint[] var9 = new uint[]{0};
            }
            finally
            {
                System.Console.WriteLine(arg1);
            }
        }

        System.Console.WriteLine(arg0);
    }
}
