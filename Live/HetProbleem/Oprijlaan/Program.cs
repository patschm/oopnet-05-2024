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

        //lus.Connect(cam);
        //.Connect(hek);
        //lus.Connect(kuil);

        lus.Detected += cam.Start;
        lus.Detected += hek.Open;
        lus.Detected += kuil.Open;

        lus.Detect();
       
    }
}
