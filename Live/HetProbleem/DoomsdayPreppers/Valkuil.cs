using Standaarden;

namespace DoomsdayPreppers;

public class Valkuil : IDetectable
{
    public void Detecting()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("De valkuil met spiezen opent...");
    }
}
