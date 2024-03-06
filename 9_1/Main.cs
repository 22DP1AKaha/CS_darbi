public class Program(){

    static void Main(string[] args) {
        Figure figureReference;

        Figure figure = new Figure("figure");
        Rectangle rectangle = new Rectangle();
        RectangleColor rectangleColor = new RectangleColor();

        DisplayPolimorfisms(figure);
        DisplayPolimorfisms(rectangle);
        DisplayPolimorfisms(rectangleColor);

    }

    
    static void DisplayPolimorfisms(Figure figure)
    {
        figure.Display();
    }
}