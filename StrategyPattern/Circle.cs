using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Circle : Shape
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; }

        public override string GetDrawMessage() => $"Drawing circle with radius {Radius}";
    }
}
