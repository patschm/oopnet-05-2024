namespace HetRekenWonder;

internal class Program
{
    static void Main(string[] args)
    {
        WillemKlein wk = new WillemKlein();
        SimonVanDeMeer sm = new SimonVanDeMeer();

        wk.Rekent(sm.Add);
    }
}
