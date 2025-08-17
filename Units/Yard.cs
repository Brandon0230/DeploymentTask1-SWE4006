
using UnitConverter;
namespace Units
{
    public class Yard : LengthConverter
    {
        public override string Name => "yard";
        public override double ConvertFromMetre(double length)
        {
            return length / 0.9144;
        }
        public override double ConvertToMetre(double length)
        {
            return length * 0.9144;
        }
    }
}
