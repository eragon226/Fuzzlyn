// Generated by Fuzzlyn on 2018-07-25 19:32:50
// Seed: 11293185453794297829
// Reduced from 15.5 KiB to 0.2 KiB
// Debug: Outputs 65505
// Release: Outputs 4294967265
public class Program
{
    static sbyte s_1;
    public static void Main()
    {
        s_1 = -32;
        char vr10 = (char)(1U | s_1);
        uint vr8 = vr10;
        System.Console.WriteLine(vr8);
    }
}
