// Generated by Fuzzlyn v1.1 on 2018-09-17 22:38:23
// Seed: 12903150374879102769
// Reduced from 98.4 KiB to 0.6 KiB in 00:01:26
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public long F1;
    public S0(long f1): this()
    {
        F1 = f1;
    }
}

struct S1
{
    public S0 F0;
    public S1(S0 f0): this()
    {
        F0 = f0;
    }
}

struct S2
{
    public short F0;
    public S1 F1;
    public S2(S1 f1): this()
    {
        F1 = f1;
    }
}

struct S3
{
    public S2 F0;
    public S3(S2 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    public static void Main()
    {
        S3 vr5 = new S3(new S2(new S1(new S0(1))));
        var vr6 = vr5.F0.F1.F0.F1;
        System.Console.WriteLine(vr6);
    }
}