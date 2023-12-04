using System;

class Point
{
    private double x;
    private double y;
    private string name;

    public double X
    {
        get { return x; }
    }

    public double Y
    {
        get { return y; }
    }

    public string Name
    {
        get { return name; }
    }

    public Point(double x, double y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }
}

class Figure
{
    private Point[] points;

    public Figure(Point point1, Point point2, Point point3)
    {
        points = new Point[3] { point1, point2, point3 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        points = new Point[4] { point1, point2, point3, point4 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        points = new Point[5] { point1, point2, point3, point4, point5 };
    }

    public double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;

        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += GetSideLength(points[i], points[i + 1]);
        }

        perimeter += GetSideLength(points[points.Length - 1], points[0]);

        Console.WriteLine($"Назва багатокутника: {points.Length}-кут");
        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}

class Program
{
    static void Main()
    {
        Point point1 = new Point(0, 0, "A");
        Point point2 = new Point(0, 3, "B");
        Point point3 = new Point(4, 0, "C");

        Figure triangle = new Figure(point1, point2, point3);
        triangle.CalculatePerimeter();

        Point point4 = new Point(4, 3, "D");
        Figure quadrilateral = new Figure(point1, point2, point3, point4);
        quadrilateral.CalculatePerimeter();

        Console.ReadLine(); // Затримка, щоб консольне вікно не закрилося відразу
    }
}
