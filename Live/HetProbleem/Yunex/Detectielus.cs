using Standaarden;

namespace Yunex;

public class Detectielus
{
    private List<IDetectable> devices = new List<IDetectable>();
    public event Action Detected;
    //public event EventHandler Detecting;

    public void Connect(IDetectable device)
    {
        devices.Add(device);
    }

    public void Detect()
    {
        Console.WriteLine("Hmmmm, we zien iets...");
        foreach (IDetectable device in devices)
        {
            device.Detecting();
        }
        Detected?.Invoke();
    }
}
