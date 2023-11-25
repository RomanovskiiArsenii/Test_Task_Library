namespace Test_Task_Library;

//Circles are ellipses whose major and minor axes have the same length.
public class Circle : Ellipse
{
    /// <summary>
    /// Initializes a new instance of the Circle with given radius
    /// </summary>
    /// <param name="radius">the radius of the circle (must be greater than zero)</param>
    public Circle(double radius) : base(radius, radius) { }
}
