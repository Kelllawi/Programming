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

        public List<Customers> Customers
        { get 
            {
                return _customer;
            } 
            set 
            {
                _customer = value;
                UpdateListBox();
            }
        }

        public void UpdateListBox()
        {
            CustomersListBox.Items.Clear();
            for (int i = 0; i < _customer.Count; i++)
            {
                CustomersListBox.Items.Add(_customer[i].FullName);
            }
        }

        public CustomersTabs()
        {
            InitializeComponent();
            _customer = Customers;
        }

        private void ClearCustomerTextBox()
        {
            CustomerIdTextBox.Text = "";
            FullNameTextBox.Text = "";
          

        }
        private void UpdateTextBox(Customers customers)
        {
            _currentCustomers= customers;
            CustomerIdTextBox.Text=_currentCustomers.Id.ToString();
            FullNameTextBox.Text=_currentCustomers.FullName.ToString();
            addressContorl1.address =customers.Address;
            addressContorl1.UpdateAddress();

         
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
            CustomersListBox.Items.Add(_currentCustomers.FullName);

            
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(CustomersListBox.Items.Count== 0) { return; }
            _customer.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
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

      
    }
}
