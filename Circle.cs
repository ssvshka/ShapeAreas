namespace ShapeAreas.Shapes;

public class Circle : Shape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double CalculateArea() 
    {
        if (IsShapeValid())
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }

    public override bool IsShapeValid() => _radius >= 0;
}
