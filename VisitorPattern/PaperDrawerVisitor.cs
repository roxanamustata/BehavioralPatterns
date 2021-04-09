﻿using System;

namespace VisitorPattern
{
    public class PaperDrawerVisitor : IVisitor
    {
        private int capacity;

        public PaperDrawerVisitor(int capacity)
        {
            this.capacity = capacity;
        }

        public void Visit(Shape shape)
        {

            string result = shape switch
            {

                Square s => s switch
                {
                    _ when capacity < s.Length => $"{ShowError()}\nCurrent capacity {capacity} but tried to draw square of length {s.Length}",
                    _ => $"Drawing square with length {s.Length} on paper"
                },
                Circle c => c switch
                {
                    _ when capacity < c.Radius * 2 => $"{ShowError()}\nCurrent capacity {capacity} but tried to draw circle of diameter {c.Radius * 2}",
                    _ => $"Drawing circle with radius {c.Radius} on paper"
                },
                _ => "Unknown shape"


            };
            capacity -= shape switch
            {
                Square s => s.Length,
                Circle c => c.Radius * 2,
                _ => 0
            };
            Console.WriteLine(result);
        }

        //public void Visit(Square square)
        //{
        //    if (capacity - square.Length < 0)
        //    {
        //        ShowError();
        //        throw new InvalidOperationException($"Current capacity {capacity} but tried to draw square of length {square.Length}");
        //    }
        //    Console.WriteLine($"Drawing square with length {square.Length} on paper");
        //    capacity -= square.Length;
        //}

        //public void Visit(Circle circle)
        //{
        //    int diameter = 2 * circle.Radius;
        //    if (capacity - diameter < 0)
        //    {
        //        ShowError();
        //        throw new InvalidOperationException($"Current capacity {capacity} but tried to draw circle of diameter {diameter}");
        //    }
        //    Console.WriteLine($"Drawing circle with radius {circle.Radius} on paper");
        //    capacity -= diameter;
        //}

        private static string ShowError()
        {
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Max capacity reached");
            //Console.ResetColor();
            return "Max capacity reached";
        }

    }
}
