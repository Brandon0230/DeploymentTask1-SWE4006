using System;
using System.Windows.Forms;
using UnitConverter;
using Units;

namespace DTask
{
    public partial class UnitConverterForm : Form
    {
        public UnitConverterForm()
        {
            InitializeComponent();
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try //Handles type checking for the inputs
            {
                if ((dropDnTo.SelectedItem?.ToString()) == null || (dropDnFrom.SelectedItem?.ToString()) == null)
                {
                    MessageBox.Show("Please select Units.");
                }
                else
                {
                    var ConvertFromValue = GetConverter(dropDnFrom.SelectedItem.ToString());
                    var ConvertToValue = GetConverter(dropDnTo.SelectedItem.ToString());
                    if (!double.TryParse(txtBxInput.Text, out double inputValue))
                    {
                        MessageBox.Show("Please enter a valid number.");
                    }
                    else
                    {
                        var converter = new Convert_Units();
                        double output = converter.Convert(inputValue, ConvertFromValue, ConvertToValue); //Converts the Units
                        lblOutput.Text = output.ToString() + " " + ConvertToValue.Name; // Display result
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }
        }
        public LengthConverter GetConverter(string unit)
        {
            switch (unit.ToLower()) //converts the value of selected unit to create a Class
            {
                case "feet":
                    return new Feet();
                case "inch":
                    return new Inch();
                case "kilometre":
                    return new Kilometre();
                case "metre":
                    return new Metre();
                case "yard":
                    return new Yard();
                case "mile":
                    return new Mile();
                default:
                    throw new ArgumentException("Unknown unit: " + unit);
            }
        }
    }
}
