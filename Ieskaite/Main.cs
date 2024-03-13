class Program{
    public static void Main(string[] args)
    {
        Futbols futbols = new Futbols(11, "FK Čočo", "Rastafari");
        futbols.SaktSacencibas();

        for (int i = 0; i < 5; i++)
        {
            futbols.UzvaretSpeli();
        }
        futbols.Neizskirts();

        futbols.BeigtSacensibas();

        futbols.info();

        System.Console.WriteLine();
        
        Hokejs hokejs = new Hokejs(5, "Dinamo", "Rinalds");
        hokejs.SaktSacencibas();

        for (int i = 0; i < 5; i++)
        {
            hokejs.UzvaretSpeli();
        }
        hokejs.Neizskirts();

        hokejs.BeigtSacensibas();

        hokejs.info();
    }
}