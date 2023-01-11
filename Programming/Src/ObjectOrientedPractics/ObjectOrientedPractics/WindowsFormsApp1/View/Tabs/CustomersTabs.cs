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


namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTabs : UserControl
    {
        private List<Customers> _customer = new List<Customers>();

        private Customers _currentCustomers;

        private ToolTip _toolTip = new ToolTip();

        public CustomersTabs()
        {
            InitializeComponent();
        }

        private void ClearCustomerTextBox()
        {
            CustomerIdTextBox.Text = "";
            FullNameTextBox.Text = "";
            AddressTextBox.Text = "";

        }
        private void UpdateTextBox(Customers customers)
        {
            _currentCustomers= customers;
            CustomerIdTextBox.Text=_currentCustomers.Id.ToString();
            FullNameTextBox.Text=_currentCustomers.FullName.ToString();
            AddressTextBox.Text=_currentCustomers.Address.ToString();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex ==-1)
            {
                if (_customer.Count >0)
                {
                    CustomersListBox.SelectedIndex = 0;
                }
                else
                {
                    ClearCustomerTextBox();
                }
                return;
            }
            _currentCustomers = _customer[CustomersListBox.SelectedIndex];
            UpdateTextBox(_currentCustomers);


        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _customer.Add(new Customers());
            _currentCustomers=_customer.Last();
            CustomersListBox.Items.Add(_currentCustomers);

            
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(CustomersListBox.Items.Count== 0) { return; }
            _customer.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
        }

        private void CustomerIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomers.FullName=Convert.ToString(FullNameTextBox.Text);
                FullNameTextBox.BackColor=Color.White;

            }
            catch(Exception ex)
            {
                _toolTip.SetToolTip(FullNameTextBox, ex.Message);
                FullNameTextBox.BackColor=Color.Red;

            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomers.Address=Convert.ToString(AddressTextBox.Text);
                AddressTextBox.BackColor=Color.White;

            }
            catch(Exception ex)
            {
                _toolTip.SetToolTip(AddressTextBox, ex.Message);
                AddressTextBox.BackColor=Color.Red;
            }
        }
    }
}
