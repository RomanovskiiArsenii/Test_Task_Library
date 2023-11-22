using Test_Task_Library;

class Program
{
    static void Main()
    {
        //Some samples of library using

        Shape shape;
        
        shape = new Circle(10);
        Console.WriteLine($"Area of {shape.GetType().Name} is {shape.CalculateArea()}");

        shape = new Triangle(9, 12, 15);
        Console.WriteLine($"Area of {shape.GetType().Name} is {shape.CalculateArea()}");

        Triangle? triangle = shape as Triangle;
        Console.WriteLine(triangle?.IsTriangleRight());

        //exceptions

        try { shape = new Circle(0); }
        catch (Exception e) { Console.WriteLine(e.Message); }

        try { shape = new Triangle(9, 0, 100); }
        catch (Exception e) { Console.WriteLine(e.Message); }

        try { shape = new Triangle(9, 12, 100); }
        catch (Exception e) { Console.WriteLine(e.Message); }
    }
}






