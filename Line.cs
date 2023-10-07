namespace mpt_lab_4;

/// <summary>
/// Represents a line in the form of y = ax + b.
/// </summary>
public class Line
{
    private readonly double _a;
    private readonly double _b;

    /// <summary>
    /// Initializes a new instance of the Line class with the specified coefficients.
    /// </summary>
    /// <param name="a">The coefficient 'a' in the line equation y = ax + b.</param>
    /// <param name="b">The coefficient 'b' in the line equation y = ax + b.</param>
    public Line(double a, double b)
    {
        _a = a;
        _b = b;
    }

    /// <summary>
    /// Displays the equation of the line in the form y = ax + b.
    /// </summary>
    public void DisplayEquation()
    {
        Console.WriteLine($"Equation of the line: y = {_a} * x + {_b}");
    }

    /// <summary>
    /// Calculates and returns the x-intercept of the line.
    /// </summary>
    /// <returns>The x-coordinate of the x-intercept point.</returns>
    public double FindXIntercept()
    {
        return -_b / _a;
    }

    /// <summary>
    /// Returns the y-intercept of the line.
    /// </summary>
    /// <returns>The y-coordinate of the y-intercept point.</returns>
    public double FindYIntercept()
    {
        return _b;
    }

    /// <summary>
    /// Checks if the current line is perpendicular to another line.
    /// </summary>
    /// <param name="otherLine">The other line to check for perpendicularity.</param>
    /// <returns>True if the lines are perpendicular; otherwise, false.</returns>
    public bool IsPerpendicular(Line otherLine)
    {
        return Math.Abs(_a * otherLine._a + 1) < 1e-6;
    }

    /// <summary>
    /// Calculates and returns the angle between the current line and another line in degrees.
    /// </summary>
    /// <param name="otherLine">The other line to calculate the angle with.</param>
    /// <returns>The angle between the lines in degrees.</returns>
    public double CalculateAngle(Line otherLine)
    {
        double angle = Math.Atan(Math.Abs((_a - otherLine._a) / (1 + _a * otherLine._a)));
        return angle * (180 / Math.PI);
    }
}
