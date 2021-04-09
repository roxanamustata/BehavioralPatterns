using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Square(15);

            shape.Draw();
        }
    }
}
