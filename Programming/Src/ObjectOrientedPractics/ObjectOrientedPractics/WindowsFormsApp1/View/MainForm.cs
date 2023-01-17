﻿using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store=new Store();
        public MainForm()
        {
            InitializeComponent();
            itemsTabs1.Items=_store.Items;
            customersTabs1.Customers=_store.Customers;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
