using System;

namespace VisitorPattern
{
    public class BlackboardDrawerVisitor : IVisitor
    {
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
