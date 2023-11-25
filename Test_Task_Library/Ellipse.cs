namespace Test_Task_Library;
public class Ellipse : Shape
{
    protected readonly double _axis_a;
    protected readonly double _axis_b;

    //_epsilon fixes the problem of @double type's inaccuracy
    protected const double _epsilon = 1e-9;

    /// <summary>
    /// Initializes a new instance of the Ellipse with given semi-major and semi-minor axes.
    /// </summary>
    /// <param name="axis_a">the axis of the ellipse (must be greater than zero)</param>
    /// <param name="axis_b">the axis of the ellipse (must be greater than zero)</param>
    public Ellipse(double axis_a, double axis_b)
    {
        if (axis_b <= _epsilon || axis_a <= _epsilon) throw new ArgumentException("The axis must be greater than zero.");
        _axis_a = axis_a;
        _axis_b = axis_b;
    }

    /// <summary>
    /// Calculating the area of the ellipse using [S = PI * AXIS A * AXIS B] formula
    /// </summary>
    /// <returns>the area of the ellipse</returns>
    public override double CalculateArea()
    {
        return _axis_a * _axis_b * Math.PI;
    }
}

