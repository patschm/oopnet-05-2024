namespace AnderType;

internal class Program
{
    static void Main(string[] args)
    {
        int dag = 2;

        WeekDag dag2 = WeekDag.Maandag;
        WeekDag dag3 = (WeekDag)3;

        Console.WriteLine(dag2);
        Console.WriteLine(dag3);
        Console.WriteLine((int)dag2);

        WeekDag xx = WeekDag.Maandag | WeekDag.Woensdag;
        Console.WriteLine(xx);

        WeekDag result = xx & WeekDag.Maandag;

        if ((xx & WeekDag.Maandag) == WeekDag.Maandag)
        {

        }
    }
}
