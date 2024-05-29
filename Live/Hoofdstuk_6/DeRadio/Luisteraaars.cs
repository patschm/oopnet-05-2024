namespace DeRadio;

internal class Luisteraars
{
    public static void ViaKabel(string msg)
    {
        Console.WriteLine($"Via kabel ontvangen: {msg}");
    }
    public static void ViaSMS(string msg)
    {
        Console.WriteLine($"Via sms ontvangen: {msg}");
    }
    public static void ViaMail(string msg)
    {
        Console.WriteLine($"Via mail ontvangen: {msg}");
    }
    public static void ViaRooksignalen(string msg)
    {
        Console.WriteLine($"Via rooksignalen ontvangen: {msg}");
    }
}
