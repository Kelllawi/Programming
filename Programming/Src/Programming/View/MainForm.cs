using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.View.Control;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private const int ElementsCount = 5;

        private readonly Color ErrorColor = Color.Pink;

        private readonly Color CorrectColor = Color.White;



        private Random _random = new Random();

        public MainForm()
        {
            InitializeComponent();
            Array allEnums = Enum.GetValues(typeof(Enums));
       

            
           
            
        }
  

        private void RectanglesGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void AddRectangleButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void RemoveRectangleButton_MouseMove(object sender, MouseEventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image= Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}