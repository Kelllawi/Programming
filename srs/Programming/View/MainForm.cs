using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;
using Programming.View;

namespace WindowsFormsApp5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            foreach (Enums enumsValues in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(enumsValues);
            }
            EnumsListBox.SelectedIndex = 0;
             Array initSeasonValues = Enum.GetValues(typeof(Seasons));
            foreach (Seasons value in initSeasonValues)
            {
                comboBox2.Items.Add(value);
            }
            comboBox2.SelectedIndex = 0;



        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueListBox.Items.Clear();
            var item = (Enums)EnumsListBox.SelectedItem;
            
            Array values;

            switch (item)
            {
                case Enums.Color:
                    values = Enum.GetValues(typeof(Seasons));
                    break;
                case Enums.Genre:
                    values = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.EducationForm:
                    values = Enum.GetValues(typeof(EducationForm));
                    break;
                case Enums.Manufactures:
                    values = Enum.GetValues(typeof(Manufactures));
                    break;
                case Enums.Seasons:
                    values = Enum.GetValues(typeof(Seasons));
                    break;
                case Enums.Weekday:
                    values = Enum.GetValues(typeof(Weekday));
                    break;
                default:
                    throw new NotImplementedException();
            }

            foreach (var value in values)
            {
                ValueListBox.Items.Add(value);
            }

        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValueListBox.SelectedItem;
            textBox1.Text =((int)item).ToString();
          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ParseInput_Click(object sender, EventArgs e)
        {
            var text = WeekTextbox.Text;
            Weekday day;

            if (Enum.TryParse(text, out day))
            {
                OutLabelWeekday.Text = $"Это день недели ({day} = {(int)day})";
            }
            else
            {
                OutLabelWeekday.Text = "Нет такого дня недели!";
            }
        }

        private void OutLabel_Click(object sender, EventArgs e)
        {

        }

        private void Gobutton_Click(object sender, EventArgs e)
        {
            var value = comboBox2.SelectedItem;
            switch (value)
            {
                case Seasons.Winter:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Seasons.Summer:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Seasons.Spring:
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Seasons.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Weekday_Enter(object sender, EventArgs e)
        {

        }
    }
}

