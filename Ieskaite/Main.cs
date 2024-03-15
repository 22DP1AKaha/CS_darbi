class Program{
    public static void Main(string[] args)
    {
        Sacensibas futbols = new Futbols(11, "FK Čočo", "Rastafari");
        futbols.SaktSacencibas();

        for (int i = 0; i < 5; i++) {
            futbols.UzvaretSpeli();
        }

        futbols.BeigtSacensibas();

        futbols.info();

        System.Console.WriteLine();
        
        Sacensibas hokejs = new Hokejs(5, "Dinamo", "Rinalds");
        hokejs.SaktSacencibas();

        for (int i = 0; i < 5; i++) {
            hokejs.UzvaretSpeli();
        }

        hokejs.BeigtSacensibas();

        hokejs.info();
    }
}