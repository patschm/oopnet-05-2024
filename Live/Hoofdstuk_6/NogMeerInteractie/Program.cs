namespace NogMeerInteractie;

internal class Program
{
    static void Main(string[] args)
    {
        Patrick p = new Patrick();
        Riaz r = new Riaz();

        // d = p.HaalKoffie;
       // d();

        //r.KanDingen(d);

        //r.KanDingen(p.HaalKoffie);

        r.KanDingen(DoeIets);

        //p.HaalKoffie();

        string s = "Hoi";
        int x = 42;
        KoffieDel dx = DoeIets;
    }

    static void DoeIets2()
    {
        Console.WriteLine("Patrick Zomaar in de wilde weg iets doen");
    }

    static void DoeIets(string msg)
    {
        Console.WriteLine($"Doet iets zegt: {msg}");
    }
}
