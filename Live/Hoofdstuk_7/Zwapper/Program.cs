using System.Text;

namespace Zwapper;

internal class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = Create<StringBuilder>();
        sb.Append("1");

        Point<double> z = Create<Point<double>>();

        Point<float> a = new Point<float> { X = 10, Y = 20 };
        Point<float> b = new Point<float> { X = 100, Y = 200 };
        Console.WriteLine(a);
        DoeIets(ref a);
        Console.WriteLine(a);

        //int a = 10;
        //int b = 20;
        Console.WriteLine($"a={a}, b={b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a={a}, b={b}");
    }

    //private static void Swap(ref int aa, ref int bb)
    //{
    //    int tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //private static void Swap(ref long aa, ref long bb)
    //{
    //    long tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //private static void Swap(ref float aa, ref float bb)
    //{
    //    float tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    private static void Swap<T>(ref T aa, ref T bb) //where T: IFormattable
    {
        T tmp = aa;
        aa = bb;
        bb = tmp;
    }

    public static void DoeIets(ref Point<float> p1)
    {
        p1 = new Point<float> { X=100, Y=200 };
    }

    public static T Create<T>() where T: new()
    {
        return new T();
    }

}
