using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Control
{
    public partial class AddressContorl : UserControl
    {
        public AddressContorl()
        {
            InitializeComponent();
        }

        private ToolTip _tooltip = new ToolTip();   

        private Address _address = new Address();

        public Address address
        { get 
            { return _address; }
          set { _address = value; }
        }


        public void UpdateAddress()
        {
            PostIndexTextBox.Text=address.Index.ToString(); 
            CountryTextBox.Text=address.Country.ToString();
            CityTextBox.Text=address.City.ToString();
            BuildingTextBox.Text=address.Building.ToString();
            StreetTextBox.Text=address.Street.ToString();
            ApartmenTextBox.Text=address.Apartament.ToString();
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                address.Index=int.Parse(PostIndexTextBox.Text);
                PostIndexTextBox.BackColor=Color.White;
            }
            catch (Exception ex )
            {
                _tooltip.SetToolTip(PostIndexTextBox, ex.Message);
                PostIndexTextBox.BackColor= Color.Red;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                address.Country=CountryTextBox.Text;
                CountryTextBox.BackColor=Color.White;

            }
            catch (Exception ex)
            {
                _tooltip.SetToolTip(CountryTextBox, ex.Message);
                CountryTextBox.BackColor= Color.Red;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            { address.City=CityTextBox.Text;
                CityTextBox.BackColor=Color.White;
            }
            catch(Exception ex)
            {
                _tooltip.SetToolTip(CityTextBox, ex.Message);
                CityTextBox.BackColor= Color.Red;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                address.Street=StreetTextBox.Text;
                StreetTextBox.BackColor=Color.White;
            }
            catch (Exception ex )
            {
                _tooltip.SetToolTip(StreetTextBox,ex.Message);
                StreetTextBox.BackColor= Color.Red;
            }

        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                address.Building=BuildingTextBox.Text;
                BuildingTextBox.BackColor=Color.White;
            }
            catch (Exception ex )
            {
                _tooltip.SetToolTip(BuildingTextBox,ex.Message);
                BuildingTextBox.BackColor= Color.Red;
            }

        }

        private void ApartmenTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                address.Apartament=ApartmenTextBox.Text;
                ApartmenTextBox.BackColor=Color.White;
            }
            catch (Exception ex)
            {
                _tooltip.SetToolTip(ApartmenTextBox,ex.Message);
                ApartmenTextBox.BackColor= Color.Red;
            }
        }
    }
}
