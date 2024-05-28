namespace Overerving;


internal abstract class Lamp
{
    private int _intensiteit = 100;
    //private Guid id = Guid.NewGuid();

    protected Guid Id { get; } = Guid.NewGuid();

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
    public ConsoleColor Kleur { get; set; }

    // Polimorfisme is generaliseren met behoud van specifiek gedrag.
    // Met virtual maak ik het Aan-gedrag polymorf-ready.
    // Afgeleide classen kunnen _OPTIONEEL_ polymorfisme activeren.
    public  virtual void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De lamp ({id}) brandt met een intensiteit van {Intensiteit} lumen");
       // Uit();
    }
    // Met abstract is het vrijblijvende van overriden vervalt. De afgeleide class _MOET_ implementeren.
    public abstract void Uit();

   
    //public Lamp(int intensiteit, ConsoleColor kleur)
    //{
    //    this.Intensiteit = intensiteit;
    //    Kleur = kleur;
    //}
    //public Lamp() : this(100, ConsoleColor.Yellow)
    //{
    //}
}
