
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PopUpForm
{
    public partial class PopUpForm : Form
    {
        //Creates a Random Obj to Generate the Random Coordinates for the PopUp Forms
        private static Random randomCoordinates = new Random();
        public PopUpForm()
        {
            InitializeComponent();
        }
            public int i = 1;
        private void popupBtn_Click(object sender, EventArgs e)
        {
            //Makes 3 Random PopUp Forms on a Single Button Click
            for (int j = 0; j < 3; j++)
            {
                Form PopUp = new Form();
                ShowPopUp(PopUp);
            }
        }
        private void ShowPopUp(Form PopUpForm)
        {
            //Set the Primary Screen's Working Area
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
            //set the maximum X and Y coordinates
            int maxX = workingArea.Width - this.Width;
            int maxY = workingArea.Height - this.Height;
            //set Random coordinates within the working area
            int randomX = randomCoordinates.Next(0, maxX);
            int randomY = randomCoordinates.Next(0, maxY);
            //Set PopUp Form Properties
            PopUpForm.Text = $"PopUp Form {i}";
            PopUpForm.Name = $"PopUp Form {i}";
            PopUpForm.Controls.Add(new Label
            {
                Text = $"PopUp Detected Number {i}",
                AutoSize = true,
                Location = new Point(10, 10)
            });
            //Set the PopUp Form Location
            PopUpForm.StartPosition = FormStartPosition.Manual;
            PopUpForm.Location = new Point(randomX, randomY);
            //Show the PopUp Form
            PopUpForm.Show();
            i++;
        }

        private void popupLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
