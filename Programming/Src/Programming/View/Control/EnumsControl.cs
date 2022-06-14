using Programming.Model.Enums;
using System;
using System.Windows.Forms;
namespace Programming.View.Control
{

    public partial class EnumsControl : UserControl
    {

        public EnumsControl()
        {
            InitializeComponent();
            foreachforeach(Enums enumsValues in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(enumsValues);
            }

            EnumsListBox.SelectedIndex = 0;
            ValuesListBox.SelectedIndex = 0;
        }

        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IntValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
