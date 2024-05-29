namespace NogMeerInteractie;

// Blauwdruk van een functie zonder argumenten die niks teruggeeft.
// DIT IS EEN TYPE DEFINITIE
delegate void KoffieDel(string s);

internal class Riaz
{
    public void KanDingen(KoffieDel argument)
    {
        Console.WriteLine("Riaz gaat het volgende doen");
        argument("Ik ben Riaz");
    }
}
