// Generated by Fuzzlyn on 2018-07-03 08:44:10
// Seed: 10445365782137726371
// Reduced from 36.5 KiB to 0.3 KiB
// Debug: Prints 0 line(s)
// Release: Prints 1 line(s)
public class Program
{
    static ushort s_4;
    static sbyte[, ] s_7 = new sbyte[, ]{{-41}};
    static bool[] s_9 = new bool[]{true};
    public static void Main()
    {
        bool vr5 = 0 > (ushort)(s_7[0, 0] | s_4);
        if (vr5)
        {
            System.Console.WriteLine(s_9[0]);
        }
    }
}
