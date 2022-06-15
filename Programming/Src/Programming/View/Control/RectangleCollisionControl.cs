using System;
using System.Collections.Generic;
using Programming.Model.Geometryy;
using System.Drawing;
using System.Windows.Forms;
using Colors = Programming.Model.AppColors;
using Rectangle = Programming.Model.Geometryy.Rectangle;

namespace Programming.View.Control
{
    public partial class RectangleCollisionControl : UserControl
    {
        private List<Rectangle> _rectangle = new List<Rectangle>();
        private Rectangle _currentrectangle;
        private List<Panel> _rectanglePanels = new List<Panel>();

        public RectangleCollisionControl()
        {
            InitializeComponent();
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
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }



        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            var newRectangle = RectangleFactory.Randomize(CanvaPanel.Width, CanvaPanel.Height);
            _rectangle.Add(newRectangle);

            Panel rectanglePanel = new Panel();
            {
                Width = newRectangle.Width;
                Height = newRectangle.Height;
                Location = new Point(newRectangle.Center.X, newRectangle.Center.Y);
                BackColor = Colors.IsNotCollision;
                BorderStyle = BorderStyle.FixedSingle;
            }

            _rectanglePanels.Add(rectanglePanel);
            CanvaPanel.Controls.Add(rectanglePanel);
        }

        private void AddingRectaglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddingRectaglesListBox.Items.Clear();
             for (int i = 0; i < _rectangle.Count; i++)
            {
                AddingRectaglesListBox.Items.Add(_rectangle[i].GetRectangleInfo());
            }
            AddingRectaglesListBox.SelectedIndex = _rectangle.Count - 1;

        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateListBoexs()
        {
            AddingRectaglesListBox.Items.Clear();
            for (int i = 0; i < _rectangle.Count; i++)
            {
                AddingRectaglesListBox.Items.Add(_rectangle[i].GetRectangleInfo());
            }
            AddingRectaglesListBox.SelectedIndex = _rectangle.Count - 1;
        }
    }
}
