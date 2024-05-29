namespace HetRekenWonder;

internal class Program
{
    static void Main(string[] args)
    {
        WillemKlein wk = new WillemKlein();
        SimonVanDeMeer sm = new SimonVanDeMeer();

        //wk.Rekent(sm.Add, 4, 5);
        //wk.Rekent(sm.Subtract, 4, 5);   

        RekenDel d1 = sm.Add;
        d1 += sm.Subtract;
        d1 -= sm.Subtract;
        
        d1 +=  sm.Add;
        d1 += sm.Subtract;

        foreach (var method in d1.GetInvocationList()) 
        {
            Console.WriteLine(method.Method.Name);
        }


        int result = d1(1, 2);
        Console.WriteLine(result);
    }
}
