using System.Drawing;

public class Program{
    public static void Main(string[] args){
        FigureDraw triangle = new Triangle();
        FigureDraw rectangle = new RectangleDraw();
        FigureDraw rombs = new Rombs();

        DrawFigure(triangle);
        DrawFigure(rectangle);
        DrawFigure(rombs);
    }

    static void DrawFigure(FigureDraw figure)
    {
        figure.Draw();
    }
}