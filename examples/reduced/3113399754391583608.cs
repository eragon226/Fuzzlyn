// Generated by Fuzzlyn on 2018-07-04 11:41:10
// Seed: 3113399754391583608
// Reduced from 192.9 KiB to 0.2 KiB
// Debug: Outputs 129
// Release: Outputs 4294967169
public class Program
{
    static sbyte[] s_7 = new sbyte[]{-127};
    public static void Main()
    {
        byte vr9 = (byte)(s_7[0] | 1U);
        uint vr11 = vr9;
        System.Console.WriteLine(vr11);
    }
}
