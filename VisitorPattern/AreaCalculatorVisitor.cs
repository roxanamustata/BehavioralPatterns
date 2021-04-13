using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class AreaCalculatorVisitor : IVisitor
    {
        private List<Engineer> subscribers;

        public AreaCalculatorVisitor()
        {
            this.subscribers = new List<Engineer>();
        }
        public void AddSubscriber(Engineer subscriber)
        {
            this.subscribers.Add(subscriber);
        }
        public void Publish((Shape, float) result)
        {
            this.subscribers.ForEach(s => s.Notify(result));
        }

        public void Visit(Shape shape)
        {
            var area = 0;
            (Shape, float) result = (shape, area) switch
            {
                (Circle c, _) => (c, (float)(c.Radius * c.Radius * Math.PI)),
                (Square s, _) => (s, s.Length * s.Length),
                (Rectangle r, _) => (r, r.Length * r.Width),
                _ => throw new Exception("Unknown shape")
            };

            Publish(result);


        }
    }
}
