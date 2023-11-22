namespace Test_Task_MSTest;

[TestClass]
public class CircleTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestConstructor_ZeroRadius()
    {
        Debug.WriteLine("Creating a circle with a zero radius leads to an exception");
        Shape circle = new Circle(0);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestConstructor_NegativeRadius()
    {
        Debug.WriteLine("Creating a circle with a negative radius leads to an exception");
        Shape circle = new Circle(-1);
    }

    [TestMethod]
    public void TestCalculateArea_BigRadius()
    {
        Shape circle = new Circle(1000000000);
        double actual = circle.CalculateArea();
        double expected = 3141592653589793238.46264;
        Assert.AreEqual(expected, actual, 1e-9);
        Debug.WriteLine($"Expected: {expected}");
        Debug.WriteLine($"Actual:   {actual}");
    }

    [TestMethod]
    public void TestCalculateArea_TinyRadius()
    {
        Shape circle = new Circle(1);
        double actual = circle.CalculateArea();
        double expected = 3.1415926535897932384626433832795;
        Assert.AreEqual(expected, actual, 1e-9);
        Debug.WriteLine($"Expected: {expected}");
        Debug.WriteLine($"Actual:   {actual}");
    }
}