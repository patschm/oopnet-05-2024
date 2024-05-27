namespace HetGebouw;

internal class Etage
{
    public int EtageNr { get; set; }
    // Static (shared) member.
    // Static horen niet bij een object.
    // Dus via een instantie kan ik niet bij static members komen.
    // Statics worden ook wel class members genoemd. Dwz om bij zo'm member
    // te komen, moet ik de class naam specificeren.
    public static Elevator Lift { get; } = new Elevator();


    public void CallLift()
    {
        Etage.Lift.Call(this.EtageNr);
    }
    public void StatusLift()
    {
        Console.WriteLine($"De lift is nu op de {Lift.HuidigeEtage}e verdieping");

    }

    static Etage()
    {
        Console.WriteLine("Een keer");
    }
}
