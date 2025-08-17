
using UnitConverter;
namespace Units
{
    public class Metre : LengthConverter
    {
        public override string Name => "metre";
        public override double ConvertToMetre(double length)
        {
            return length; 
        }
        public override double ConvertFromMetre(double length)
        {
            return length; 
        }
    }
}
