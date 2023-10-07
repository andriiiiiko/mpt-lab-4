namespace mpt_lab_4;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter coefficients for line AB (a1 and b1):");
        double a1 = double.Parse(Console.ReadLine());
        double b1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter coefficients for line CD (a2 and b2):");
        double a2 = double.Parse(Console.ReadLine());
        double b2 = double.Parse(Console.ReadLine());

        Line lineAB = new Line(a1, b1);
        Line lineCD = new Line(a2, b2);

        Console.WriteLine("\nLine AB:");
        lineAB.DisplayEquation();
        Console.WriteLine($"X-intercept: ({lineAB.FindXIntercept()}, 0)");
        Console.WriteLine($"Y-intercept: (0, {lineAB.FindYIntercept()})");

        Console.WriteLine("\nLine CD:");
        lineCD.DisplayEquation();
        Console.WriteLine($"X-intercept: ({lineCD.FindXIntercept()}, 0)");
        Console.WriteLine($"Y-intercept: (0, {lineCD.FindYIntercept()})");

        if (lineAB.IsPerpendicular(lineCD))
        {
            Console.WriteLine("\nLines AB and CD are perpendicular.");
        }
        else
        {
            Console.WriteLine("\nLines AB and CD are not perpendicular.");
        }

        double angle = lineAB.CalculateAngle(lineCD);
        Console.WriteLine($"Angle between lines AB and CD: {angle} degrees");
    }
}