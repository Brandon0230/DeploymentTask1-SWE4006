
using UnitConverter;
namespace Units
{
    public class Inch : LengthConverter
    {
        public override string Name => "inch";
        public override double ConvertToMetre(double length)
        {
            return length * 0.0254;
        }
        public override double ConvertFromMetre(double length)
        {
            return length / 0.0254;
        }
    }
}