namespace DeWereld;


// Blauwdruk.
// Een type definitie.
internal class Lamp
{
    // Eigenschappen leggen vast in FIELDS
    private int _intensiteit = 100;
    public ConsoleColor _kleur = ConsoleColor.Yellow;
    private Guid id = Guid.NewGuid();

    // Access functies. Zo doet men het in andere talen, zoals C++, Java
    // in .NET gebruiken we hiervoor PROPERTIES
    //public void SetIntensiteit(int intensiteit)
    //{
    //    if (intensiteit >= 0 && intensiteit <= 5000)
    //    {
    //        _intensiteit = intensiteit;
    //    }
    //}
    //public int GetIntensiteit()
    //{
    //    return _intensiteit;
    //}

    // Properties. Om gecontroleerd toegang te krijgen tot de private fields.
    // Encapsulation.
    public int Intensiteit
    {
        get
        {
            return _intensiteit;
        }
        set
        {
            if (value >= 0 && value <= 5000)
            {
                _intensiteit = value;
            }
        }
    }

    // Gedrag leggen we vast in METHODS
    public void Aan()
    {
        Console.BackgroundColor = _kleur;
        Console.WriteLine($"De lamp ({id}) brandt met een intensiteit van {Intensiteit} lumen");     
    }
    public void Uit()
    {
        Console.WriteLine("De lamp is uit");
        Console.ResetColor();
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

    // Constructors zijn bedoeld om _fields_ van een initiele waarde te voorzien.
    //public Lamp(int intensiteit, ConsoleColor kleur)
    //{
    //    this.Intensiteit = intensiteit;
    //    _kleur = kleur;
    //}
    //public Lamp() : this(100, ConsoleColor.Yellow)
    //{
    //    //_kleur = ConsoleColor.White;
    //   // intensiteit = 100;
    //}
}
