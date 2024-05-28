using Standaarden;

namespace Logitech;

public class Camera : IDetectable
{
    public void Detecting()
    {
        Start();
    }

    public void Start()
    {
        Console.WriteLine("De camera neemt op en streamt naar Dumpert");
    }
}
