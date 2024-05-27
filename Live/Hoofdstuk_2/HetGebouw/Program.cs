namespace HetGebouw;

internal class Program
{
   // public static Elevator badLift = new Elevator();

    static void Main(string[] args)
    {
        // Elevator l = new Elevator();
        Console.WriteLine(Etage.Lift.HuidigeEtage);


        Etage[] flat = new Etage[75];
        for (int i = 0; i < flat.Length; i++)
        {
            flat[i] = new Etage { EtageNr = i};
        }

        flat[34].CallLift();

        foreach(Etage et in flat)
        {
            Etage.StatusLift();
            //et.StatusLift();
        }
    }
}
