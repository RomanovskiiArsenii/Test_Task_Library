namespace Test_Task_MSTest;

[TestClass]
public class EllipseTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestConstructor_ZeroAxis()
    {
        Debug.WriteLine("Creating an ellipse with a zero axis leads to an exception");
        Shape ellipse = new Ellipse(1, 0);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestConstructor_NegativeAxis()
    {
        Debug.WriteLine("Creating an ellipse with a negative axis leads to an exception");
        Shape ellipse = new Ellipse(1, -1);
    }

    [TestMethod]
    public void TestCalculateArea_BigAxes()
    {
        Shape ellipse = new Ellipse(1000000000, 2000000000);
        double actual = ellipse.CalculateArea();
        double expected = 6283185307179586476.925286766559;
        Assert.AreEqual(expected, actual, 1e-9);
        Debug.WriteLine($"Expected: {expected}");
        Debug.WriteLine($"Actual:   {actual}");
    }

    [TestMethod]
    public void TestCalculateArea_TinyAxes()
    {
        Shape ellipse = new Ellipse(1, 2);
        double actual = ellipse.CalculateArea();
        double expected = 6.283185307179586476925286766559;
        Assert.AreEqual(expected, actual, 1e-9);
        Debug.WriteLine($"Expected: {expected}");
        Debug.WriteLine($"Actual:   {actual}");
    }
}