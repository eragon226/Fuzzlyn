// Generated by Fuzzlyn on 2018-07-19 21:01:13
// Seed: 2182483255381615468
// Reduced from 129.2 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    public static void Main()
    {
        var vr34 = new int[][, ]{new int[, ]{{0}}};
        uint vr43 = (uint)('o' / ((0 & vr34[0][0, 0]) | 1));
        var vr44 = vr34[0][0, 0];
    }
}
