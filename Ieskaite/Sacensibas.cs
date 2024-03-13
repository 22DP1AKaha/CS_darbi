public abstract class Sacensibas{
    protected int dalibnieki;
    protected bool notiek;
    public int DalibniekuSkaits
    {
        get { return dalibnieki; }
    }
    public bool Notiek
    {
        get { return notiek; }
        set { notiek = value; }
    }

    public abstract void SaktSacencibas();
    public abstract void BeigtSacensibas();

    public virtual void info(){}


}