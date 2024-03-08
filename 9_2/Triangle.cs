public class Triangle : FigureDraw
{   
    private int width;
    private int height;
    public Triangle(int width)
    {
        this.width = width;
        height = width;
    }
    
    public Triangle()
    {
        width = 4;
        height = width;
    }

    public override void Draw()
    {
        Console.WriteLine("\nZīmē trijstūri:");
        Console.WriteLine();
        for (int i = 0; i < height; i++)
        {
            for (int j = width - i; j > 0; j--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}