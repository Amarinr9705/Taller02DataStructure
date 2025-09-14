﻿namespace Taller02DataStructure.Core;

public class Trapeze : Triangle
{
    private double _d;

    public Trapeze(string name, double a, double b, double c, double d, double h)
        : base(name, a, b, c, h)
    {
        D = d;
    }


    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }

    public override double GetArea() => (B + D) * H / 2;
    public override double GetPerimeter() => A + B + C + D;

    private double ValidateD(double d)
    {
        if (d <= 0)
        {
            throw new Exception("Side length must be greater than zero.");
        }
        return d;
    }
}