﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class Square : Shape
    {
        public Square(int length)
        {
            Length = length;
        }

        public int Length { get; }

        protected override void DrawConcreteShape()
        {
            Console.WriteLine($"Drawing square with length {Length}");
        }
    }
}
