class RectangleColor : Rectangle{
    protected String color;
    public RectangleColor(String name, int x1, int y1, int x2, int y2, String color) 
    : base(name, x1, y1, x2, y2)
    {
        this.color = color;
    }

    public RectangleColor()
    : this("RectangleColor", 0, 0, 1, 1, "blue")
    {

    }

    public override void Display(){
        System.Console.WriteLine($"Name:{name}, Coordinates:(x1 = {x1}; y1 = {y1})(x2 = {x2}; y2 = {y2}), Color:{color}");
    }

    public override void Area(){
        base.Area();
    }
}