namespace TheFirm;

internal class ACME
{
    private List<IContract> werknemers = new List<IContract>();

    public void Hire(IContract l)
    {
        werknemers.Add(l);
    }
    public void Start()
    {
        Console.WriteLine("De stoomfluit gaat af. ACME gaat produceren");
        foreach(IContract w in werknemers) 
        {
            w.Werken();
        }
    }
}
