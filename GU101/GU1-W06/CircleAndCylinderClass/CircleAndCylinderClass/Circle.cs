using System;

namespace CircleAndCylinderClass
{
    class Circle
    {
    private double radius;
    private string color;

    public Circle(double radius, string color)
    {
        this.radius = radius;
        this.color = color;
    }

    public double GetRadius()
    {
        return radius;
    }

    public void SetRadius(double radius)
    {
        this.radius = radius;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public override string ToString()
    {
        return $"Circle: Radius={radius}, Color={color}, Area={GetArea()}";
    }
}
}
