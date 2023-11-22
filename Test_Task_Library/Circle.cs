namespace Test_Task_Library;
public sealed class Circle : Shape
{
    private readonly double _radius;

    //_epsilon fixes the problem of @double type's inaccuracy
    private const double _epsilon = 1e-9;

    /// <summary>
    /// Initializes a new instance of the Circle class with given radius
    /// </summary>
    /// <param name="radius">the radius of the circle (must be greater than zero)</param>
    public Circle(double radius)
    {
        if (radius <= _epsilon) throw new ArgumentException("The radius must be greater than zero.");
        _radius = radius;
    }

    /// <summary>
    /// Calculating the area of the circle using [PI*R^2] formula
    /// </summary>
    /// <returns>the area of the circle</returns>
    public override double CalculateArea()
    {
        return _radius * _radius * Math.PI;
    }
}

