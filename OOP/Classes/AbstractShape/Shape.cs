using OOP.Classes.AbstractShape.Enums;


namespace OOP.Classes.AbstractShape
{
    public abstract class Shape
    {

        public Color Color { get; set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
    


}
