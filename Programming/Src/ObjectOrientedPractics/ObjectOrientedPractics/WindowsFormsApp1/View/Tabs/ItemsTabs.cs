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

        private List<Item> itemsdata= new List<Item>();


        public ItemsTabs()
        {
            InitializeComponent();
        }
        private void ClearItemsTextBox()
        {
            IdTextBox.Text = "";
            CostTextBox.Text = "";
            NameTextBox.Text = "";
            DescriptionTextBox.Text = "";
          
        }
        private void UpdateTextBox(Item item)
        {
            _currentitem = item;
            IdTextBox.Text=_currentitem.Id.ToString();
            CostTextBox.Text=_currentitem.Cost.ToString();
            NameTextBox.Text=_currentitem.Name.ToString();
            DescriptionTextBox.Text=_currentitem.Info.ToString();


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
    }
}
