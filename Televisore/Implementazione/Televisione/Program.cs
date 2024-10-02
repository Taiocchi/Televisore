class main
{
    static void Main()
    {
        
    }
}

class Televisore
{
    int consumo;
    bool stato;
    int stato_canale;
    int stato_volume;

    void accendi()
    {
        stato = true;
    }
    void spegni()
    {
        stato = false;
    }
    void cambia_canale(int canale_nuovo)
    {
        stato_canale = canale_nuovo;
    }
    void cambia_volume(int volume_nuovo)
    {
        stato_volume = volume_nuovo;
    }
}
