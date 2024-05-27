namespace Nullbaar;

internal class Program
{
    static void Main(string[] args)
    {
       // Nullable<int> age2;
        int? age = null;

        if (age.HasValue)
            Console.WriteLine(age.Value);

        Console.WriteLine(age.HasValue ? age.Value : 42);

        Console.WriteLine(age ?? 42);


        string? name = null;

        //if (name != null)
        Console.WriteLine(name!.Length);
    }
}
