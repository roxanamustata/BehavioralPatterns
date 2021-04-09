using System;

namespace VisitorPattern
{
    public class BlackboardDrawerVisitor : IVisitor
    {
        //public void Visit(Square square)
        //{
        //    Console.WriteLine($"Drawing square with length {square.Length} on blackboard");
        //}

        //public void Visit(Circle circle)
        //{
        //    Console.WriteLine($"Drawing circle with radius {circle.Radius} on blackboard");
        //}
        public void Visit(Shape shape)
        {
            var result = shape switch
            {
                Circle c => $"Drawing circle with radius {c.Radius} on blackboard",
                Square s => $"Drawing square with length {s.Length} on blackboard",
                _ => "Unknown shape"
            };
               Console.WriteLine(result);
        }
    }
}
