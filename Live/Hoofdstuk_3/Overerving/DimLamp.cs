namespace Overerving;

internal class DimLamp: Lamp
{
    public void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De Dimlamp ({Id}) brandt met een intensiteit van {Intensiteit} lumen");
    }
    public void DimUp()
    {
        Intensiteit++;
        Console.WriteLine($"De intensiteit is nu {Intensiteit}");
    }
    public void DimDown()
    {
        Intensiteit--;
        Console.WriteLine($"De intensiteit is nu {Intensiteit}");
    }

    public override void Uit()
    {
        Console.WriteLine("De DimLamp is nu uit");
    }
}
