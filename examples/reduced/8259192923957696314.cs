// Generated by Fuzzlyn on 2018-06-29 12:39:00
// Seed: 8259192923957696314
// Reduced from 16.4 KiB to 0.2 KiB
// Debug: Outputs 48255
// Release: Outputs -17281
public class Program
{
    static short s_2 = -17281;
    public static void Main()
    {
        char vr10 = (char)(0U | s_2);
        System.Console.WriteLine((int)vr10);
    }
}
