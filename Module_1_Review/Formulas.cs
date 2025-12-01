namespace Module_1_Review;

public class Formulas
{
    static void AreaOfACircle()
    {
        Console.WriteLine("What is the Radius of the circle?");
        var radius = double.Parse(Console.ReadLine());
        
        var circleArea = (3.14 * (radius * radius));
        
        Console.WriteLine($"The area of the Circle is {circleArea}");
        
    }

    static void AreaOfATriangle()
    {
        Console.WriteLine("What is the Base of the triangle?");
        var userBase = double.Parse(Console.ReadLine());

        Console.WriteLine("What is the Height of the triangle?");
        var userHeight = double.Parse(Console.ReadLine());
        
        var triangleArea = (0.5 * (userBase * userHeight));
        Console.WriteLine($"The area of the triangle is {triangleArea}");
    }

    static void AreaOfARectangle()
    {
        Console.WriteLine("What is the Length of the rectangle?");
        var userLength = double.Parse(Console.ReadLine());
        
        Console.WriteLine("What is the Width of the rectangle?");
        var userWidth = double.Parse(Console.ReadLine());
        
        var rectangleArea = (userLength * userWidth);
        Console.WriteLine($"The area of the rectangle is {rectangleArea}");
    }

     static void AreaOfASquare()
    {
        Console.WriteLine("What is the Side of the square?");
        var userSide = double.Parse(Console.ReadLine());
        
        var squareArea = (userSide * userSide);
        Console.WriteLine($"The area of the square is {squareArea}");
    }


    public static void MethodRun()
    {
        AreaOfACircle();
        AreaOfATriangle();
        AreaOfARectangle();
        AreaOfASquare();
    }
    
}


