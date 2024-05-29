namespace DeRadio;

internal class Program
{
    static void Main(string[] args)
    {
        RadioStation veronica = new RadioStation();
        veronica.luisteraars += Luisteraars.ViaKabel;
        veronica.luisteraars += Luisteraars.ViaSMS;
        veronica.luisteraars += Luisteraars.ViaRooksignalen;
        veronica.luisteraars += Luisteraars.ViaKabel;
        veronica.luisteraars += Luisteraars.ViaMail;
        veronica.luisteraars += Luisteraars.ViaRooksignalen;
        veronica.luisteraars += Luisteraars.ViaRooksignalen;

        veronica.Transmit();
    }
}
