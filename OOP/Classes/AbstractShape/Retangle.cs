using OOP.Classes.AbstractShape.Enums;

namespace OOP.Classes.AbstractShape
{
    public class Retangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retangle(double width, double height, Color color): base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
