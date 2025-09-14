namespace Taller02DataStructure.Core;

public abstract class GeometricFigure
{
    public string Name { get; set; } = null!;

    public abstract double GetArea();
    public abstract double GetPerimeter();
    override public string ToString()
    {
        return $"{Name,-20} => Area.....: {GetArea(),20:N5}   Perimeter: {GetPerimeter(),20:N5}";
    }
}
