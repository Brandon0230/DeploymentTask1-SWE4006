
using UnitConverter;
namespace Units
{
    public class Mile : LengthConverter
    {
        public override string Name => "mile";
        public override double ConvertToMetre(double length)
        {
            return length * 1609.34;
        }
        public override double ConvertFromMetre(double length)
        {
            return length / 1609.34;
        }
    }
}
