
namespace UnitConverter
{
    public abstract class LengthConverter
    {
        public abstract string Name { get; }
        public abstract double ConvertToMetre(double length);
        public abstract double ConvertFromMetre(double length);
    }
}
