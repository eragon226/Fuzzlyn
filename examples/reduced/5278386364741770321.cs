// Generated by Fuzzlyn on 2018-07-06 05:59:32
// Seed: 5278386364741770321
// Reduced from 42.2 KiB to 0.3 KiB
// Debug: Outputs 65482
// Release: Outputs -54
public class Program
{
    static sbyte s_1;
    public static void Main()
    {
        short vr6 = 1994;
        var vr7 = (sbyte)vr6;
        s_1 = vr7;
        char vr10 = (char)(0U ^ s_1);
        System.Console.WriteLine((int)vr10);
    }
}
