namespace Test_Task_Library;
public class Ellipse : Shape
{
    protected readonly double axisA;
    protected readonly double axisB;

    /// <summary>
    /// Initializes a new instance of the Ellipse with given semi-major and semi-minor axes.
    /// Epsilon fixes the problem of @double type's inaccuracy
    /// </summary>
    /// <param name="axisA">the axis of the ellipse (must be greater than zero)</param>
    /// <param name="axisB">the axis of the ellipse (must be greater than zero)</param>
    public Ellipse(double axisA, double axisB)
    {
        if (axisA <= Constants.Epsilon || axisB <= Constants.Epsilon) throw new ArgumentException("The axis must be greater than zero.");
        this.axisA = axisA;
        this.axisB = axisB;
    }

    /// <summary>
    /// Calculating the area of the ellipse using [S = PI * AXIS A * AXIS B] formula
    /// </summary>
    /// <returns>the area of the ellipse</returns>
    public override double CalculateArea()
    {
        return axisA * axisB * Math.PI;
    }
}

