using System;

namespace PZ_OOP
{
    public interface IShape
    {
        void DrawType();
        void DrawSquare();
    }
    public interface IColoredShape
    {
        void DrawColor();
    }
    public class Circle : IShape
    {
        public string type;
        public int radius;
        public void DrawType()
        {
            Console.WriteLine("This is " + type);
        }
        public void DrawSquare()
        {
            Console.WriteLine("Square equal " + radius);
        }
    }
    public class ColoredCircle : Circle, IColoredShape, IShape
    {
        public string color;
        public void DrawColor()
        {
            Console.WriteLine("Color is " + color);
        }
        public void DrawSquare()
        {
            Console.WriteLine("Square equal 1001");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Object oArr = Array[];
            Circle c1 = new Circle();
            c1.radius = 10;
            c1.type = "Circle01";
            ColoredCircle cc1 = new ColoredCircle();
            cc1.color = "blue";
            c1.DrawType();
            c1.DrawSquare();
            cc1.DrawColor();
            cc1.DrawSquare();
        }
    }

}