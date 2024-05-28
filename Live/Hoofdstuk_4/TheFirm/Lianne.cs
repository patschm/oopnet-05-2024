namespace TheFirm;

class Lianne : Werknemer
{
    public void DoetIetsVreemds()
    {
        Console.WriteLine("Lianne maakt glazen kapot");
    }

    
    public override void Werkt()
    {
        DoetIetsVreemds();
    }
}
