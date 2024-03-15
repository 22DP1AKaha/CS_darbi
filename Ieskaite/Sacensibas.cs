public abstract class Sacensibas{
    protected int dalibnieki;
    protected bool notiek;
    protected int punkti;
    protected String komanda1;
    protected String komanda2;
    protected int spelesuzvaretaskomanda1 = 0;
    protected int spelesuzvaretaskomanda2 = 0;
    protected int neizskirtasspeles = 0;

    public abstract void SaktSacencibas();
    public abstract void BeigtSacensibas();
    public abstract void UzvaretSpeli();
    public abstract int PirmasKomandasPunkti();
    public abstract int OtrasKomandasPunkti();
    public virtual void info(){}


}