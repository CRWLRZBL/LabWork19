﻿namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape shape1 = shapeFactory.GetShape("CIRCLE");
            shape1.Draw();

            IShape shape2 = shapeFactory.GetShape("RECTANGLE");
            shape2.Draw();

            IShape shape3 = shapeFactory.GetShape("SQUARE");
            shape3.Draw();

            IShape shape4 = shapeFactory.GetShape("TRIANGLE");
            shape4.Draw();
        }
    }
}
