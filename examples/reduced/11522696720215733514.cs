// Generated by Fuzzlyn on 2018-07-16 15:08:20
// Seed: 11522696720215733514
// Reduced from 221.1 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C1
{
    public sbyte F0;
}

public class Program
{
    public static void Main()
    {
        var vr13 = new sbyte[][]{new sbyte[]{0}};
        var vr14 = new C1[][, ]{new C1[, ]{{new C1()}}};
        int vr12 = vr14[0][0, 0].F0 & 0;
        vr13[0][0] = vr14[0][0, 0].F0;
        System.Console.WriteLine(vr12);
    }
}