class Hokejs : Sacensibas
{
    
    public int SpelesUzvaretasKomanda1 = 0;
    public int SpelesUzvaretasKomanda2 = 0;
    public int NeizskirtasSpeles = 0;

    public Hokejs(int DalibniekuSkaits, String Komanda1, String Komanda2) 
    {
        dalibnieki = DalibniekuSkaits;
        komanda1 = Komanda1;
        komanda2 = Komanda2;
    }
    public override void UzvaretSpeli()
    {
        if (Notiek == true)
        {
            if (RandomResult())
            {
                System.Console.WriteLine($"{Komanda1} uzvarēja spēli");
                SpelesUzvaretasKomanda1++;
            }
            else
            {
                System.Console.WriteLine($"{Komanda2} uzvarēja spēli");
                SpelesUzvaretasKomanda2++;
            }
        }
        else
        {
            System.Console.WriteLine("Turnīrs nav sācies vai ir beidzies");
        }

        // System.Console.WriteLine($"{Komanda1} uzvarētās spēles: {SpelesUzvaretasKomanda1}");
        // System.Console.WriteLine($"{Komanda2} uzvarētās spēles: {SpelesUzvaretasKomanda2}");
    }
    public override void Neizskirts()
    {
        if (Notiek == true)
        {
            NeizskirtasSpeles++;
            System.Console.WriteLine("Komandas nospēlēja neizšķirti");
        }
        else
        {
            System.Console.WriteLine("Turnīrs nav sācies vai ir beidzies");
        }
    }
    public override int PirmasKomandasPunkti()
    {
        punkti = SpelesUzvaretasKomanda1*3 + NeizskirtasSpeles*1;
        return punkti;
    }
    public override int OtrasKomandasPunkti()
    {
        punkti = SpelesUzvaretasKomanda2*3 + NeizskirtasSpeles*1;
        return punkti;
    }

    private bool RandomResult()
    {
        Random random = new Random();
        return random.Next(2) == 0;
    }
    public override void SaktSacencibas()
    {
        Notiek = true;
        System.Console.WriteLine("Hokeja sacensības sākušās");
    }
    public override void BeigtSacensibas()
    {
        Notiek = false;
        System.Console.WriteLine("Futbola sacensības beigušās");
    }
    public override void info()
    {
        System.Console.WriteLine($"Pirmā komanda: {Komanda1}; Spēļu vēsture (W/D/L): {SpelesUzvaretasKomanda1}|{NeizskirtasSpeles}|{SpelesUzvaretasKomanda2}; Punkti: {PirmasKomandasPunkti()}");
        System.Console.WriteLine($"Otrā komanda: {Komanda2}; Spēļu vēsture (W/D/L): {SpelesUzvaretasKomanda2}|{NeizskirtasSpeles}|{SpelesUzvaretasKomanda1}; Punkti: {OtrasKomandasPunkti()} ");
    }

}