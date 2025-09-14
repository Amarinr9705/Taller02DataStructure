namespace Taller02DataStructure.Core;

public class Parallelogram : Rectangle
{
    private double _h;

    public Parallelogram(string name, double a, double b, double h)
        : base(name, a, b)
    {
        H = h;
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    public override double GetArea() => B * H;
    public override double GetPerimeter() => 2 * (A + B);

    private double ValidateH(double b)
    {
        if (b <= 0)
        {
            throw new Exception("Side length must be greater than zero.");
        }
        return b;
    }




}