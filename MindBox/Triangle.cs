namespace MindBox;

public class Triangle: IShape
{
    private double A, B, C;

    public Triangle(double c, double b, double a)
    {
        C = c;
        B = b;
        A = a;
    }

    public double GetArea()
    {
        double semiPerimtr = (A + B + C) / 2;

        return Math.Sqrt(semiPerimtr * (semiPerimtr - A) * (semiPerimtr - B) * (semiPerimtr - C));
    }

    public bool isRectangular()
    {
        double aPow = Math.Pow(A, 2);
        double bPow = Math.Pow(B, 2);
        double cPow = Math.Pow(C, 2);

        if (aPow == bPow + cPow || bPow == aPow + cPow || cPow == aPow + bPow)
            return true;
        return false;
    }
}