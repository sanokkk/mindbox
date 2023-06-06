namespace MindBox;

public class Circle: IShape
{
    private double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Double.Pow(Radius, 2);
    }
}