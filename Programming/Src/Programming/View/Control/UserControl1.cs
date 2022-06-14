using System;
using Programming.Model.Enums;
using System.Windows.Forms;

namespace Programming.View.Control
{
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseWeekdayButton_Click(object sender, EventArgs e)
        {
            var text = WeekdayTextBox.Text;
           
            if (Enum.TryParse(text, out Weekday day))
            {
                OutputWeekdayLabel.Text = $"Это день недели ({day} - {(int)day})";
            }
            else
            {
                OutputWeekdayLabel.Text = "Нет такого дня недели";
            }
        }
    }
}
