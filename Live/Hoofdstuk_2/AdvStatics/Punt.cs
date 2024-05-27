namespace AdvStatics;

internal class Punt
{
    public int X { get; set; }
    public int Y { get; set; }

    public static Punt operator+(Punt a, Punt b)
    {
        return new Punt { X = a.X + b.X, Y = a.Y + b.Y };
    }

    public Punt TelOpBij(Punt c)
    {
        return new Punt { X = this.X + c.X, Y = this.Y + c.Y };
    }

    
    public void Display()
    {
        Console.WriteLine($"({X}, {Y})");
    }
}
