namespace DeWereld;

internal class Program
{
    static void Main(string[] args)
    {
        // Big bang
        // l1 is een object dat leeft. Wordt ook wel eens een instantie van Lamp genoemd.
        Lamp l1 = new Lamp();
        //l1.intensiteit = 100;
       // l1._kleur = ConsoleColor.Yellow;
        l1.Aan();
        l1.DimUp();

        l1.Uit();


        Lamp l2 = new Lamp { Intensiteit = 150, _kleur = ConsoleColor.Red}; //(200, ConsoleColor.Red);
        //l2.intensiteit = 100;
        //l2._kleur = ConsoleColor.Red;
        l2.Aan();
        l2.DimUp();

        l2.Uit();

        Lamp l3 = new Lamp { Intensiteit = 100, _kleur = ConsoleColor.Green }; //(200, ConsoleColor.Red);
        l3.Intensiteit = 2_000;
        l3.Aan();
        l3.DimDown();

        l3.Uit();


        // Big crunch
    }
}
