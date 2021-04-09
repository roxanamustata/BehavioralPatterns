using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Square : Shape
    {
        public Square(int length)
        {
            Length = length;
        }

        public int Length { get; }

        public override string GetDrawMessage() => $"Drawing square with length {Length}";
    }
}
