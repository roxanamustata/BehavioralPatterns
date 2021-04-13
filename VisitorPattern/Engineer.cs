using System;

namespace VisitorPattern
{
    public class Engineer
    {

        public void Notify((Shape, float) result)
        {
            (Shape shape, float area) = result;
            string resultAnalysis = (shape, area) switch
            {
                (Circle c, _) when area > 30 => $"Area of circle with radius {c.Radius} is too big",
                (Square s, _) when area > 20 => $"Area of square with length {s.Length} is too big",
                (Rectangle r, _) when area > 20 => $"Area of rectangle with length {r.Length} and width {r.Width} is too big",
                (Shape, _) when area <= 0 => "Impossible area",
                _ => "Seems right"

            };

            Console.WriteLine(resultAnalysis);
        }
    }
}