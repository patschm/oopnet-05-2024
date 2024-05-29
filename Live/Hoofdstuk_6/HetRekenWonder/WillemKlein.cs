namespace HetRekenWonder;

delegate int RekenDel(int a, int b);


internal class WillemKlein
{
    public void Rekent(RekenDel cal, int a, int b)
    {
        Console.WriteLine("Willem Klein rekent");
        int res = cal(a,b);


        Console.WriteLine($"Het resultaat is {res}");
    }
}
