using System;

namespace VisitorPattern
{
    public class Engineer
    {

        public void Notify((Shape, float) result)
        {


            string resultAnalysis = result.Item2 switch
            {
                _ when result.Item2 > 0 => result.Item1 switch
                {
                    Square s => s switch
                    {
                        _ when s.CalculateArea() > 20 => $"Area of square with length {s.Length} is too big",
                        _ => "Seems right"
                    },

                    Circle c => c switch
                    {
                        _ when c.CalculateArea() > 30 => $"Area of circle with radius {c.Radius} is too big",
                        _ => "Seems right"
                    },
                    Rectangle r => r switch
                    {
                        _ when r.CalculateArea() > 20 => $"Area of rectangle with length {r.Length} and width {r.Width} is too big",
                        _ => "Seems right"
                    },
                    _ => "Unknown shape"
                },
                _ when result.Item2 <= 0 => "Impossible area",
                _ => "Unknown result"


            };
            Console.WriteLine(resultAnalysis);
        }
    }
}