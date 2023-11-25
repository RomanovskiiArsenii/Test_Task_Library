namespace Test_Task_Library;
public sealed class Triangle : Shape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    /// <summary>
    /// Initializes a new instance of the Triangle class with given side lengths
    /// </summary>
    /// <param name="sideA">the side length A (must be greater than zero)</param>
    /// <param name="sideB">the side length B (must be greater than zero)</param>
    /// <param name="sideC">the side length C (must be greater than zero)</param>
    public Triangle(double sideA, double sideB, double sideC)
    {
        ThrowExceptionIfTriangleIsNotPossible(sideA, sideB, sideC);

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    /// <summary>
    /// Calculating the area of the triangle using Heron's formula
    /// </summary>
    /// <returns>the area of the triangle</returns>
    public override double CalculateArea()
    {
        double semiPerimeter = (_sideA + _sideB + _sideC) / 2;

        return Math.Sqrt(semiPerimeter *
                        (semiPerimeter - _sideA) *
                        (semiPerimeter - _sideB) *
                        (semiPerimeter - _sideC));

        //I don't see any particular need for different calculations
        //for right triangles or isosceles triangles. Heron's formula
        //works just fine.
    }

    /// <summary>
    /// Checking the possibility of constructing a triangle with given side lengths. 
    /// If the length of each side of the triangle is greater than zero and
    /// less than the sum of the two remaining sides, the triangle can be constructed.
    /// Epsilon fixes the problem of @double type's inaccuracy
    /// </summary>
    /// <param name="a">the side length A (must be greater than zero)</param>
    /// <param name="b">the side length B (must be greater than zero)</param>
    /// <param name="c">the side length C (must be greater than zero)</param>
    public static void ThrowExceptionIfTriangleIsNotPossible(double a, double b, double c)
    {
        if (a <= Constants.Epsilon || b <= Constants.Epsilon || c <= Constants.Epsilon)
            throw new ArgumentException("The side length must be greater than zero.");

        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("In any triangle, the length of each side is less than " +
                                        "the sum of the lengths of the other two sides.");

        //NOTICE:
        //if(c-a-b >= _epsilon || b-a-c >= _epsilon || a-b-c >= _epsilon) throw new ArgumentException("...");
        //This code seems to be right but may produce bug if a+b is really close to c.
        //For example values a = 10, b = 10 and c = 20.00000000001 produces error in 
        //CalculateArea method because Math.Sqrt is trying to calculate the square root of zero.
    }

    /// <summary>
    /// Determines whether the triangle is a right triangle
    /// Epsilon fixes the problem of @double type's inaccuracy
    /// </summary>
    /// <returns>true if the triangle is right</returns>
    public bool IsTriangleRight()
    {
        var sides = new[] { _sideA, _sideB, _sideC };
        Array.Sort(sides);

        return Math.Abs(sides[2] * sides[2] - sides[0] * sides[0] - sides[1] * sides[1]) < Constants.Epsilon;
    }
}
