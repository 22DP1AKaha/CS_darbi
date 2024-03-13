public abstract class Sacensibas{
    protected int dalibnieki;
    protected bool notiek;
    protected int punkti;
    protected String komanda1;
    protected String komanda2;
    public int DalibniekuSkaits
    {
        get { return dalibnieki; }
    }
    public String Komanda1
    {
        get { return komanda1; }
    }
    public String Komanda2
    {
        get { return komanda2; }
    }
    public bool Notiek
    {
        get { return notiek; }
        set { notiek = value; }
    }
    protected int Punkti
    {
        get { return punkti; }
        set { punkti = value; }
    }

    public abstract void SaktSacencibas();
    public abstract void BeigtSacensibas();
    public abstract void UzvaretSpeli();
    public abstract void Neizskirts();
    public abstract int PirmasKomandasPunkti();
    public abstract int OtrasKomandasPunkti();
    public virtual void info(){}


}