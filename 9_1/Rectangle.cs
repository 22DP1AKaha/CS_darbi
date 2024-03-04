using System.ComponentModel.DataAnnotations;

class Rectangle : Figure
{
    protected int x1,y1;
    protected int x2,y2;

    public Rectangle(String name, int x1, int y1, int x2, int y2) 
    : base(name){
        name = "Rectangle";
        this.x1 = x1;   
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    public Rectangle()
    : this("Rectangle", 0, 0, 1, 1)
    {
    }

    new public void Display(){
        System.Console.WriteLine($"Name:{name}, Coordinates:({x1}{y1})({x2},{y2})");
    }
    public void Area(){
        double width = Math.Abs(x2 - x1);
        double height = Math.Abs(y2 - y1);
        double area = width * height;
        System.Console.WriteLine($"Taisnstūra laukums ir:{area}");
    }
}