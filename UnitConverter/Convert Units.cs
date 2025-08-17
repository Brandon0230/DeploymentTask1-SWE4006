
namespace UnitConverter
{
    public class Convert_Units
    {
        public double Convert(double length, LengthConverter fromConverter, LengthConverter toConverter)
        {
            double lengthInMeters = fromConverter.ConvertToMetre(length);
            return toConverter.ConvertFromMetre(lengthInMeters);
        }
    }
}
