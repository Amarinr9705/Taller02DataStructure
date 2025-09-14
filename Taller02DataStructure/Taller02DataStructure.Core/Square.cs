namespace Taller02DataStructure.Core;

public class Square : GeometricFigure
{
    private double _a;

    public Square(string name, double a)
    {
        Name = name;
        A = a;
    }

    public double A 
    { 
        get => _a; 
        set => _a = ValidateA(value); 
    }

    public override double GetArea() => Math.Pow(A, 2);
    public override double GetPerimeter() => 4 * A;

    private double ValidateA(double a)
    {
        if (a <= 0)
        {
            throw new Exception("Side length must be greater than zero.");
        }
        return a;
    }




}
