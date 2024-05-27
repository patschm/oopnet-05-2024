namespace AdvStatics;

internal static class Utils
{
    public static Punt Add(Punt a, Punt b)
    {
        return a + b;
    }

    public static double Abs(this Punt e)
    {
        return Math.Sqrt(e.X * e.X + e.Y * e.Y);
    }
    public static void Display(this Punt p)
    {
        Console.WriteLine($"Extended ({p.X}, {p.Y})");
    }
    public static void SponsoredBy(this int x)
    {
        Console.WriteLine($"{x} wordt u aangeboden door Yunex");
    }
    public static void SponsoredBy(this long x)
    {
        Console.WriteLine($"{x} wordt u aangeboden door Yunex");
    }
}
