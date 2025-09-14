namespace Taller02DataStructure.Core;

public class Triangle : Rectangle
{
    private double _c;
    private double _h;

    public Triangle(string name, double a, double b, double c, double h)
        : base(name, a, b)
    {
        C = c;
        H = h;      
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }
    public double C { 
        get => _c; 
        set => _c = ValidateC(value); 
    }

    public override double GetArea() => (B * H) /2;
    public override double GetPerimeter() => A + B + C;

    private double ValidateH(double b)
    {
        if (b <= 0)
        {
            throw new Exception("Side length must be greater than zero.");
        }
        return b;
    }

    private double ValidateC(double c)
    {
        if (c <= 0)
        {
            throw new Exception("Side length must be greater than zero.");
        }
        return c;
    }




}