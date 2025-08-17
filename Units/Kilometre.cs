
using UnitConverter;
namespace Units
{
    public class Kilometre : LengthConverter
    {
        public override string Name => "kilometre";
        public override double ConvertToMetre(double length)
        {
            return length * 1000; 
        }
        public override double ConvertFromMetre(double length)
        {
            return length / 1000; 
        }
    }
}
