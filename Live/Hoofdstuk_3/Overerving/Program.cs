namespace Overerving;

internal class Program
{
    static void Main(string[] args)
    {

        // Generaliseren!!!
        Lamp t1 = new TL { StartIntervals = 3 };
        //(t1 as TL)?.StartIntervals
        t1.Kleur = ConsoleColor.DarkRed;
        ZetAan(t1);
        t1.Uit();

        Lamp d1 = new DimLamp { Kleur = ConsoleColor.Magenta };
        //d1.Aan();
        ZetAan(d1);
        //if (d1 is DimLamp)
        (d1 as DimLamp)?.DimUp();
        ZetAan(d1);
        //d1.Aan();
        //d1.DimDown();

        //Lamp l1 = new Lamp { Kleur = ConsoleColor.Yellow };
        //l1.Aan();
        //ZetAan(l1);
    }

    static void ZetAan(Lamp d)
    {
        d.Aan();
    }
}
