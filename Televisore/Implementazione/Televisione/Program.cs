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

        /*
        Console.WriteLine("Stato S1: " + s1.stato);
        Console.WriteLine("Canale S1: " + s1.stato_canale);
        Console.WriteLine("Volume S1: " + s1.stato_volume);

        Console.WriteLine("Stato S2: " + s2.stato);
        Console.WriteLine("Canale S2: " + s2.stato_canale);
        Console.WriteLine("Volume S2: " + s2.stato_volume);
        */
    }
}

public class Televisore
{
    public int consumo;
    public bool stato;
    public int stato_canale;
    public int stato_volume;

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
