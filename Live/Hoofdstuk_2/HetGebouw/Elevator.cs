namespace HetGebouw;

public class Elevator
{
    private int huidigeEtage;

    public int HuidigeEtage
    {
        get { return huidigeEtage; }
    }

    public void Call(int etage)
    {
        Console.WriteLine($"De lift zoemt naar de {etage}e verdieping");
        huidigeEtage = etage;
    }
 

}