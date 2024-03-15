public class Futbols : Sacensibas
{
    public Futbols(int dalibnieki, String komanda1, String komanda2) 
    {
        this.dalibnieki = dalibnieki;
        this.komanda1 = komanda1;
        this.komanda2 = komanda2;
    }
    public override void UzvaretSpeli()
    {
        if (notiek == true)
        {
            if (RandomResult() == 1)
            {
                System.Console.WriteLine($"{komanda1} uzvarēja spēli!");
                spelesuzvaretaskomanda1++;
            }
            else if (RandomResult() == 2)
            {
                System.Console.WriteLine($"{komanda2} uzvarēja spēli!");
                spelesuzvaretaskomanda2++;
            }
            else
            {
                System.Console.WriteLine("Komandas nospēlēja neizšķirti!");
                neizskirtasspeles++;
            }
        }
        else
        {
            System.Console.WriteLine("Turnīrs nav sācies vai ir beidzies");
        }
    }
  
    public override int PirmasKomandasPunkti()
    {
        punkti = spelesuzvaretaskomanda1*3 + neizskirtasspeles*1;
        return punkti;
    }
    public override int OtrasKomandasPunkti()
    {
        punkti = spelesuzvaretaskomanda2*3 + neizskirtasspeles*1;
        return punkti;
    }

    private int RandomResult()
    {
    Random random = new Random();
    return random.Next(1, 3); 
    }
    public override void SaktSacencibas()
    {
        notiek = true;
        System.Console.WriteLine("Futbola sacensības sākušās");
    }
    public override void BeigtSacensibas()
    {
        notiek = false;
        System.Console.WriteLine("Futbola sacensības beigušās");
    }
    public override void info()
    {
        System.Console.WriteLine($"\nPirmā komanda: {komanda1}; Spēļu vēsture (W/D/L): {spelesuzvaretaskomanda1}|{neizskirtasspeles}|{spelesuzvaretaskomanda2}; Punkti: {PirmasKomandasPunkti()}");
        System.Console.WriteLine($"Otrā komanda: {komanda2}; Spēļu vēsture (W/D/L): {spelesuzvaretaskomanda2}|{neizskirtasspeles}|{spelesuzvaretaskomanda1}; Punkti: {OtrasKomandasPunkti()} ");
    }
}