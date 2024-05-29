

namespace FoutenAfhandeling;

internal class Program
{
    static void Main(string[] args)
    {
        (int a, int b) tuple = VraagOmGetallen();

        try
        {
            double result = Divide(tuple.a, tuple.b);
            ToonResultaat(result);
            return;
        }
        catch(DelelDoorNulException x)
        {
            Console.WriteLine($"{x.FoutGetal} is fout");
            Console.WriteLine(x.StackTrace);
            Console.WriteLine(x.Message);
        }      
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Tenslotte..");
        }
    }

    private static void ToonResultaat(double result)
    {
        Console.WriteLine($"Het resultaat is {result}");
    }

    private static (int a, int b) VraagOmGetallen()
    {
        int a = VraagOmGetal("A");
        int b = VraagOmGetal("B");
        return (a, b);
    }

    private static int VraagOmGetal(string label)
    {
        do
        {
            Console.WriteLine($"Geef getal {label}");
            string? num = Console.ReadLine();
            try
            {
                int number = int.Parse(num!);
                return number;
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"{num} is geen getal");
            }
            catch(OverflowException)
            {
                Console.WriteLine($"Getal moet tussen {int.MinValue} en {int.MaxValue} liggen");
            }
            catch(Exception e)
            {
                Console.WriteLine($"[{e}] Hmm. Op mijn laptop werkt het wel!!!");
            }
        }
        while(true);
    }

    private static double Divide(int a, int b)
    {
        // Alleen als je fouten wilt loggen.
        // Persoonlijk zou ik dit niet doen.
        //try
        //{
        //    return a / b;
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine("We loggen " + e.Message);
        //    throw;
        //   // return 0;
        //}
        if (b == 0) throw new DelelDoorNulException { FoutGetal = 0 };
        //int res = a / b;
        return (double)a / b;
    }
}
