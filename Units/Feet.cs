
using UnitConverter;
namespace Units
{
    public class Feet : LengthConverter
    {
        public override string Name => "feet";
        public override double ConvertToMetre(double length)
        {
            return length * 0.3048;
        }
        public override double ConvertFromMetre(double length)
        {
            return length / 0.3048;
        }
    }
}
