namespace TheFirm;

internal class Program
{
    static void Main(string[] args)
    {
        ACME acme = new ACME();
        Lianne lianne = new Lianne();
        Leroy leroy = new Leroy();
        Bokito bokito = new Bokito();

        acme.Hire(lianne);
        acme.Hire(leroy);
        acme.Hire(bokito);
        
        acme.Start();

        //bokito.Werken();
        //IBankzitter bz = bokito;
        //bz.Werken();
    }
}
