namespace AdvStatics;

internal class Program
{
    static void Main(string[] args)
    {
        Punt p1 = new Punt { X= 10, Y= 20 };
        Punt p2 = new Punt { X= 100, Y= 200 };

        //Punt p3 = Punt.TelOp(p1, p2);
        Punt p3 = p1 + p2;
        Punt p4 = p3.TelOpBij(p1);

        Punt p5 = Utils.Add(p1, p2);

        p1.Display();
        p2.Display();
        p3.Display();

        double x = p5.Abs();

        double xxx = Utils.Abs(p1);
        Console.WriteLine(p5.Abs());
        Console.WriteLine(xxx);
    }
}
