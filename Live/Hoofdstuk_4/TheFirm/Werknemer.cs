
namespace TheFirm;

abstract class Werknemer : Persoon, IContract
{
    public void Werken()
    {
        Werkt();
    }

    public abstract void Werkt();
}
