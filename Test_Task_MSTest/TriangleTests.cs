namespace Test_Task_MSTest;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestTrianglePossibility_ImpossibleToConstruct()
    {
        Debug.WriteLine("If the length of each side of the triangle is more than " +
        "the sum of the two remaining sides, the triangle can not be constructed.");
        Triangle.ThrowExceptionIfTriangleIsNotPossible(1, 1, 4);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestTrianglePossibility_NegativeLength()
    {
        Debug.WriteLine("If the length of some side of the triangle is " +
                        "negative the triangle can not be constructed.");
        Triangle.ThrowExceptionIfTriangleIsNotPossible(1, -1, 4);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestTrianglePossibility_ZeroLength()
    {
        Debug.WriteLine("If the length of some side of the triangle is " +
                        "zero the triangle can not be constructed.");
        Triangle.ThrowExceptionIfTriangleIsNotPossible(1, 0, 4);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestConstructor_ImpossibleToConstruct()
    {
        Debug.WriteLine("If the length of each side of the triangle is more than " +
        "the sum of the two remaining sides, the triangle can not be constructed.");
        Shape triangle = new Triangle(10, 100, 10);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestConstructor_NegativeLength()
    {
        Debug.WriteLine("If the length of some side of the triangle is " +
                        "negative the triangle can not be constructed.");
        Shape triangle = new Triangle(10, -10, 10);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestConstructor_ZeroLength()
    {
        Debug.WriteLine("If the length of some side of the triangle is " +
                        "zero the triangle can not be constructed.");
        Shape triangle = new Triangle(10, 0, 10);
    }

    [TestMethod] 
    public void TestIsTriangleRight_True()
    {
        Debug.WriteLine("If the square of the hypotenuse is equal to the sum " +
            "of the squares of the legs, the triangle is considered right");
        Triangle triangle = new Triangle(9, 12, 15);
        Assert.IsTrue (triangle.IsTriangleRight());
    }

    [TestMethod]
    public void TestIsTriangleRight_False()
    {
        Debug.WriteLine("If the square of the hypotenuse is equal to the sum " +
            "of the squares of the legs, the triangle is considered right");
        Triangle triangle = new Triangle(10, 10, 17);
        Assert.IsFalse(triangle.IsTriangleRight());
    }

    [TestMethod]
    public void TestCalculateArea_10_10_10()
    {
        Triangle triangle = new Triangle(10, 10, 10);
        double actual = triangle.CalculateArea();
        double expected = 43.301270189221932338186158537647;
        Assert.AreEqual(actual, expected, Constants.Epsilon);
        Debug.WriteLine($"Expected: {expected}");
        Debug.WriteLine($"Actual:   {actual}");
    }

    [TestMethod]
    public void TestCalculateArea_01_01_01()
    {
        Triangle triangle = new Triangle(0.1, 0.1, 0.1);
        double actual = triangle.CalculateArea();
        double expected = 0.00433012701892219323381861585376;
        Assert.AreEqual(actual, expected, Constants.Epsilon);
        Debug.WriteLine($"Expected: {expected}");
        Debug.WriteLine($"Actual:   {actual}");
    }
}
