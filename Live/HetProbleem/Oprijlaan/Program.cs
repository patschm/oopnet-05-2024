using DoomsdayPreppers;
using Heras;
using Logitech;
using Yunex;

namespace Oprijlaan;

internal class Program
{
    static void Main(string[] args)
    {
        Detectielus lus = new Detectielus();
        Hek hek = new Hek();
        Camera cam = new Camera();
        Valkuil kuil = new Valkuil();

        lus.Connect(cam);
        lus.Connect(hek);
        lus.Connect(kuil);

        lus.Detect();
       
    }
}
