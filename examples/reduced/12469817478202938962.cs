// Generated by Fuzzlyn on 2018-07-18 08:04:05
// Seed: 12469817478202938962
// Reduced from 129.9 KiB to 0.2 KiB
// Debug: Outputs 65416
// Release: Outputs 4294967176
public class Program
{
    static sbyte s_2 = -119;
    public static void Main()
    {
        uint vr16 = (ushort)(1L ^ s_2);
        System.Console.WriteLine(vr16);
    }
}
