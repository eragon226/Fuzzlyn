// Generated by Fuzzlyn on 2018-07-03 12:39:35
// Seed: 8966071139204459769
// Reduced from 51.3 KiB to 0.2 KiB
// Debug: Outputs 65408
// Release: Outputs -128
public class Program
{
    static int[, ] s_4 = new int[, ]{{0}};
    static sbyte s_14 = -128;
    public static void Main()
    {
        char vr8 = (char)(s_14 | s_4[0, 0]);
        System.Console.WriteLine((int)vr8);
    }
}
