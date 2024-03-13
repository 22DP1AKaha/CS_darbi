public class Futbols : Sacensibas{
    private String komanda1;
    private String komanda2;
    public int SpelesUzvaretasKomanda1 = 0;
    public int SpelesUzvaretasKomanda2 = 0;
    public int NeizskirtasSpeles = 0;

    public Futbols(int DalibniekuSkaits, String komanda1, String komanda2) 
    {
        dalibnieki = DalibniekuSkaits;
        this.komanda1 = komanda1;
        this.komanda2 = komanda2;
    }
    public String Komanda1{
        get { return komanda1; }
    }
    public String Komanda2{
        get { return komanda2; }
    }
    public void UzvaretSpeli()
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

        System.Console.WriteLine($"{Komanda1} uzvarētās spēles: {SpelesUzvaretasKomanda1}");
        System.Console.WriteLine($"{Komanda2} uzvarētās spēles: {SpelesUzvaretasKomanda2}");
    }
    public void Neizskirts()
    {
        if (Notiek == true)
        {
            NeizskirtasSpeles++;
        }
        else
        {
            System.Console.WriteLine("Turnīrs nav sācies vai ir beidzies");
        }
    }
    
    private bool RandomResult()
    {
        Random random = new Random();
        return random.Next(2) == 0;
    }
    public override void SaktSacencibas()
    {
        Notiek = true;
        System.Console.WriteLine("Sacensības sākušās");
    }
    public override void BeigtSacensibas()
    {
        Notiek = false;
        System.Console.WriteLine("Sacensības beigušās");
    }
    public override void info()
    {
        System.Console.WriteLine($"Pirmā komanda: {Komanda1}");
        System.Console.WriteLine($"Otrā komanda: {Komanda2}");

    }
}