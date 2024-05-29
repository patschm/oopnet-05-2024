

using System.Diagnostics;
using System.Text;

namespace Tekenen;

internal class Program
{
    static void Main(string[] args)
    {
        //DateTime
        HetLooptUitDeKlauwen();


        Point p1 = new Point { X=10, Y=20 };
        Console.WriteLine(p1);
        DoeIets(p1);
        Console.WriteLine(p1);
    }

    private static void HetLooptUitDeKlauwen()
    {
        Stopwatch stopwatch = new Stopwatch();
        //string s = "";
        StringBuilder s = new StringBuilder();
        stopwatch.Start();  
        for(int i = 0;i < 100000;i++)
        {
            //s += i.ToString();
            s.Append(i);
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.Elapsed);
    }

    private static void DoeIets(Point ppp)
    {
        ppp.X = 100;
        ppp.Y = 200;
    }
}
