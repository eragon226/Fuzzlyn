// Generated by Fuzzlyn on 2018-07-07 22:32:25
// Seed: 6879617782967969225
// Reduced from 197.5 KiB to 0.3 KiB
// Debug: Outputs 65415
// Release: Outputs -121
struct S0
{
    public sbyte F1;
    public S0(sbyte f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    static byte[, ] s_25 = new byte[, ]{{0}};
    static S0 s_31 = new S0(-121);
    public static void Main()
    {
        char vr12 = (char)(s_31.F1 | s_25[0, 0]);
        System.Console.WriteLine((int)vr12);
    }
}