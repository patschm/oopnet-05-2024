namespace Overerving;

internal class TL : Lamp
{
    public int StartIntervals { get; set; } = 4;

    // Met override activeer ik polymorfisme.
    public override void Aan()
    {
        for(int i = 0; i < StartIntervals; i++)
        {
            Console.Write("Kniiperdeknipper");
            Thread.Sleep(200);
            //Task.Delay(200).Wait();
        }
        Console.Clear();
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De TL ({Id}) brandt met een intensiteit van {Intensiteit} lumen");
    }
    public override void Uit()
    {
        Console.WriteLine("De TL is uit");
        Console.ResetColor();
    }
    
    //public TL(int intensiteit, ConsoleColor kleur) : base(intensiteit, kleur)
    //{

    //}
}
