﻿namespace Taller02DataStructure.Core;

public class Rectangle : Square
{
    private double _b;

    public Rectangle(string name, double a, double b)
        : base(name, a)
    {
        B = b;
    }

    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    public override double GetArea() => A * B;
    public override double GetPerimeter() => 2 * (A + B);

    private double ValidateB(double b)
    {
        if (b <= 0)
        {
            throw new Exception("Side length must be greater than zero.");
        }
        return b;
    }




}