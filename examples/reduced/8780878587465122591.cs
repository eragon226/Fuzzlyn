// Generated by Fuzzlyn on 2018-06-28 00:27:58
// Seed: 8780878587465122591
// Reduced from 46.5 KiB to 0.6 KiB
// Debug: Outputs -32768
// Release: Outputs 0
struct S0
{
    public short F0;
    public S0(short f0): this()
    {
        F0 = f0;
    }
}

struct S1
{
    public S0 F2;
    public S0 F3;
    public S0 F4;
    public S1(S0 f3): this()
    {
        F3 = f3;
    }
}

struct S3
{
    public S1 F3;
    public S3(S1 f3): this()
    {
        F3 = f3;
    }
}

public class Program
{
    static S3 s_3;
    static S3 s_11 = new S3(new S1(new S0(-32768)));
    public static void Main()
    {
        s_11.F3.F2 = M4();
        System.Console.WriteLine(s_11.F3.F3.F0);
    }

    static S0 M4()
    {
        return s_3.F3.F4;
    }
}
