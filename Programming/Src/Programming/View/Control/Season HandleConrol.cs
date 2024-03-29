﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Enums;
using System.Windows.Forms;
using Colors = Programming.Model.AppColors;

namespace Programming.View.Control
{
    /// <summary>
    /// Представляет реализацию по выбору времени года
    /// </summary>
    public partial class Season_HandleConrol : UserControl
    {
        /// <summary>
        /// Создает Экземпляр класса <see cref="Season_HandleConrol"/>
        /// </summary>
        public Season_HandleConrol()
        {
            InitializeComponent();
            
            var values = Enum.GetValues(typeof(Season));

            foreach (var value in values)
            {
                SeasonNamesComboBox.Items.Add(value.ToString());
            }
            SeasonNamesComboBox.SelectedIndex = 0;

            SeasonNamesComboBox.DataSource = Enum.GetValues(typeof(Season));
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonNamesComboBox.SelectedItem)
            {
                case Season.Winter:
                    BackColor = Colors.Winter;
                    MessageBox.Show("Brrrr! Сoldly!");
                    break;
                case Season.Summer:
                    BackColor = Colors.Summer;
                    MessageBox.Show("Yeaaa! Sun!");
                    break;
                case Season.Spring:
                    BackColor = Colors.Spring;
                    break;
                case Season.Autumn:
                    BackColor = Colors.Autumn;
                    break;
            }
        }

        
    }
}
