namespace VisitorPattern
{
    public class Circle : Shape
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; }

        public override float CalculateArea()
        {
            return (float)(Radius * Radius * System.Math.PI);
        }
    }
}
