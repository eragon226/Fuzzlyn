// Generated by Fuzzlyn on 2018-07-12 09:40:02
// Seed: 7498959914993758459
// Reduced from 91.9 KiB to 0.3 KiB
// Debug: Outputs 65447
// Release: Outputs 4294967207
struct S0
{
    public short F6;
}

public class Program
{
    static S0 s_18;
    static sbyte s_23 = -89;
    public static void Main()
    {
        var vr30 = (char)((0L | s_18.F6) | s_23);
        uint vr34 = vr30;
        System.Console.WriteLine(vr34);
    }
}
