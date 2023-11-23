namespace Test_Task_Library;
/// <summary>
/// The abstract class "Shape" is open for extending with new figures
/// </summary>
public abstract class Shape
{
    /// <summary>
    /// Provides calculating of shape's area in derived classes
    /// </summary>
    /// <returns>shape's area</returns>
    public abstract double CalculateArea();
}
