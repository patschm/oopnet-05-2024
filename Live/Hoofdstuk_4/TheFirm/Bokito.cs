
namespace TheFirm;

// Bokito _IMPLENENTEERT_ de interface IContract
// Je kunt meerdere contracten implementeren.
internal class Bokito : IContract, IBankzitter
{
    // Expliciete implementatie.
    void IBankzitter.Werken()
    {
        Console.WriteLine("Bokito doet niks");
    }

    public void Werken()
    {
        Werkt();
    }   
    public void Werkt()
    {
        Console.WriteLine("Bokito ramt dames in elkaar");
    }
}
