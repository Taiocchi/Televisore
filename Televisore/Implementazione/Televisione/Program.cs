using System;

class main
{
    static void Main()
    {
        Televisore s1 = new Televisore();

        s1.accendi();
        s1.cambia_canale(5);
        s1.cambia_volume(3);

        Televisore s2 = new Televisore();

        s2.accendi();
        s2.cambia_canale(10);
        s2.cambia_volume(10);
    }
}

class Televisore
{
    private int consumo;
    private bool stato;
    private int stato_canale;
    private int stato_volume;

    public void accendi()
    {
        stato = true;
    }
    public void spegni()
    {
        stato = false;
    }
    public void cambia_canale(int canale_nuovo)
    {
        stato_canale = canale_nuovo;
    }
    public void cambia_volume(int volume_nuovo)
    {
        stato_volume = volume_nuovo;
    }
}
