namespace DeRadio;

delegate void MsgDel(string s);

internal class RadioStation
{
    public event MsgDel luisteraars;


    //private MsgDel _listeners;
    //public event MsgDel Listeners
    //{
    //    add
    //    {
    //        _listeners += value;
    //    }
    //    remove
    //    {
    //        _listeners -= value;
    //    }
    //}

    public void Transmit()
    {
        Console.WriteLine("We gaan uitzenden");
        luisteraars("Hallo Allemaal");
        //luisteraars?.Invoke("Hallo allemaal");
    }
}
