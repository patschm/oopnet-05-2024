namespace TheFirm;

class Leroy : Werknemer
{
    public override void Werkt()
    {
        WerktOpLaptop();
    }

    public void WerktOpLaptop()
    {
        Console.WriteLine("Het product werkt alleen bij Leroy");
    }
}
