using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Square(10);
            ShapeDrawer drawer = new ShapeDrawer(shape);
            drawer.Draw();
        }
    }
}
