namespace ShapeAreas.Shapes;

public class Triangle : Shape
{
    private readonly double A;
    private readonly double B;
    private readonly double C;

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public override double CalculateArea()
    {
        if (IsShapeValid())
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(
                p * (p - A) * (p - B) * (p - C));
        }
        else
        {
            throw new Exception();
        }
    }

    public override bool IsShapeValid() =>
        A >= 0 || B >= 0 || C >= 0;

    public bool IsRightAngled() =>
        C * C == A * A + B * B ||
        A * A == B * B + C * C ||
        B * B == A * A + C * C;
}