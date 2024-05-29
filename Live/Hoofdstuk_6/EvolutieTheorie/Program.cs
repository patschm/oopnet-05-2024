using System.Threading.Channels;

namespace EvolutieTheorie;

delegate int MathDel(int x, int y);

internal class Program
{
    static void Main(string[] args)
    {
        // 2002. NET 1.0/1.1
        MathDel m1 = new MathDel(Add);
        int result = m1(2, 3);  // m1.Invoke()

        // 2005. .NET 2.0
        MathDel m2 = Add;
        result = m2(3, 4);

        int c = 100;
        MathDel m3 = delegate (int a, int b)
        {
            return a + b + c;
        };
        result = m3(4, 5);

        // 2007. .NET 3.0/3.5
        // Lambda's
        MathDel m4 = (a, b) => a + b;
        result = m4(5, 6);

        // Functions
        Func<int, int, int> f1 = Add;
        result = f1(6,7);

        // Procedures
        Action<int> a1 = Console.WriteLine;
        // a1(result);


        Console.WriteLine(result);

        m3 = Add2;

        int Add2(int a, int b)
        {
            return a + b;
        }


        //DemoGebruik();
    }

    private static void DemoGebruik()
    {
        var people = new Bogus.Faker<Person>()
            .RuleFor(p=>p.First, f=>f.Person.FirstName)
            .RuleFor(p => p.Last, f => f.Person.LastName)
            .RuleFor(p => p.Age, f => f.Random.Int(0, 123))
            .Generate(100).ToList();

        string first = Console.ReadLine();

        //var query = people.OrderBy(OrderByAge);
        var query = people.Where((p)=>p.First.StartsWith(first));
        foreach (var p in query)
        {
            Console.WriteLine($"{p.First} {p.Last} ({p.Age})");
        }
    }

    static bool FilterFirstByA(Person p)
    {
        return p.First.StartsWith("A");
    }
    static bool FilterFirstByB(Person p)
    {
        return p.First.StartsWith("B");
    }

    static int OrderByAge(Person person)
    {
        return person.Age;
    }

    static int Add(int a, int b)
    {
        return a + b;   
    }
}

public class Person
{
    public string? First { get; set; }
    public string? Last { get; set; }
    public int Age { get; set; }
}
