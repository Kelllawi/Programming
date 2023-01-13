using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTabs : UserControl
    {
       private List<Item> _items = new List<Item>();

        private Item _currentitem;

        private ToolTip _toolTip = new ToolTip();

       

        public ItemsTabs()
        {
            InitializeComponent();


            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            
            if (ItemsListBox.Items.Count != 0) 
            {
                ItemsListBox.SelectedIndex = 0;
            }
        }
        private void ClearItemsTextBox()
        {
            IdTextBox.Text = "";
            CostTextBox.Text = "";
            NameTextBox.Text = "";
            DescriptionTextBox.Text = "";
          
        }

        private void UpdateListBox(int index)
        {
            List<Item> items=_items;
            ItemsListBox.Items.Clear();
            foreach (var item in items)
            {
                if (item.Name !=null)
                {
                    ItemsListBox.Items.Add($"{item.Name}");
                }
               
            }
            ItemsListBox.SelectedIndex = index;
        }
        private void UpdateTextBox(Item item)
        {
            _currentitem = item;
            IdTextBox.Text=_currentitem.Id.ToString();
            CostTextBox.Text=_currentitem.Cost.ToString();
            NameTextBox.Text=_currentitem.Name.ToString();
            DescriptionTextBox.Text=_currentitem.Info.ToString();
            CategoryComboBox.SelectedItem = item.category;


        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _items.Add  (new Item());
            _currentitem=_items.Last();
            ItemsListBox.Items.Add(_currentitem.Name);




        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                if (_items.Count > 0)
                {
                    ItemsListBox.SelectedIndex = 0;

                }
                else
                {
                    ClearItemsTextBox();
                }
                return;
            } 
            _currentitem= _items[ItemsListBox.SelectedIndex];
            UpdateTextBox(_currentitem);
           

            
          

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0) return;
            _items.RemoveAt(ItemsListBox.SelectedIndex);
            ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);


        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentitem.Cost=Convert.ToDouble(CostTextBox.Text);
                CostTextBox.BackColor=Color.White;
                
            }
            catch(Exception ex) 
            {
                _toolTip.SetToolTip(CostTextBox, ex.Message);
                CostTextBox.BackColor= Color.Red;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentitem.Name= Convert.ToString(NameTextBox.Text);
                NameTextBox.BackColor= Color.White;
                UpdateListBox(_items.IndexOf(_currentitem));

            }
            catch(Exception ex)
            {
                _toolTip.SetToolTip(NameTextBox,ex.Message);
                NameTextBox.BackColor= Color.Red;
            }

        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentitem.Info= Convert.ToString(DescriptionTextBox.Text);
                DescriptionTextBox.BackColor= Color.White;

            }
            catch(Exception ex)
            {
                _toolTip.SetToolTip(DescriptionTextBox,ex.Message);
                DescriptionTextBox.BackColor= Color.Red;

            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentitem == null)
                {
                    return;
                }
                _currentitem.category=(Category)CategoryComboBox.SelectedItem;

            }
            catch(Exception ex)
            {
                _toolTip.SetToolTip(CategoryComboBox,ex.Message);  
                CategoryComboBox.BackColor= Color.Red;
            }
        }
    }
}
