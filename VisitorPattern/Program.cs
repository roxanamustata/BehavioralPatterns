using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IVisitable>
            {
                new Circle(5),
                new Circle(2),
                new Rectangle(2,3),
                new Square(12),
                new Circle(13),
                new Square(4),

             };

            IVisitor visitor1 = new BlackboardDrawerVisitor();

            try
            {
                shapes.ForEach(shape => shape.Accept(visitor1));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }



            IVisitor visitor2 = new PaperDrawerVisitor(30);

            try
            {
                shapes.ForEach(shape => shape.Accept(visitor2));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }


            var visitor3 = new AreaCalculatorVisitor();
            visitor3.AddSubscriber(new Engineer());

            try
            {
                shapes.ForEach(shape => shape.Accept(visitor3));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
    }
}
