class Program{
    public static void Main(string[] args)
    {
        Futbols futbols = new Futbols(11, "FK Čočo", "Rastafari");
        futbols.SaktSacencibas();

        for (int i = 0; i < 5; i++)
        {
            futbols.UzvaretSpeli();
        }

        futbols.BeigtSacensibas();

        
    }
}