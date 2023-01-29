using Interfaces.Entities.InheritanceWithInterface.Enums;

namespace Interfaces.Entities.InheritanceWithInterface
{
    public abstract class Shape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
